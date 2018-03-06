using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using SI.Framework;
using SI.Service;
using SI.Model;
using SI.Util;

namespace UXDivers.Artina.Grial
{
	public partial class RootPage : MasterDetailPage
	{
		private SiAppManager siAppManager = SiAppManager.manager;
		private bool _showWelcome;

		public RootPage () : this(false){
		}

		public RootPage (bool sayWelcome)
		{
			InitializeComponent ();

			_showWelcome = sayWelcome;

			// Empty pages are initially set to get optimal launch experience
			Master = new ContentPage { Title = "Loading..." };
			Detail = new NavigationPage(new ContentPage());
		}
			
		public async void OnSettingsTapped( Object sender, EventArgs e ){
			await Navigation.PushAsync( new SettingsPage() );
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();

			SampleCoordinator.SampleSelected += SampleCoordinator_SampleSelected;

			if (_showWelcome) {

				// added by Will
				_showWelcome = false;
				//await Navigation.PushModalAsync (new NavigationPage (new WelcomePage ()));

				await Task.Delay (500)
					.ContinueWith(t => NavigationService.BeginInvokeOnMainThreadAsync(InitializeMasterDetail));
			}
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			SampleCoordinator.SampleSelected -= SampleCoordinator_SampleSelected;
		}

		private async void InitializeMasterDetail(){
			this.Master = new MainMenuPage (new NavigationService(Navigation, LaunchSampleInDetail));
			// TODO: Commented out by Will on 9/10
			//Detail = new NavigationPage ( new DashboardPage ());

			var acccountService = siAppManager.accountService;
			var session = siAppManager.session;


			// TODO: Remove me:
			//session.cleanup();

			if (session.hasDeviceSession()) {
				Task<Response> resp = loginByDeviceSession();
				await resp;
				Detail = new NavigationPage(new ArticlesListVariantPage());
			} else {
				Detail = new NavigationPage(new WelcomePage());
			}
		}

		private async Task<Response> loginByDeviceSession()
		{
			var accountService = siAppManager.accountService;
			// first login by device session then load news (article) feed)
			Task<Response> taskResponse = accountService.loginByDeviceSession();

			// TODO: add spinner here

			Response response = await taskResponse;
			if (response.success) {
				siAppManager.accountService.resetSessionInfo(response);
			}
			Logger.info("Logged in user by device session: " + siAppManager.session.user.username);
			return response;
		}


		private void LaunchSampleInDetail(Page page, bool animated){
			// CustomNavBarPage must be handled differently because XF seems not to be considering the
			// "NavigationPage.SetHasNavigationBar(this, false);" when you add the page as the 
			// root of the NavigationPage, when you are working in Android.
			if (page is CustomNavBarPage) {
				var navigationPage = new NavigationPage (new ContentPage());

				Detail = navigationPage;

				navigationPage.PushAsync (page, false);
			} else {
				Detail = new NavigationPage (page);
			}

			IsPresented = false;
		}

		private void SampleCoordinator_SampleSelected (object sender, SampleEventArgs e)
		{
			if (e.Sample.PageType == typeof(RootPage)){
				IsPresented = true;
			}
		}
	}
}