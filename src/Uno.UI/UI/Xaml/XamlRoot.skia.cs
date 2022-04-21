﻿using System;
using System.Diagnostics;
using Uno.Foundation.Logging;
using Uno.UI.Dispatching;

namespace Windows.UI.Xaml;

public sealed partial class XamlRoot
{
	private bool _isMeasureWaiting = false;
	private bool _isArrangeWaiting = false;
	private bool _isMeasuringOrArranging = false;
	private bool _renderQueued = false;
	
	internal event Action InvalidateRender = () => { };

	internal void InvalidateMeasure() => ScheduleInvalidateMeasureOrArrange(invalidateMeasure: true);

	internal void InvalidateArrange() => ScheduleInvalidateMeasureOrArrange(invalidateMeasure: false);

	internal void QueueInvalidateRender()
	{
		if (!_isMeasuringOrArranging && !_renderQueued)
		{
			_renderQueued = true;

			CoreDispatcher.Main.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				_renderQueued = false;
				InvalidateRender();
			});
		}
	}

	internal void ScheduleInvalidateMeasureOrArrange(bool invalidateMeasure)
	{
		if (invalidateMeasure)
		{
			if (_isMeasureWaiting)
			{
				// A measure is already queued
				return;
			}

			_isMeasureWaiting = true;

			if (_isArrangeWaiting)
			{
				// Since an arrange is already queued, no need to
				// schedule something on the dispatcher
				return;
			}
		}
		else
		{
			if (_isArrangeWaiting)
			{
				// An arrange is already queued
				return;
			}

			_isArrangeWaiting = true;

			if (_isMeasureWaiting)
			{
				// Since a measure is already queued, no need to
				// schedule something on the dispatcher
				return;
			}
		}

		CoreDispatcher.Main.RunAsync(CoreDispatcherPriority.Normal, () => RunMeasureAndArrange());
	}

	private void RunMeasureAndArrange()
	{
		if (_isMeasuringOrArranging || VisualTree.RootElement is not UIElement rootElement)
		{
			return; // weird case
		}

		var forMeasure = _isMeasureWaiting;
		var forArrange = _isArrangeWaiting;

		_isMeasureWaiting = false;
		_isArrangeWaiting = false;
		try
		{
			_isMeasuringOrArranging = true;

			var sw = Stopwatch.StartNew();
			
			if (forMeasure)
			{
				rootElement.Measure(Size);
			}
			
			if (forArrange)
			{
				rootElement.Arrange(Bounds);
				InvalidateRender();
			}

			sw.Stop();

			if (this.Log().IsEnabled(Uno.Foundation.Logging.LogLevel.Debug))
			{
				this.Log().Debug($"DispatchInvalidateMeasure: {sw.Elapsed}");
			}
		}
		finally
		{
			_isMeasuringOrArranging = false;
		}
	}	
}