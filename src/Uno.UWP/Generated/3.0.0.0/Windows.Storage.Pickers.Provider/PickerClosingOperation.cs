#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Pickers.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PickerClosingOperation 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Deadline
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset PickerClosingOperation.Deadline is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20PickerClosingOperation.Deadline");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Pickers.Provider.PickerClosingDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member PickerClosingDeferral PickerClosingOperation.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PickerClosingDeferral%20PickerClosingOperation.GetDeferral%28%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.Pickers.Provider.PickerClosingOperation.Deadline.get
	}
}
