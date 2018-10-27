using System;
using System.Threading.Tasks;
using Xam.Forms.CheckForUpdates;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Samples
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
            UpdateManager updateManager = new UpdateManager("Update available",
                "A new version is available. Please update!", "Update", "Cancel",
                async () =>
                {
                    await Task.Delay(3000);
                    return new UpdatesCheckResponse
                    {
                        IsNewVersionAvailable = true,
                        DownloadUrl = "http://github.com"
                    };
                }
            );
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}