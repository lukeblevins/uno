#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynCredentials 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Timeout
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan AllJoynCredentials.Timeout is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20AllJoynCredentials.Timeout");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynCredentials", "TimeSpan AllJoynCredentials.Timeout");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Credentials.PasswordCredential PasswordCredential
		{
			get
			{
				throw new global::System.NotImplementedException("The member PasswordCredential AllJoynCredentials.PasswordCredential is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PasswordCredential%20AllJoynCredentials.PasswordCredential");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynCredentials", "PasswordCredential AllJoynCredentials.PasswordCredential");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.Certificate Certificate
		{
			get
			{
				throw new global::System.NotImplementedException("The member Certificate AllJoynCredentials.Certificate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Certificate%20AllJoynCredentials.Certificate");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynCredentials", "Certificate AllJoynCredentials.Certificate");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism AuthenticationMechanism
		{
			get
			{
				throw new global::System.NotImplementedException("The member AllJoynAuthenticationMechanism AllJoynCredentials.AuthenticationMechanism is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AllJoynAuthenticationMechanism%20AllJoynCredentials.AuthenticationMechanism");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.AuthenticationMechanism.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.Certificate.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.Certificate.set
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential.set
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.Timeout.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynCredentials.Timeout.set
	}
}
