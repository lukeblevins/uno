#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaStreamSourceSwitchStreamsRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Core.MediaStreamSourceSwitchStreamsRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaStreamSourceSwitchStreamsRequest MediaStreamSourceSwitchStreamsRequestedEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaStreamSourceSwitchStreamsRequest%20MediaStreamSourceSwitchStreamsRequestedEventArgs.Request");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs.Request.get
	}
}
