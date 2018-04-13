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
        public string LanguageName { get; set; }
        public List<IComponent> Components { get; set; }
        public List<IComponent> AvailableComponents { get; set; }
        abstract public void InstantiateAvailableComponents();
        public static string BuildAll(List<IComponent> list) {
            string BuiltComponents = "";
            foreach (IComponent component in list)
            {
                BuiltComponents += component.Build();
            }
            return BuiltComponents;
        }

        abstract public void Execute();

        public static void Write(string content, string filename)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\" + filename))
            {
                outputFile.WriteLine(content);
            }
        }
    }
}
