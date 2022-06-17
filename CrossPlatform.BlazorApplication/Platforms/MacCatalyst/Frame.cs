using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform.BlazorApplication.Platforms.maccatalyst
{
    public static class Frame
    {
        public static void Settings(Microsoft.Maui.Handlers.IWindowHandler handler)
        {

            var nativeWindow = handler.PlatformView;
            nativeWindow.WindowScene.n.Title = "OBJECT:SOCIAL";
            nativeWindow.WindowScene.Titlebar.TitleVisibility = UIKit.UITitlebarTitleVisibility.Hidden;
            nativeWindow.SizeThatFits(new CoreGraphics.CGSize(300, 300));
        }
    }
}
