#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UnhandledErrorDetectedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Core.UnhandledError UnhandledError
		{
			get
			{
				throw new global::System.NotImplementedException("The member UnhandledError UnhandledErrorDetectedEventArgs.UnhandledError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UnhandledError%20UnhandledErrorDetectedEventArgs.UnhandledError");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs.UnhandledError.get
	}
}
