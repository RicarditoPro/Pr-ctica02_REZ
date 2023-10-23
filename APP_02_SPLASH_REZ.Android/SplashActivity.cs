using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Ricardo Espejel Zarate

namespace APP_02_SPLASH_REZ.Droid
{
    [Activity(Label = "APP_EZ", Theme = "@style/SplashTheme",
        MainLauncher = true,
        NoHistory = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation
        )]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}