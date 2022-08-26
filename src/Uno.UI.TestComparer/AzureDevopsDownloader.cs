using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;
using Refit;

namespace Uno.UI.TestComparer
{
	class AzureDevopsDownloader
	{
		private readonly string _pat;
		private readonly Action<string> _log;
		private readonly string _collectionUri;

		public AzureDevopsDownloader(string pat, string collectionUri, Action<string> log)
		{
			_pat = pat;
			_log = log;
			_collectionUri = collectionUri;
		}

		private void Log(string message) => _log(message);

		public async Task<string[]> DownloadArtifacts(string basePath,
									  string project,
									  string definitionName,
									  string artifactName,
									  string sourceBranch,
									  string targetBranchName,
									  int buildId,
									  int runLimit)
		{
			Directory.CreateDirectory(basePath);

			var connection = new VssConnection(new Uri(_collectionUri), new VssBasicCredential(string.Empty, _pat));

			var client = await connection.GetClientAsync<BuildHttpClient>();

			if (!targetBranchName.StartsWith("refs/heads/"))
			{
				targetBranchName = "refs/heads/" + targetBranchName;
			}

			Log($"Getting definitions ({basePath}, {project}, {definitionName}, {artifactName}, {sourceBranch}, {targetBranchName}, {buildId}, {runLimit})");
			var definitions = await client.GetDefinitionsAsync(project, name: definitionName);

			Log("Getting builds");
			var builds = await client.GetBuildsAsync(
				project,
				definitions: new[] { definitions.First().Id },
				branchName: targetBranchName,
				top: runLimit,
				queryOrder: BuildQueryOrder.FinishTimeDescending,
				statusFilter: BuildStatus.Completed,
				resultFilter: BuildResult.Succeeded);

			var currentBuild = await client.GetBuildAsync(project, buildId);

			var suceededBuilds = builds
				.Distinct(new BuildComparer())
				.OrderBy(b => b.FinishTime)
				.Concat(new[] { currentBuild });

			string BuildArtifactPath(Build build)
				=> Path.Combine(basePath, $@"artifacts\{build.LastChangedDate:yyyyMMdd-hhmmss}-{build.Id}");

			foreach (var build in suceededBuilds)
			{
				var fullPath = BuildArtifactPath(build);

				if (!Directory.Exists(fullPath))
				{
					var tempFile = Path.GetTempFileName();

					var artifacts = await client.GetArtifactsAsync(project, build.Id);

					if (artifacts.Any(a => a.Name == artifactName))
					{
						Log($"Getting artifact for build {build.Id}");
						using (var zipStream = await client.GetArtifactContentZipAsync(project, build.Id, artifactName))
						{
							Log($"Extracting stream artifact for build {build.Id}");

							fullPath = fullPath.Replace("\\\\", "\\");

							using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Read, false))
							{
								int entryIndex = 0;
								var entriesCount = archive.Entries;

								foreach (var entry in archive.Entries)
								{
									entryIndex++;

									if ((entryIndex % 100) == 0)
									{
										Log($"Extracting {entryIndex}/entriesCount");
									}

									var outPath = Path.Combine(fullPath, entry.FullName.Replace("/", "\\"));

									if (outPath.EndsWith("\\"))
									{
										Directory.CreateDirectory(@"\\?\" + outPath);
									}
									else
									{
										using (var stream = entry.Open())
										{
											using (var outStream = File.OpenWrite(@"\\?\" + outPath))
											{
												await stream.CopyToAsync(outStream);
											}
										}
									}
								}
							}
						}


					}
					else
					{
						Log($"Skipping download artifact for build {build.Id} (The artifact {artifactName} cannot be found)");
					}
				}
				else
				{
					Log($"Skipping already downloaded build {build.Id} artifacts");
				}
			}

			return suceededBuilds.Select(BuildArtifactPath).ToArray();
		}

		private class BuildComparer : IEqualityComparer<Build>
		{
			public bool Equals(Build x, Build y) => x.Id == y.Id;
			public int GetHashCode(Build obj) => obj.Id.GetHashCode();
		}

	}
}
