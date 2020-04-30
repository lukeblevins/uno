﻿using System;

namespace Uno.Devices.Midi.Internal
{
	internal static class MidiMessageValidators
    {
        internal static void VerifyRange(byte value, byte max, string paramName)
		{
			if ( value > max)
			{
				throw new ArgumentException(
					$"{nameof(paramName)} must be a number in the range 0 - {max}",
					paramName);
			}
		}
    }
}
