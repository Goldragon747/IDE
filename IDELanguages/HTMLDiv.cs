﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class HTMLDiv : IDELib.IComponent
    {
        public override string Build()
        {
            return $"<div style='display:absolute;top:{Top};left:{Left};width:{Width}px;height:{Height};'>{Content}</div>";
        }
    }
}
