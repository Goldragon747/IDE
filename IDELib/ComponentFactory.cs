using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    abstract public class ComponentFactory
    {
        public List<IComponent> Components { get; set; }
        public List<IComponent> AvailableComponents { get; set; }
        abstract public String Build(List<IComponent> list);
        abstract public void Execute(String BuiltComponents);
    }
}
