#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Maps.OfflineMaps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class OfflineMapPackageStartDownloadResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member OfflineMapPackageStartDownloadStatus OfflineMapPackageStartDownloadResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=OfflineMapPackageStartDownloadStatus%20OfflineMapPackageStartDownloadResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Services.Maps.OfflineMaps.OfflineMapPackageStartDownloadResult.Status.get
	}
}
