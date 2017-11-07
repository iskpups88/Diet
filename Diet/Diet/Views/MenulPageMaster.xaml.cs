using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenulPageMaster : ContentPage
    {
        public ListView ListView;

        public MenulPageMaster()
        {
            InitializeComponent();

            BindingContext = new MenulPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenulPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenulPageMenuItem> MenuItems { get; set; }

            public MenulPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenulPageMenuItem>(new[]
                {
                    new MenulPageMenuItem { Id = 0, Title = "Page 1" },
                    new MenulPageMenuItem { Id = 1, Title = "Page 2" },
                    new MenulPageMenuItem { Id = 2, Title = "Page 3" },
                    new MenulPageMenuItem { Id = 3, Title = "Page 4" },
                    new MenulPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}