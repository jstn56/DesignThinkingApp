 using System;
using System.Linq;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    /// <summary>
    /// Represents the view model for the accountmanagment
    /// </summary>
    public class AccountManagementViewModel : BaseViewModel
    {
        private AccountManagementPage accPage;
        private ICommand userManagementCommand;
        private ICommand registrationCommand;
        private User currentDummy;
        private string mail;
        private string password;
        private UserService userService;

        /// <summary>
        /// Constructor to pass the page 
        /// </summary>
        /// <param name="accPage">Page</param>
        public AccountManagementViewModel(AccountManagementPage accPage)
        {
            Title = "Kontoverwaltung";
            this.accPage = accPage;
            userManagementCommand = new Command(o => UserManagement());
            registrationCommand = new Command(o => Registration());
            userService = new UserService();
        }

        private async void Registration()
        {
            await accPage.Navigation.PushAsync(new RegisterPage());
        }
        /// <summary>
        /// 
        /// </summary>
        private async void UserManagement()
        {
            var selectedUser = userService.GetAll().Where(user => user.Mail == mail).FirstOrDefault();

            if(selectedUser?.Password == password)
            {
                Session.CurrentUser = selectedUser;
                await accPage.Navigation.PushAsync(new UserManagementPage(this));
            } else
            {
                await accPage.DisplayAlert("Achtung", "Bitte überprüfen Sie Ihre Eingabe.", "OK");
            }
        }

        public ICommand UserManagementCommand { get => userManagementCommand; set => userManagementCommand = value; }
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
    }
}