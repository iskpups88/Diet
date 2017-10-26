using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diet.Util;
using Diet.ViewModels;
using Xamarin.Forms;
using INavigation = Xamarin.Forms.INavigation;

namespace Diet
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();
            
            var page = new Diet.MainPage();
            MainPage = new NavigationPage(page);

            
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
