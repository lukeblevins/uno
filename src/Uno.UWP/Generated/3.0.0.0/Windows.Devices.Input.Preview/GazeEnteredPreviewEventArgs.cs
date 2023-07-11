#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input.Preview
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GazeEnteredPreviewEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool GazeEnteredPreviewEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20GazeEnteredPreviewEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs", "bool GazeEnteredPreviewEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Input.Preview.GazePointPreview CurrentPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member GazePointPreview GazeEnteredPreviewEventArgs.CurrentPoint is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GazePointPreview%20GazeEnteredPreviewEventArgs.CurrentPoint");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.Handled.get
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.Handled.set
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.CurrentPoint.get
	}
}
