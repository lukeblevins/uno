﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Uno.Disposables;
using System.Drawing;

namespace Microsoft.UI.Xaml.Media
{
	//Android partial for Brush
	public partial class Brush
	{
		internal static IDisposable AssignAndObserveBrush(Brush b, Action<Color> colorSetter, Action imageBrushCallback = null)
		{
			return null;
		}

	}
}
