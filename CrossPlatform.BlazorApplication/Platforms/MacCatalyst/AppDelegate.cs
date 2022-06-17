using Foundation;
using UIKit;

namespace CrossPlatform.BlazorApplication;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	public AppDelegate() {

		this.GetWindow().Window.TintColor = UIColor.White;
	}


}
