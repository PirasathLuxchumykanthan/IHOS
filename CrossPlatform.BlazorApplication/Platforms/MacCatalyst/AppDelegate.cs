using Foundation;
using UIKit;

namespace CrossPlatform.BlazorApplication;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	public AppDelegate() {

	}
	public override void OnActivated(UIApplication application)
	{
		application.InputAccessoryView.TintColor = UIColor.White;
		base.OnActivated(application);
	}

}
