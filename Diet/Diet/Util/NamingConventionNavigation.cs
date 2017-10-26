using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Diet.Util
{
    public class NamingConventionNavigation : INavigation
    {
        public Page CurrentPage { get; set; }

        public NamingConventionNavigation(Page currentPage)
        {
            this.CurrentPage = currentPage;
        }

        public async void ShowViewModel(object viewModel)
        {
            string pageName = viewModel.GetType().FullName.Replace("ViewModels", "Views")
                .Replace("ViewModel", "Page");
            Page page = Activator.CreateInstance(Type.GetType(pageName)) as Page;
            page.BindingContext = viewModel;
            await CurrentPage.Navigation.PushAsync(page);
            CurrentPage = page;
        }
    }
}
