using Foundation;

namespace CrossPlatform.BlazorApplication;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() {
		this.Window.WindowScene.Title = "OBJECT:SOCIAL";
		return MauiProgram.CreateMauiApp();
    }
}
