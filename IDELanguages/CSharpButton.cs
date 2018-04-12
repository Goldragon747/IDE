using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class CSharpButton : IDELib.IComponent
    {
        public string Content { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public string Build()
        {
            return $"<Button Height='{Height}' Width='{Width}' Margin='{Left} {Top} 0 0' >{Content}</Button>";
        }
    }
}
