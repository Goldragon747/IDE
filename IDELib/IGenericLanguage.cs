using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    public interface IGenericLanguage
    {
        /// <summary>
        /// Contains all supported libraries for the user to output.
        /// </summary>
        List<String> LanguagesSupported { get; set; }

        /// <summary>
        /// Instansiates all supported languages.
        /// </summary>
        /// <returns>The list of instaniated languages.</returns>
        List<ComponentFactory> InstaniateLanguages();
       
    }
}
