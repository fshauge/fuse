﻿using System;

namespace Fuse.Unsafe.Win32
{
    [Flags]
    public enum AllocationType
    {
        Commit = 0x00001000,
        Reserve = 0x00002000,
        Reset = 0x00080000
    }
}
