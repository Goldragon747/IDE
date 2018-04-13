﻿using System;
using System.Collections.Generic;
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

        public override void Execute(List<IComponent> Components)
        {
            String fullCode = $"<!DOCTYPE html><html><head><title>My generated HTML</title></head><body></body>{ComponentFactory.BuildAll(Components)}</html>";
        }
    }
}