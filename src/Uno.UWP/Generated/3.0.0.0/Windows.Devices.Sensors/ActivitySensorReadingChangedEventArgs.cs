#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ActivitySensorReadingChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.ActivitySensorReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivitySensorReading ActivitySensorReadingChangedEventArgs.Reading is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivitySensorReading%20ActivitySensorReadingChangedEventArgs.Reading");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs.Reading.get
	}
}
