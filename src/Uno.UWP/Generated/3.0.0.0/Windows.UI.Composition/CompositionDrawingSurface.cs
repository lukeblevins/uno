#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionDrawingSurface : global::Windows.UI.Composition.CompositionObject,global::Windows.UI.Composition.ICompositionSurface
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.DirectX.DirectXAlphaMode AlphaMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member DirectXAlphaMode CompositionDrawingSurface.AlphaMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DirectXAlphaMode%20CompositionDrawingSurface.AlphaMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.DirectX.DirectXPixelFormat PixelFormat
		{
			get
			{
				throw new global::System.NotImplementedException("The member DirectXPixelFormat CompositionDrawingSurface.PixelFormat is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DirectXPixelFormat%20CompositionDrawingSurface.PixelFormat");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Size Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size CompositionDrawingSurface.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Size%20CompositionDrawingSurface.Size");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.SizeInt32 SizeInt32
		{
			get
			{
				throw new global::System.NotImplementedException("The member SizeInt32 CompositionDrawingSurface.SizeInt32 is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SizeInt32%20CompositionDrawingSurface.SizeInt32");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionDrawingSurface.AlphaMode.get
		// Forced skipping of method Windows.UI.Composition.CompositionDrawingSurface.PixelFormat.get
		// Forced skipping of method Windows.UI.Composition.CompositionDrawingSurface.Size.get
		// Forced skipping of method Windows.UI.Composition.CompositionDrawingSurface.SizeInt32.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Resize( global::Windows.Graphics.SizeInt32 sizePixels)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionDrawingSurface", "void CompositionDrawingSurface.Resize(SizeInt32 sizePixels)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Scroll( global::Windows.Graphics.PointInt32 offset)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionDrawingSurface", "void CompositionDrawingSurface.Scroll(PointInt32 offset)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Scroll( global::Windows.Graphics.PointInt32 offset,  global::Windows.Graphics.RectInt32 scrollRect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionDrawingSurface", "void CompositionDrawingSurface.Scroll(PointInt32 offset, RectInt32 scrollRect)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollWithClip( global::Windows.Graphics.PointInt32 offset,  global::Windows.Graphics.RectInt32 clipRect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionDrawingSurface", "void CompositionDrawingSurface.ScrollWithClip(PointInt32 offset, RectInt32 clipRect)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollWithClip( global::Windows.Graphics.PointInt32 offset,  global::Windows.Graphics.RectInt32 clipRect,  global::Windows.Graphics.RectInt32 scrollRect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionDrawingSurface", "void CompositionDrawingSurface.ScrollWithClip(PointInt32 offset, RectInt32 clipRect, RectInt32 scrollRect)");
		}
		#endif
		// Processing: Windows.UI.Composition.ICompositionSurface
	}
}
