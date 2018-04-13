using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    abstract public class IComponent
    {
        public String Content { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }
        abstract public string Build();
    }
}
