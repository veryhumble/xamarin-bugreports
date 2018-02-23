using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Foundation;
using UIKit;

namespace Bugreports.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        private readonly CaliburnAppDelegate _appDelegate = new CaliburnAppDelegate();
        private App _application;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            _application = new App(IoC.Get<SimpleContainer>());
            LoadApplication(_application);

            return base.FinishedLaunching(app, options);
        }
    }
}
