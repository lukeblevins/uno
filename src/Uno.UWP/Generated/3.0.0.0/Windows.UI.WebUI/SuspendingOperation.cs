#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SuspendingOperation : global::Windows.ApplicationModel.ISuspendingOperation
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Deadline
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset SuspendingOperation.Deadline is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20SuspendingOperation.Deadline");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.SuspendingDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member SuspendingDeferral SuspendingOperation.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SuspendingDeferral%20SuspendingOperation.GetDeferral%28%29");
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.SuspendingOperation.Deadline.get
		// Processing: Windows.ApplicationModel.ISuspendingOperation
	}
}
