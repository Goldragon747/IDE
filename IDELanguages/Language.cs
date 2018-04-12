using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDELib;

namespace IDELanguages
{
    public class Language : IDELib.IDE
    {
        public override List<ComponentFactory> InstaniateLanguages()
        {
            return new List<ComponentFactory> { new CSharpFactory(), new HTMLFactory()};
        }
    }
}
