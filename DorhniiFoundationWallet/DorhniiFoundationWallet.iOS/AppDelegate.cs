﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using UIKit;
using Xamarin.Forms;

namespace DorhniiFoundationWallet.iOS
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
            ZXing.Net.Mobile.Forms.iOS.Platform.Init();
            global::Xamarin.Forms.Forms.Init();            
            //AppCenter.Start("2feaa84d-4a81-404c-9c90-2b61c0a5eba9" + typeof(Analytics), typeof(Crashes));
            LoadApplication(new DorhniiFoundationWallet.App());
            return base.FinishedLaunching(app, options);
        }
    }
}
