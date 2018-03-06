using Foundation;
using UIKit;
using Xamarin.Forms;
using System.Diagnostics;
using System.Net.Http;

namespace UXDivers.Artina.Grial
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();


			Appearance.Configure ();

			LoadApplication (new App ());


			// UNCOMMENT for Gorilla development
			//LoadApplication(UXDivers.Gorilla.iOS.Player.CreateApplication(
			//	new UXDivers.Gorilla.Config("Good Gorilla")
			//		.RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()
			//		.RegisterAssemblyFromType<UXDivers.Artina.Grial.BrandBlock>()
			//	));

			//System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };


			return base.FinishedLaunching (app, options);
		}
	}
}