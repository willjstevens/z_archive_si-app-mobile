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
	public partial class Logout : ContentPage
	{
		private SiAppManager siAppManager = SiAppManager.manager;

		public Logout()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

			init();
		}

		private async void init()
		{
			var username = siAppManager.session.user.username;
			Logger.info("About to logout: " + username);

			var accountService = siAppManager.accountService;
			Task<Response> taskResponse = accountService.logout();

			Response response = await taskResponse;

			if (response.success) {
				siAppManager.session.cleanup();
				Logger.info("Logged out user: " + username);
				Util.SetDetailPage(new WelcomePage());
			}
		}
	}
}