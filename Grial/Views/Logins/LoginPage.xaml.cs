using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using SI;
using SI.Model;
using SI.DTO;
using SI.Framework;
using SI.Util;
using System.Threading.Tasks;

namespace UXDivers.Artina.Grial
{
	public partial class LoginPage : ContentPage
	{
		private SiAppManager siAppManager = SiAppManager.manager;

		public LoginPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
		}

		public async void OnSignupStackTapped (object sender, EventArgs e) {
			if (LoginPage.IsPageInNavigationStack<SignUpPage> (Navigation)) {
				await Navigation.PopAsync ();
				return;
			}

			var signUpPage = new SignUpPage();
			await Navigation.PushAsync( signUpPage );
		}

<<<<<<< HEAD
		void OnCloseButtonClicked(object sender, EventArgs args)
		{
			Util.SetDetailPage(new WelcomePage());
		}
=======
		//void OnCloseButtonClicked(object sender, EventArgs args)
		//{
		//	Util.SetDetailPage(new WelcomePage());
		//}
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b

		public static bool IsPageInNavigationStack<TPage>(INavigation navigation) where TPage : Page {
			if (navigation.NavigationStack.Count > 1) {
				var last = navigation.NavigationStack [navigation.NavigationStack.Count - 2];

				if (last is TPage) {
					return true;
				}
			}
			return false;
		}

		public async void OnLoginClicked(object sender, EventArgs args)
		{
			var accountService = siAppManager.accountService;
			Task<Response> taskResponse = accountService.loginByUsernamePassword(username.Text, password.Text);

			// add spinner here

			Response response = await taskResponse;
			if (response.success) {
				accountService.resetSessionInfo(response);
				Util.SetDetailPage(new ArticlesListVariantPage());
			} else {
				await DisplayAlert(response.message, "Try again", "OK");
			}
		}
	}
}