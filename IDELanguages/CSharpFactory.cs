using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDELib;

namespace IDELanguages
{
    public class CSharpFactory : ComponentFactory
    {
        public CSharpFactory()
        {
            base.LanguageName = "C#";
        }

        public override void Execute(List<IComponent> Components)
        {
            String fullCode = $"<Window x:Class='IDE.MainWindow' xmlns = 'http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns: x = 'http://schemas.microsoft.com/winfx/2006/xaml'xmlns: d = 'http://schemas.microsoft.com/expression/blend/2008' xmlns: mc = 'http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns: local = 'clr-namespace:IDE'mc: Ignorable = 'd' Title = 'FactoryPattern- GUIBuilder9000' Height = '350' Width = '700' ><Grid>{ComponentFactory.BuildAll(Components)}</Grid></Window>";
        }
    }
}
