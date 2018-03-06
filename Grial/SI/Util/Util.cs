using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using UXDivers.Artina.Grial;

namespace SI.Util
{
	public class Util
	{
		private Util()
		{
		}

		public static async void PopModalToRoot(INavigation navigation)
		{
			var stackCount = 0;
			while ((stackCount = navigation.ModalStack.Count) >= 1) {
				await navigation.PopModalAsync();
			}
		}

		public static void SetDetailPage(ContentPage page)
		{
			RootPage rootPage = (RootPage) Application.Current.MainPage;
			rootPage.Detail = new NavigationPage(page);
		}
	}
}
