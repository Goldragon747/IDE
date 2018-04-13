using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class HTMLButton : IDELib.IComponent
    {
        public override string Build()
        {
            return $"<button style='position:absolute;top:{Top}px;left:{Left}px;width:{Width}px;height:{Height}px;'>{Content}</button>";
        }
    }
}
