#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.System.Profile
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class RetailMode 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool RetailModeEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RetailMode.RetailModeEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20RetailMode.RetailModeEnabled");
			}
		}
		#endif
		// Forced skipping of method Windows.Phone.System.Profile.RetailMode.RetailModeEnabled.get
	}
}
