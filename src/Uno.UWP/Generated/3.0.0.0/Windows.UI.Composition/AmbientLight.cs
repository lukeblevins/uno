#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AmbientLight : global::Windows.UI.Composition.CompositionLight
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color AmbientLight.Color is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Color%20AmbientLight.Color");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.AmbientLight", "Color AmbientLight.Color");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Intensity
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AmbientLight.Intensity is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=float%20AmbientLight.Intensity");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.AmbientLight", "float AmbientLight.Intensity");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.AmbientLight.Color.get
		// Forced skipping of method Windows.UI.Composition.AmbientLight.Color.set
		// Forced skipping of method Windows.UI.Composition.AmbientLight.Intensity.get
		// Forced skipping of method Windows.UI.Composition.AmbientLight.Intensity.set
	}
}
