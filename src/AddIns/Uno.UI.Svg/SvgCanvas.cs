﻿using System;
using System.IO;
using ShimSkiaSharp;
using SkiaSharp;
using SkiaSharp.Views.UWP;
using Svg.Skia;
using Uno.Disposables;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using SKMatrix = SkiaSharp.SKMatrix;
using Windows.ApplicationModel.Activation;
#if __IOS__ || __MACOS__ || __ANDROID__
using SkiaCanvas = SkiaSharp.Views.UWP.SKSwapChainPanel;
using SkiaPaintEventArgs = SkiaSharp.Views.UWP.SKPaintGLSurfaceEventArgs;
#else
using SkiaCanvas = SkiaSharp.Views.UWP.SKXamlCanvas;
using SkiaPaintEventArgs = SkiaSharp.Views.UWP.SKPaintSurfaceEventArgs;
#endif

namespace Uno.UI.Svg;

internal partial class SvgCanvas : SkiaCanvas
{
	private readonly SvgImageSource _svgImageSource;
	private readonly SvgProvider _svgProvider;
	private readonly CompositeDisposable _disposables = new();
	private Size _lastArrangeSize = default;

	public SvgCanvas(SvgImageSource svgImageSource, SvgProvider svgProvider)
	{
		_svgImageSource = svgImageSource;
		_svgProvider = svgProvider;

		SizeChanged += SvgCanvas_SizeChanged;

		_svgProvider.SourceLoaded += SvgProviderSourceOpened;
		_disposables.Add(() => _svgProvider.SourceLoaded -= SvgProviderSourceOpened);
		_disposables.Add(_svgImageSource.RegisterDisposablePropertyChangedCallback(SvgImageSource.UriSourceProperty, SourcePropertyChanged));
		_disposables.Add(_svgImageSource.RegisterDisposablePropertyChangedCallback(SvgImageSource.RasterizePixelHeightProperty, SourcePropertyChanged));
		_disposables.Add(_svgImageSource.RegisterDisposablePropertyChangedCallback(SvgImageSource.RasterizePixelWidthProperty, SourcePropertyChanged));

		Loaded += SvgCanvas_Loaded;
		Unloaded += SvgCanvas_Unloaded;
	}

	private void SvgCanvas_Loaded(object sender, RoutedEventArgs e)
	{
		Invalidate();

#if __MACCATALYST__
		this.Opaque = false;		
#elif __IOS__ || __MACOS__
		// The SKGLTextureView is opaque by default, so we poke at the tree
		// to change the opacity of the first view of the SKSwapChainPanel
		// to make it transparent.
		if (Subviews.Length == 1 &&
			Subviews[0] is GLKit.GLKView texture)
		{
			texture.Opaque = false;
		}
#elif __ANDROID__
		// The SKGLTextureView is opaque by default, so we poke at the tree
		// to change the opacity of the first view of the SKSwapChainPanel
		// to make it transparent.
		if (ChildCount == 1 &&
			GetChildAt(0) is Android.Views.TextureView texture)
		{
			texture.SetOpaque(false);
		}
#endif
	}

	private void SvgCanvas_Unloaded(object sender, RoutedEventArgs e) => _disposables.Dispose();

	private void SourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs dp) => Invalidate();

	private void SvgCanvas_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs args) => Invalidate();

	private void SvgProviderSourceOpened(object sender, EventArgs e)
	{
		InvalidateMeasure();
		InvalidateArrange();
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		finalSize = base.ArrangeOverride(finalSize);
		_lastArrangeSize = finalSize;
		Invalidate();
		return finalSize;	
	}

	protected override void OnPaintSurface(SkiaPaintEventArgs e)
	{
		var scale = (float)GetScaleFactorForLayoutRounding();
		e.Surface.Canvas.SetMatrix(SKMatrix.CreateScale(scale, scale));
		e.Surface.Canvas.Clear(SKColors.Transparent);
		if (_svgProvider.SkSvg?.Picture is { } picture)
		{
			var svgScaleMatrix = CreateScaleMatrix();
			e.Surface.Canvas.DrawPicture(picture, ref svgScaleMatrix);
		}
		//TODO: Pre-rasterization support
	}

	private SKMatrix CreateScaleMatrix()
	{
		if (_lastArrangeSize == default)
		{
			return SKMatrix.Identity;
		}

		SKMatrix scaleMatrix = default;
		if (_svgProvider.SkSvg?.Picture?.CullRect is { } rect)
		{
			scaleMatrix = SKMatrix.CreateScale((float)_lastArrangeSize.Width / rect.Width, (float)_lastArrangeSize.Height / rect.Height);
		}

		return scaleMatrix;
	}
}
