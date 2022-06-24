using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RazorClassLibray
{
    public class Definition
    {
        public string TwoLetterISO639 => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        public string Host =>
        #if DEBUG
        "https://localhost:7268";
        #else
        "https://object.social";
        #endif
        public TimeSpan TimeZone => System.TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
    }
}
