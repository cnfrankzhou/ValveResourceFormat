﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValveResourceFormat.KeyValues
{
    /// <summary>
    /// Class to hold type + value
    /// </summary>
    public class KVValue
    {
        public KVType Type { get; private set; }
        public object Value { get; private set; }

        public KVValue(KVType type, object value)
        {
            Type = type;
            Value = value;
        }
    }
}
