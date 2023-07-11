#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BitmapProperties : global::Windows.Graphics.Imaging.IBitmapPropertiesView
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction SetPropertiesAsync( global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::Windows.Graphics.Imaging.BitmapTypedValue>> propertiesToSet)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BitmapProperties.SetPropertiesAsync(IEnumerable<KeyValuePair<string, BitmapTypedValue>> propertiesToSet) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20BitmapProperties.SetPropertiesAsync%28IEnumerable%3CKeyValuePair%3Cstring%2C%20BitmapTypedValue%3E%3E%20propertiesToSet%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Graphics.Imaging.BitmapPropertySet> GetPropertiesAsync( global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BitmapPropertySet> BitmapProperties.GetPropertiesAsync(IEnumerable<string> propertiesToRetrieve) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CBitmapPropertySet%3E%20BitmapProperties.GetPropertiesAsync%28IEnumerable%3Cstring%3E%20propertiesToRetrieve%29");
		}
		#endif
		// Processing: Windows.Graphics.Imaging.IBitmapPropertiesView
	}
}
