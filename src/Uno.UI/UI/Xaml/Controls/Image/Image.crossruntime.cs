﻿using Windows.Foundation;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls;

partial class Image : FrameworkElement
{
	partial void OnSourceChanged(ImageSource newValue, bool forceReload = false);

	private void OnStretchChanged(Stretch newValue, Stretch oldValue) => InvalidateArrange();

	internal override bool IsViewHit() => Source != null || base.IsViewHit();
}
