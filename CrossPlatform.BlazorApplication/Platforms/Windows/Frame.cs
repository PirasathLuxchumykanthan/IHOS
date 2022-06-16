using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI;

namespace CrossPlatform.BlazorApplication.Platfrom.windows
{
    public static class Frame
    {
        public static void Settings(Microsoft.Maui.Handlers.IWindowHandler handler) {

            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(Microsoft.UI.Win32Interop.GetWindowIdFromWindow(WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow)));
            appWindow.TitleBar.ButtonBackgroundColor =  appWindow.TitleBar.BackgroundColor =  Windows.UI.Color.FromArgb(0, 0, 0, 0);
            appWindow.TitleBar.ForegroundColor = appWindow.TitleBar.ButtonHoverForegroundColor = appWindow.TitleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(255, 255, 255, 255);
            appWindow.Title = "OBJECT:SOCIAL";
            
            appWindow.Changed += (s, a) => {

                if (s.ClientSize.Height < 700 || s.ClientSize.Width < 900)
                {
                    s.Resize(new SizeInt32(900, 700));
                    return;
                }
            };
            appWindow.TitleBar.IconShowOptions = IconShowOptions.HideIconAndSystemMenu;
        }
   
    }
}
