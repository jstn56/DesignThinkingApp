using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class CreateTeamViewModel : BaseViewModel
    {
        private CreateTeamPage createTeamPage;
        private string teamname;
        private ICommand createTeam;
        private ObservableCollection<UserViewModel> userList;
        private ITeamService teamService;
        private IUserService userService;
        public CreateTeamViewModel(CreateTeamPage createTeamPage)
        {
            Title = "Team erstellen";
            this.createTeamPage = createTeamPage;
            createTeam = new Command(o => CreateTeam());
            teamService = new TeamService();
            userService = new UserService();
            Init();
        }

        private void Init()
        {
            userList = new ObservableCollection<UserViewModel>(userService.GetAll().Select(user => new UserViewModel(user)));
            userList.Remove(userList.Where(x => x.Model.ident == Session.CurrentUser.ident).FirstOrDefault());
        }

        private async void CreateTeam()
        {
            teamService.Save(new Team
            {
                Name = this.teamname
            });
            var teamnr = teamService.GetAll().Where(x => x.Name == teamname).FirstOrDefault()?.ident;

            var selectedUsers = userList.Where(x => x.IsSelected == true);

            foreach (var user in selectedUsers)
            {
                user.Model.TeamIdent = teamnr.GetValueOrDefault();
                userService.Update(user.Model, 0);
            }
            Session.CurrentUser.TeamIdent = teamnr.GetValueOrDefault();
            userService.Update(Session.CurrentUser, 0);
            await createTeamPage.Navigation.PopAsync();
        }

        public ICommand CreateTeamCommand { get => createTeam; set => createTeam = value; }
        public string Teamname { get => teamname; set => teamname = value; }
        public User SelectedUser {
            get
            {
                return null;
            }
        }
        public ObservableCollection<UserViewModel> UserList { get => userList; set => userList = value; }
    }
}
