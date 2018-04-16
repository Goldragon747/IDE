using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDELib;

namespace IDELanguages
{
    public class HTMLFactory : IDELib.ComponentFactory
    {
        public HTMLFactory()
        {
            base.LanguageName = "HTML";
        }

        public override void Execute()
        {
            string fullCode = $"<!DOCTYPE html><html><head><title>My generated HTML</title></head><body></body>{ComponentFactory.BuildAll(Components)}</html>";
            ComponentFactory.Write(fullCode, "Compiled.html");
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(
            Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + "Compiled.html")));
            System.Diagnostics.Process.Start(directory.ToString());
        }

        public override void InstantiateAvailableComponents()
        {
            base.AvailableComponents = new List<IComponent> { new HTMLButton(), new HTMLDiv(), new HTMLParagraph(), new HTMLTextInput() };
        }
    }
}
