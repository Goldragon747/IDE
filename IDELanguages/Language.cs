using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDELib;

namespace IDELanguages
{
    public class Language : IDELib.IGenericLanguage
    {
        public Language()
        {
            InstaniateLanguages();
        }
        public List<string> LanguagesSupported { get; set; }

        public List<ComponentFactory> InstaniateLanguages()
        {
            List<ComponentFactory> languages = new List<ComponentFactory> { new CSharpFactory(), new HTMLFactory() };
            LanguagesSupported = new List<string>();
            foreach (ComponentFactory language in languages)
            {
                LanguagesSupported.Add(language.LanguageName);
            }
            return languages;
        }
    }
}
