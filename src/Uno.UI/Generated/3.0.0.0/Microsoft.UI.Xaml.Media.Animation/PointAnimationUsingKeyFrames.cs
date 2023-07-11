#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	[global::Microsoft.UI.Xaml.Markup.ContentPropertyAttribute(Name = "KeyFrames")]
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointAnimationUsingKeyFrames : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool EnableDependentAnimation
		{
			get
			{
				return (bool)this.GetValue(EnableDependentAnimationProperty);
			}
			set
			{
				this.SetValue(EnableDependentAnimationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Animation.PointKeyFrameCollection KeyFrames
		{
			get
			{
				throw new global::System.NotImplementedException("The member PointKeyFrameCollection PointAnimationUsingKeyFrames.KeyFrames is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PointKeyFrameCollection%20PointAnimationUsingKeyFrames.KeyFrames");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty EnableDependentAnimationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(EnableDependentAnimation), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PointAnimationUsingKeyFrames() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames", "PointAnimationUsingKeyFrames.PointAnimationUsingKeyFrames()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.PointAnimationUsingKeyFrames()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.KeyFrames.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.EnableDependentAnimation.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.EnableDependentAnimation.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.EnableDependentAnimationProperty.get
	}
}
