using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Diet.Models;
using Xamarin.Forms;

namespace Diet.ViewModels
{
    //testIlvir
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand GetRegistration { get; protected set; }
        public ICommand LoginCommand { get; protected set; }
        public Util.INavigation Navigation { get; protected set; }
        public UserRepository UserRepo = new UserRepository("localDb");

        public string login;
        public string password;
        public bool isEnabled;
        public bool isErrorVisible;

        public bool IsEnabled
        {
            get => isEnabled;
            set {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                } 
            }
        }

        public bool IsErrorVisible
        {
            get => isErrorVisible;
            set
            {
                if (isErrorVisible != value)
                {
                    isErrorVisible = value;
                    OnPropertyChanged("IsErrorVisible");
                }
                //RaisePropertyChanged();
                //RaisePropertyChanged(() => IsLoginEnabled);
                //LoginCommand.RaiseCanExecuteChanged();
            }
        }

        public string Login
        {
            get => login;
            set
            {
                if (login != value)
                {
                    login = value;
                    OnPropertyChanged("Login");
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public MenuViewModel(Util.INavigation nav)
        {
            Navigation = nav;
            GetRegistration = new Command(Registration);
            LoginCommand = new Command(Auth);
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            CheckEnabled();
        }

        public void Registration()
        {
            Navigation.ShowViewModel(new RegistrationViewModel());
        }

        public void Auth()
        {
            if (isEnabled == true & UserRepo.CheckUser(login, password))
            {
                //Application.Current.MainPage.DisplayAlert("Succes", "You logged", "ok");
                Navigation.ShowViewModel(new MainViewModel());
                IsErrorVisible = false;
            }
            else
                IsErrorVisible = true;
                //Application.Current.MainPage.DisplayAlert("Fail", "Check login or password", "ok");
        }
            
        public bool AuthTest(string a,string b)
        {
            if (a == "User" && b == "pass")
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void CheckEnabled()
        {
            IsEnabled = !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password);
        }
    }
}
