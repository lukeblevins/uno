#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMailboxChangedDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member EmailMailboxChangedDeferral EmailMailboxChangedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxChangedDeferral%20EmailMailboxChangedEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
