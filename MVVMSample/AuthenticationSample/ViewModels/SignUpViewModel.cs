using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    class SignUpViewModel
    {
        public ICommand GoToMenuCommand { get; set; }
        public NewUser NewUser { get; set; } = new NewUser();
        public User User { get; set; } = new User();
        public SignUpViewModel(string Email)
        {
            User.Email = Email ;
            GoToMenuCommand = new Command(async () =>
                {
                    if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(NewUser.NewPassword) || string.IsNullOrEmpty(NewUser.RepeatPassword))
                    {
                        await App.Current.MainPage.DisplayAlert("Alert", "Password or Email Empty", "OK");
                    }
                    else
                    {
                        await App.Current.MainPage.Navigation.PushAsync(new MenuPage());
                    }
                });

        }
    }
}
