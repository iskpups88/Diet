using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Diet.Droid.Utils;
using Diet.Models;
using Diet.Util;
using Ninject;
using Ninject.Components;

namespace Diet.Droid
{
    [Activity(Label = "Diet", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
//            IKernel kernel = new StandardKernel();
//            kernel.Bind<IUserRepository>().To<UserRepository>(); 
//            kernel.Bind<IFileHelper>().To<FileHelper>();
//            kernel.Bind<INavigation>().To<NamingConventionNavigation>();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

