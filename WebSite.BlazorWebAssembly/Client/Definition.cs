using System.Globalization;

namespace WebSite.BlazorWebAssembly.Client
{
    public class Definition:Shared.RazorClassLibray.Definition
    {
        public string ISO639 => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
    }
}
