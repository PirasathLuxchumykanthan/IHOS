using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray
{
    public class DefinitionOverwrite: Definition
    {


        public string TwoLetterISO639 => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
    }
}
