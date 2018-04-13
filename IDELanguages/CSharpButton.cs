using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELanguages
{
    public class CSharpButton : IDELib.IComponent
    {
        public override string Build()
        {
            return $"<Button Height='{Height}' Width='{Width}' Margin='{Left} {Top} 0 0' >{Content}</Button>";
        }
    }
}
