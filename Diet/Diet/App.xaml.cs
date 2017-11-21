using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diet.Repositories;
using Diet.Util;
using Diet.ViewModels;
using Xamarin.Forms;
using INavigation = Xamarin.Forms.INavigation;
using Diet.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace Diet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Diet.MainPage();
            // MainPage = new NavigationPage(page);

            MvxSimpleIoCContainer.Initialize();
            Mvx.RegisterSingleton<IUserRepository>(new UserRepository("localDb"));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}
