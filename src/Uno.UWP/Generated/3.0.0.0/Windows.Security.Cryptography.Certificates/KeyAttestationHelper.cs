#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Cryptography.Certificates
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class KeyAttestationHelper 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> DecryptTpmAttestationCredentialAsync( string credential,  string containerName)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> KeyAttestationHelper.DecryptTpmAttestationCredentialAsync(string credential, string containerName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20KeyAttestationHelper.DecryptTpmAttestationCredentialAsync%28string%20credential%2C%20string%20containerName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> DecryptTpmAttestationCredentialAsync( string credential)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> KeyAttestationHelper.DecryptTpmAttestationCredentialAsync(string credential) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20KeyAttestationHelper.DecryptTpmAttestationCredentialAsync%28string%20credential%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetTpmAttestationCredentialId( string credential)
		{
			throw new global::System.NotImplementedException("The member string KeyAttestationHelper.GetTpmAttestationCredentialId(string credential) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20KeyAttestationHelper.GetTpmAttestationCredentialId%28string%20credential%29");
		}
		#endif
	}
}
