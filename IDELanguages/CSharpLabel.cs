﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class CSharpLabel : IDELib.IComponent
    {
        public string Content { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public string Build()
        {
            throw new NotImplementedException();
        }
    }
}
