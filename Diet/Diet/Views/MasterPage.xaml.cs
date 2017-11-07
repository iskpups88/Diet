using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
       
        public List<MasterPageItem> Items;

        public MasterPage()
        {
            InitializeComponent();
        }
    }
}