using System;
using Xamarin.Forms;
using SI.Framework;
using SI.Util;
using SI.Model;
using SI.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UXDivers.Artina.Grial
{
	public partial class ArticlesListVariantPage : ContentPage
	{
		private SiAppManager siAppManager = SiAppManager.manager;

		public ArticlesListVariantPage ()
		{
			InitializeComponent ();

			BindingContext = new PostsViewModel ();

			fetchActivityFeed();
		}

		private async void OnItemTapped(Object sender, EventArgs e){
			var selectedItem = ((ListView)sender).SelectedItem;
			var post = (Post) selectedItem;
			var articleView = new ArticleViewPage(new ArticleViewModel(post));

			await Navigation.PushAsync( articleView );
		}

		private async void fetchActivityFeed()
		{
			var intuitionService = siAppManager.intuitionService;
			Task<Response> taskResponse = intuitionService.fetchActivityFeed(0, 10);

			// add spinner here

			Response response = await taskResponse;
			if (response.success) {

				List<IntuitionDto> intuitions = JsonConvert.DeserializeObject<List<IntuitionDto>>(response.data.ToString());

				Logger.info("intuition count = " + intuitions.Count);
				Logger.info("response = " + response.data);
				//Util.SetDetailPage(new ArticlesListVariantPage());
			} else {
				await DisplayAlert(response.message, "Try again", "OK");
			}
		}
	}
}

