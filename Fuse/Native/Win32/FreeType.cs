﻿using System;

namespace Fuse.Native.Win32
{
    [Flags]
    public enum FreeType
    {
        Decommit = 0x4000,
        Release = 0x8000
    }
}
