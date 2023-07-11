#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorageLibraryContentChangedTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder StorageLibraryContentChangedTriggerDetails.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20StorageLibraryContentChangedTriggerDetails.Folder");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.Search.StorageLibraryContentChangedTriggerDetails.Folder.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Search.StorageItemQueryResult CreateModifiedSinceQuery( global::System.DateTimeOffset lastQueryTime)
		{
			throw new global::System.NotImplementedException("The member StorageItemQueryResult StorageLibraryContentChangedTriggerDetails.CreateModifiedSinceQuery(DateTimeOffset lastQueryTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageItemQueryResult%20StorageLibraryContentChangedTriggerDetails.CreateModifiedSinceQuery%28DateTimeOffset%20lastQueryTime%29");
		}
		#endif
	}
}
