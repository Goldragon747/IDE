using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    abstract public class ComponentFactory
    {
        public ComponentFactory(){
            LanguageName = "Default Language Name";
            Components = new List<IComponent>();
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

        abstract public void Execute();

        public static void Write(String content, String filename)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\" + filename))
            {
                outputFile.WriteLine(content);
            }
        }
    }
}
