using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diet.Models;
using Diet.Repositories;
using Diet.Util;
using Diet.ViewModels;
using Xamarin.Forms;
using INavigation = Xamarin.Forms.INavigation;
using Diet.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace Diet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MvxSimpleIoCContainer.Initialize();

            Mvx.RegisterType<MenuViewModel, MenuViewModel>();
            Mvx.RegisterType<RegistrationViewModel, RegistrationViewModel>();
            

            Mvx.RegisterSingleton<IUserRepository>(new UserRepository());

            var nav = new NamingConventionNavigation((Page) null);
            Mvx.RegisterSingleton<Util.INavigation>(nav);

            var page = new MenuPage();
            MainPage = new NavigationPage(page);

            nav.CurrentPage = MainPage;
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