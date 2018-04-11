using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELib
{
    abstract public class IDE
    {
        /// <summary>
        /// Contains all supported libraries for the user to output.
        /// </summary>
        public List<ComponentFactory> LanguagesSupported { get; set; }

        /// <summary>
        /// Instansiates all supported languages.
        /// </summary>
        /// <returns>The list of instaniated languages.</returns>
        abstract public List<ComponentFactory> InstaniateLanguages();
       
    }
}
