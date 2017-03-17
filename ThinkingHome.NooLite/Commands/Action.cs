﻿namespace ThinkingHome.NooLite.Commands
{
    public enum Action : byte
    {
        SendCommand = 0,
        SendBroadcastCommand = 1,
        ReadResponseBuffer = 2,
        StartBinding = 3,
        StopBinding = 4,
        ClearChannel = 5,
        ClearAllChannels = 6,
        Unbind = 7,
        SendTargetedCommand = 8
    }
}
