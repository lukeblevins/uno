#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemConnectionInfo 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsProximal
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RemoteSystemConnectionInfo.IsProximal is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20RemoteSystemConnectionInfo.IsProximal");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemConnectionInfo.IsProximal.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.RemoteSystems.RemoteSystemConnectionInfo TryCreateFromAppServiceConnection( global::Windows.ApplicationModel.AppService.AppServiceConnection connection)
		{
			throw new global::System.NotImplementedException("The member RemoteSystemConnectionInfo RemoteSystemConnectionInfo.TryCreateFromAppServiceConnection(AppServiceConnection connection) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemConnectionInfo%20RemoteSystemConnectionInfo.TryCreateFromAppServiceConnection%28AppServiceConnection%20connection%29");
		}
		#endif
	}
}
