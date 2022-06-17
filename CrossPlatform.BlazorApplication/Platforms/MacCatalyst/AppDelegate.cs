using Foundation;
using UIKit;

namespace CrossPlatform.BlazorApplication;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	public AppDelegate() { 

		this.InputView.TintColor = UIColor.White;
	}


}
