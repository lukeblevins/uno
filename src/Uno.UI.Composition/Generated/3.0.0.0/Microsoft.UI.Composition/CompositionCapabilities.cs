#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionCapabilities 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AreEffectsFast()
		{
			throw new global::System.NotImplementedException("The member bool CompositionCapabilities.AreEffectsFast() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CompositionCapabilities.AreEffectsFast%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AreEffectsSupported()
		{
			throw new global::System.NotImplementedException("The member bool CompositionCapabilities.AreEffectsSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CompositionCapabilities.AreEffectsSupported%28%29");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionCapabilities.Changed.add
		// Forced skipping of method Microsoft.UI.Composition.CompositionCapabilities.Changed.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CompositionCapabilities() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionCapabilities", "CompositionCapabilities.CompositionCapabilities()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionCapabilities.CompositionCapabilities()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Composition.CompositionCapabilities, object> Changed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionCapabilities", "event TypedEventHandler<CompositionCapabilities, object> CompositionCapabilities.Changed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionCapabilities", "event TypedEventHandler<CompositionCapabilities, object> CompositionCapabilities.Changed");
			}
		}
		#endif
	}
}
