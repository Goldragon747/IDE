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
            HTMLButton button1 = new HTMLButton
            {
                Width = 100,
                Height = 200,
                Top = 10,
                Left = 5,
                Content = "Content"
            };
            factory.Components.Add(button1);
            factory.Execute();
        }
    }
}
