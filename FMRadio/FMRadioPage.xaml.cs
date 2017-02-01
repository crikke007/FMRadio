using System;
using Xamarin.Forms;


namespace FMRadio
{
	public partial class FMRadioPage : ContentPage
	{
		public FMRadioPage()
		{
			InitializeComponent();

		}


		void Settings_Clicked(object sender,EventArgs args) 
		{
			DependencyService.Get<IAudio>().Play_Pause("http://mp3.streampower.be/stubru-high.mp3");
		
		}



			


	}
}

