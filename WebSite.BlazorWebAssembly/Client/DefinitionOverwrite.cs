using System.Globalization;

namespace WebSite.BlazorWebAssembly.Client
{
    public class DefinitionOverwrite: Shared.RazorClassLibray.DefinitionOverwrite
    {
        public string ISO639 => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
    }
}
