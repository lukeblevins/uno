﻿#if __WASM__
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Uno.Devices.Enumeration.Internal;
using Uno.Devices.Enumeration.Internal.Providers.Midi;
using Uno.Extensions;
using Uno.Foundation.Logging;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Storage.Streams;

#if NET7_0_OR_GREATER
using NativeMethods = __Windows.Devices.Midi.MidiOutPort.NativeMethods;
#else
using static Uno.Foundation.WebAssemblyRuntime;
#endif

namespace Windows.Devices.Midi
{
	public partial class MidiOutPort
	{
#if !NET7_0_OR_GREATER
		private const string JsType = "Windows.Devices.Midi.MidiOutPort";
#endif
		private readonly string _wasmId;

		private MidiOutPort(string deviceId, string wasmId)
		{
			DeviceId = deviceId;
			_wasmId = wasmId;
		}

		public void Dispose()
		{
		}

		public void SendBufferInternal(IBuffer midiBuffer, TimeSpan timestamp)
		{
			var data = midiBuffer.ToArray();

#if NET7_0_OR_GREATER
			NativeMethods.SendBuffer(Uri.EscapeDataString(_wasmId), timestamp.TotalMilliseconds, data);
#else
			var byteString = string.Join(",", data);
			var command = $"{JsType}.sendBuffer(\"{Uri.EscapeDataString(_wasmId)}\",{timestamp.TotalMilliseconds},[{byteString}])";
			InvokeJS(command);
#endif
		}

		private static Task<IMidiOutPort> FromIdInternalAsync(DeviceIdentifier identifier)
		{
			return Task.FromResult<IMidiOutPort>(new MidiOutPort(identifier.ToString(), identifier.Id));
		}
	}
}
#endif
