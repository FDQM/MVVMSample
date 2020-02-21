using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{ 
    class LoginPageViewModel : INotifyPropertyChanged
    {
        public string DisplayErrorMessage { get; set; } = "Login With";
        public User User { get; set; } = new User();
        public ICommand GoToSignUpCommand { get; set; }

        public LoginPageViewModel()
        {
            GoToSignUpCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
                {
                    DisplayErrorMessage = "Alert, Password or Email Empty";
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(User.Email));
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
