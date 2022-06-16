using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI;

namespace CrossPlatform.BlazorApplication
{
    public static class Frame
    {
        public static void Settings(Microsoft.Maui.Handlers.IWindowHandler handler) {

            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(Microsoft.UI.Win32Interop.GetWindowIdFromWindow(WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow)));
            appWindow.TitleBar.ButtonBackgroundColor = 
                appWindow.TitleBar.BackgroundColor = 
                Windows.UI.Color.FromArgb(0, 0, 0, 0);
            appWindow.TitleBar.ForegroundColor = appWindow.TitleBar.ButtonHoverForegroundColor = appWindow.TitleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(255, 255, 255, 255);
            appWindow.Title = "OBJECT:SOCIAL";

            appWindow.Changed += AppWindow_Changed;
            appWindow.TitleBar.IconShowOptions = IconShowOptions.HideIconAndSystemMenu;
        }
   
        private static void AppWindow_Changed(AppWindow sender, AppWindowChangedEventArgs args)
        {
            if (sender.ClientSize.Height < 700 || sender.ClientSize.Width < 900)
            {
                sender.Resize(new SizeInt32(900, 700));
                return;
            }
        }
    }
}
