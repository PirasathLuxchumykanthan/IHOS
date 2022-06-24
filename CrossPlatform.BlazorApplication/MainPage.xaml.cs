namespace CrossPlatform.BlazorApplication;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		SecureStorage.SetAsync("TEST", "HALLO WORLD");
		SecureStorage.GetAsync("TEST").ContinueWith(a => {

			var v = a.Result;
			var g = v;

        });

    }
}
