#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynAuthenticationCompleteEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism AuthenticationMechanism
		{
			get
			{
				throw new global::System.NotImplementedException("The member AllJoynAuthenticationMechanism AllJoynAuthenticationCompleteEventArgs.AuthenticationMechanism is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AllJoynAuthenticationMechanism%20AllJoynAuthenticationCompleteEventArgs.AuthenticationMechanism");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PeerUniqueName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynAuthenticationCompleteEventArgs.PeerUniqueName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AllJoynAuthenticationCompleteEventArgs.PeerUniqueName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Succeeded
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AllJoynAuthenticationCompleteEventArgs.Succeeded is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AllJoynAuthenticationCompleteEventArgs.Succeeded");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs.AuthenticationMechanism.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs.PeerUniqueName.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs.Succeeded.get
	}
}
