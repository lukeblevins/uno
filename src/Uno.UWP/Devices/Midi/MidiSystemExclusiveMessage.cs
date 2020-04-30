using System;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
	public  partial class MidiSystemExclusiveMessage : IMidiMessage
	{
		public MidiSystemExclusiveMessage(IBuffer rawData)
		{
			RawData = rawData;
		}

		public IBuffer RawData { get; }

		public TimeSpan Timestamp { get; } = TimeSpan.Zero;

		public MidiMessageType Type => MidiMessageType.SystemExclusive;		
	}
}
