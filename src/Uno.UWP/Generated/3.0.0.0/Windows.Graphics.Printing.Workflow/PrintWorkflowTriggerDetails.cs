#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintWorkflowTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Printing.Workflow.PrintWorkflowBackgroundSession PrintWorkflowSession
		{
			get
			{
				throw new global::System.NotImplementedException("The member PrintWorkflowBackgroundSession PrintWorkflowTriggerDetails.PrintWorkflowSession is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PrintWorkflowBackgroundSession%20PrintWorkflowTriggerDetails.PrintWorkflowSession");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowTriggerDetails.PrintWorkflowSession.get
	}
}
