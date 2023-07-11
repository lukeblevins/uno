#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Spatial
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialNavigationUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialInteractionSourceKind InteractionSourceKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialInteractionSourceKind SpatialNavigationUpdatedEventArgs.InteractionSourceKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialInteractionSourceKind%20SpatialNavigationUpdatedEventArgs.InteractionSourceKind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 NormalizedOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 SpatialNavigationUpdatedEventArgs.NormalizedOffset is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Vector3%20SpatialNavigationUpdatedEventArgs.NormalizedOffset");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs.InteractionSourceKind.get
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs.NormalizedOffset.get
	}
}
