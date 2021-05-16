using System;
using System.Windows.Input;
using DesignThinking.Business.Service;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public RegisterPage registerPage;
        public ICommand registrationCommand;
        public string mail;
        public string password;
        public string firstname;
        public string surname;
        private IUserService userService;

        public RegisterViewModel(RegisterPage registerPage)
        {
            Title = "Registrieren";
            this.registerPage = registerPage;
            registrationCommand = new Command(o => Registration());
            userService = new UserService();
            
        }

        private async void Registration()
        {
            if (firstname == null || surname == null || mail == null || password == null)
            {
                await registerPage.DisplayAlert("Fehler", "Es wurden nicht alle Eigenschaften ausgefüllt.", "OK");
                return;
            }
            userService.Save(new User
            {
                FirstName = this.firstname,
                Surname = this.surname,
                Mail = this.mail,
                Password = this.password
            });

            await registerPage.DisplayAlert("Erfolgreich", "Sie können sich nun anmelden.", "OK");
            await registerPage.Navigation.PushAsync(new AccountManagementPage());
        }

        public ICommand RegistrationCommand { get => registrationCommand; set => registrationCommand = value; }

        public string Mail
        {
            get => mail;
            set
            {
                if (mail != value) { mail = value; }
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (password != value) { password = value; }
                OnPropertyChanged();
            }
        }
        public string FirstName
        {
            get => firstname;
            set
            {
                if (firstname != value) { firstname = value; }
                OnPropertyChanged();
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (surname != value) { surname = value; }
                OnPropertyChanged();
            }
        }
    }
}