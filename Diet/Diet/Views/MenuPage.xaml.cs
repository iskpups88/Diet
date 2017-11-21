

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Repositories;
using Diet.Util;
using Diet.ViewModels;
using MvvmCross.Platform;
using Xamarin.Forms;
using INavigation = Diet.Util.INavigation;

namespace Diet.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {


           // this.Title = "Sign In";

            this.BackgroundColor = Color.FromHex("#E0E0E0");
        
            InitializeComponent();
            this.BindingContext = new MenuViewModel(Mvx.Resolve<INavigation>(), Mvx.Resolve<IUserRepository>()); ;


        }
    }
}
