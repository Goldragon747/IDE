﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    public interface IComponent
    {
        String Content { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        double Top { get; set; }
        double Left { get; set; }
        string Build();
    }
}
