#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MessageWebSocketInformation : global::Windows.Networking.Sockets.IWebSocketInformation,global::Windows.Networking.Sockets.IWebSocketInformation2
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics
		{
			get
			{
				throw new global::System.NotImplementedException("The member BandwidthStatistics MessageWebSocketInformation.BandwidthStatistics is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BandwidthStatistics%20MessageWebSocketInformation.BandwidthStatistics");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.HostName LocalAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member HostName MessageWebSocketInformation.LocalAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HostName%20MessageWebSocketInformation.LocalAddress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Protocol
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MessageWebSocketInformation.Protocol is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MessageWebSocketInformation.Protocol");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.Certificate ServerCertificate
		{
			get
			{
				throw new global::System.NotImplementedException("The member Certificate MessageWebSocketInformation.ServerCertificate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Certificate%20MessageWebSocketInformation.ServerCertificate");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketSslErrorSeverity ServerCertificateErrorSeverity
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketSslErrorSeverity MessageWebSocketInformation.ServerCertificateErrorSeverity is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SocketSslErrorSeverity%20MessageWebSocketInformation.ServerCertificateErrorSeverity");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Cryptography.Certificates.ChainValidationResult> ServerCertificateErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ChainValidationResult> MessageWebSocketInformation.ServerCertificateErrors is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CChainValidationResult%3E%20MessageWebSocketInformation.ServerCertificateErrors");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Cryptography.Certificates.Certificate> ServerIntermediateCertificates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Certificate> MessageWebSocketInformation.ServerIntermediateCertificates is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CCertificate%3E%20MessageWebSocketInformation.ServerIntermediateCertificates");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.LocalAddress.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.BandwidthStatistics.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.Protocol.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.ServerCertificate.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.ServerCertificateErrorSeverity.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.ServerCertificateErrors.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketInformation.ServerIntermediateCertificates.get
		// Processing: Windows.Networking.Sockets.IWebSocketInformation
		// Processing: Windows.Networking.Sockets.IWebSocketInformation2
	}
}
