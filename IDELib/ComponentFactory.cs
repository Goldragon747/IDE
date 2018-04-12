using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    abstract public class ComponentFactory
    {
        public ComponentFactory(){
            LanguageName = "Default Language Name";
        }
        public String LanguageName { get; set; }
        public List<IComponent> Components { get; set; }
        public List<IComponent> AvailableComponents { get; set; }
        public static String BuildAll(List<IComponent> list) {
            String BuiltComponents = "";
            foreach (IComponent component in list)
            {
                BuiltComponents += component.Build();
            }
            return BuiltComponents;
        }

        abstract public void Execute(List<IComponent> Components);
    }
}
