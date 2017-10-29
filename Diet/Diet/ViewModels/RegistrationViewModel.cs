using System.ComponentModel;
using System.Windows.Input;
using Diet.Models;
using Xamarin.Forms;
using System;

namespace Diet.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public User User { get; set; }
        public ICommand DoRegistration { get; set; }
        public UserRepository UserRepo = new UserRepository("localDb");
        public string passwordConfirmation;
        public bool isEnabled;

        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }

        public RegistrationViewModel()
        {
            DoRegistration = new Command(AddUser);
            User = new User();
        }

        public int Id => User.Id;

        public string UserName
        {
            get => User.UserName;
            set
            {
                if (User.UserName != value)
                {
                    User.UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        public string Password
        {
            get => User.Password;
            set
            {
                if (User.Password != value)
                {
                    User.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string PasswordConfirmation
        {
            get => passwordConfirmation;
            set
            {
                if (value != passwordConfirmation)
                {
                    passwordConfirmation = value;
                    OnPropertyChanged("PasswordConfirmation");
                }
            }
        }

        public int Age
        {
            get => User.Age;
            set
            {
                if (User.Age != value)
                {
                    User.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
    
        public bool Sex
        {
            get => User.Sex;
            set
            {
                if (User.Sex != value)
                {
                    User.Sex = value;
                    OnPropertyChanged("Sex");
                }
            }
        }
        public int Weight
        {
            get => User.Weight;
            set
            {
                if (User.Weight != value)
                {
                    User.Weight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }
        //public int Height
        //{
        //    get => User.Height;
        //    set
        //    {
        //        if (User.Height != value)
        //        {
        //            User.Height = value;
        //            OnPropertyChanged("Height");
        //        }
        //    }
        //}
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            CanRegister();
        }

        public async void AddUser()
        {

            if (isEnabled == true)
            {
                try
                {
                    UserRepo.AddUser(User);
                    await Application.Current.MainPage.DisplayAlert("Success", "User added", "ok");
                }
                catch (Exception)
                {
                    await Application.Current.MainPage.DisplayAlert("Failed", "This username is already in use", "ok");
                }
            }
        }

        public void CanRegister()
        {
            IsEnabled =  Age > 14 && Weight > 30 && !string.IsNullOrEmpty(UserName)
                   && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(PasswordConfirmation) &&
                   PasswordConfirmation == Password;
        }
    }
}