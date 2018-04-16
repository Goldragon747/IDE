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
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(
                Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + filename)));
            using (StreamWriter outputFile = new StreamWriter(directory.ToString()))
            {
                outputFile.WriteLine(content);
            }
        }
    }
}
