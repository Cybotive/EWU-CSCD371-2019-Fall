﻿using System;

namespace Mailbox
{
    [Flags]
    public enum Size
    {
        Undefined = 0,
        Premium = 1,
        Small = 2,
        Medium = 4,
        Large = 8
    }
}
