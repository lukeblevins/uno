#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICommandBarElement 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int DynamicOverflowOrder
		{
			get;
			set;
		}
		#endif
		// Skipping already declared property IsCompact
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool IsInOverflow
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarElement.IsCompact.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarElement.IsCompact.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarElement.IsInOverflow.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarElement.DynamicOverflowOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ICommandBarElement.DynamicOverflowOrder.set
	}
}
