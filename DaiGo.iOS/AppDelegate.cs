using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using KeyboardOverlap.Forms.Plugin.iOSUnified;
using UIKit;
namespace DaiGo.iOS
{


    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {


        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
#if DEBUG
            Xamarin.Calabash.Start();
#endif
#if ENABLE_TEST_CLOUD
            // requires Xamarin Test Cloud Agent
            Xamarin.Calabash.Start();
#endif
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            global::Xamarin.Forms.Forms.Init();
            ImageCircleRenderer.Init();
            LoadApplication(new App());

            KeyboardOverlapRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
