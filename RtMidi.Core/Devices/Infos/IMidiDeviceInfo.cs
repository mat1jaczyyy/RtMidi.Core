﻿namespace RtMidi.Core.Devices.Infos
{
    /// <summary>
    /// Midi device info
    /// </summary>
    public interface IMidiDeviceInfo
    {
        /// <summary>
        /// Name of midi device
        /// </summary>
        string Name { get; }
        uint Port { get; }
    }
}
