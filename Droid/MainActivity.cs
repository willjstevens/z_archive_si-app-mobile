using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using UXDivers.Gorilla;
using System.Net;

namespace UXDivers.Artina.Grial
{
	[Activity (
		Label = "Artina Grial",
		Theme = "@style/AppTheme",
		Icon="@android:color/transparent",
		MainLauncher = false)
	]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			FormsAppCompatActivity.ToolbarResource = Resource.Layout.Toolbar;
			FormsAppCompatActivity.TabLayoutResource = Resource.Layout.Tabs;


			LoadApplication (new App ());

			// UNCOMMENT for Gorilla development
			//LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(
			//	ApplicationContext,
			//					//new UXDivers.Gorilla.Config("Good Gorilla").RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()));
			//					new UXDivers.Gorilla.Config("Good Gorilla")
			//		.RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()
			//		.RegisterAssemblyFromType<UXDivers.Artina.Grial.BrandBlock>()
			//	));

			// OLD but keep?
			//LoadApplication (UXDivers.Artina.Player.Droid.Player.CreateApplication(ApplicationContext, new UXDivers.Artina.Player.Config("Good Gorilla")));


		}

		//public static string GetLocalIPAddress()
		//{
		//	var host = Dns.GetHostEntry(Dns.GetHostName());
		//	foreach (var ip in host.AddressList) {

		//		return ip.ToString();

		//		//if (ip.AddressFamily == AddressFamily.InterNetwork) {
		//		//	return ip.ToString();
		//		//}
		//	}
		//	throw new Exception("Local IP Address Not Found!");
		//}
	}
}

