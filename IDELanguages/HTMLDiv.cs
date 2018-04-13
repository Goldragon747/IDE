using System;
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
            return $"<div style='position:absolute;top:{Top}px;left:{Left}px;width:{Width}px;height:{Height}px;'>{Content}</div>";
        }
    }
}
