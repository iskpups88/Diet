using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {

            InitializeComponent();
           // this.BindingContext = new RegistrationViewModel();
          
        }
        public async void OnBackClicked(object sender, EventArgs args) => Navigation.RemovePage(this);
    }
}