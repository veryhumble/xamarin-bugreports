﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Caliburn.Micro;

namespace Bugreports.Droid
{
    [Activity(Label = "Bugreports.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(IoC.Get<App>());
        }
    }
}
