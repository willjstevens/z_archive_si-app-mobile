using System;
using SI.Util;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar(this, false);
		}

		public async void OnWalkthroughButtonTapped (object sender, EventArgs e) {

			// TODO: Reset with registration link
			await Navigation.PushAsync (new WalkthroughPage ());
		}

		public  void OnLoginButtonTapped (object sender, EventArgs e) {
			Util.SetDetailPage(new LoginPage());
		}

		void OnCloseButtonClicked(object sender, EventArgs args)
		{	
			Util.SetDetailPage(new WelcomePage());
		}
	}
}