using System;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class UserManagementViewModel : BaseViewModel
    {
        private UserManagementPage userPage;
        private ICommand createTeamCommand;
        private ICommand showTeamCommand;
        private ICommand logoutCommand;
        private string mail;
        private string firstname;
        private string surname;
        private UserService userService;


        public UserManagementViewModel(UserManagementPage userPage)
        {
            Title = "";
            this.userPage = userPage;
            createTeamCommand = new Command(o => CreateTeam());
            showTeamCommand = new Command(o => ShowTeam());
            logoutCommand = new Command(o => Logout());
            userService = new UserService();
            Init();
        }

        private async void Logout()
        {
            await userPage.Navigation.PopToRootAsync();
            Session.CurrentUser = null;
            if (Parent is AccountManagementViewModel viewModel)
            {
                viewModel.Password = null;
                viewModel.Mail = null;
                viewModel.OnPropertyChanged(nameof(viewModel.Mail));
                viewModel.OnPropertyChanged(nameof(viewModel.Password));
            }
        }

        private void Init()
        {
            var currentUser = Session.CurrentUser;
            firstname = currentUser.FirstName;
            surname = currentUser.Surname;
            mail = currentUser.Mail;
        }

        private async void CreateTeam()
        {
            await userPage.Navigation.PushAsync(new CreateTeamPage());
        }

        private async void ShowTeam()
        {
            await userPage.Navigation.PushAsync(new ShowTeamPage());
        }

        public ICommand CreateTeamCommand { get => createTeamCommand; set => createTeamCommand = value; }
        public ICommand ShowTeamCommand { get => showTeamCommand; set => showTeamCommand = value; }
        public ICommand LogoutCommand { get => logoutCommand; set => logoutCommand = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}