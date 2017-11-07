

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Util;
using Diet.ViewModels;
using Xamarin.Forms;

namespace Diet.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            this.BindingContext = new MenuViewModel(new NamingConventionNavigation(this));
        }
    }
}
