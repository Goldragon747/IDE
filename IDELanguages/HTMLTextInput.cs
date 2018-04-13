using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class HTMLTextInput : IDELib.IComponent
    {
        public override string Build()
        {
            return $"<input type='textbox' style='display:absolute;top:{Top};left:{Left};width:{Width}px;height:{Height};'>{Content}</input>";
        }
    }
}
