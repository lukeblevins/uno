#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AccelerometerReadingChangedEventArgs 
	{
		#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.AccelerometerReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member AccelerometerReading AccelerometerReadingChangedEventArgs.Reading is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AccelerometerReading%20AccelerometerReadingChangedEventArgs.Reading");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs.Reading.get
	}
}
