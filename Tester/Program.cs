using IDELanguages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static void Main(string[] args)
        {
            HTMLFactory factory = new HTMLFactory();
            HTMLButton button1 = new HTMLButton();
            button1.Width = 100;
            button1.Height = 200;
            button1.Top = 10;
            button1.Left = 5;
            button1.Content = "Content";
            factory.Components.Add(button1);
            factory.Components.Add(button1);
            factory.Components.Add(button1);
            factory.Components.Add(button1);
            factory.Execute();
        }
    }
}
