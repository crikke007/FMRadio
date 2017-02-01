using Xamarin.Forms;

namespace FMRadio
{
	

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			DependencyService.Register<IAudio>();

			//MainPage = new FMRadioPage();
			MainPage = new MainPage();

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
