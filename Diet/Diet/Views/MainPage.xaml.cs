using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Util;
using Diet.ViewModels;
using Xamarin.Forms;

namespace Diet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

      
            this.Title = "Sign In";
         
            this.BackgroundColor = Color.FromHex("#E0E0E0");
        
            InitializeComponent();
            this.BindingContext = new MainViewModel(new NamingConventionNavigation(this));

            
        }
    }
}
