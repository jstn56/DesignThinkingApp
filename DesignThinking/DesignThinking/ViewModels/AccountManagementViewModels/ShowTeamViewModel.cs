using System;
using System.Collections.ObjectModel;
using System.Linq;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;

namespace DesignThinking.ViewModels
{
    public class ShowTeamViewModel : BaseViewModel
    {
        private ShowTeamPage showTeamPage;
        private IUserService userService;
        private ITeamService teamService;
        private ObservableCollection<User> userList;

        public ShowTeamViewModel(ShowTeamPage showTeamPage)
        {
            Title = "Teammitglieder";
            this.showTeamPage = showTeamPage;
            userService = new UserService();
            teamService = new TeamService();
            Init();
        }

        private void Init()
        {
            var userident = Session.CurrentUser.ident;
            var teamnr = userService.Get(userident).TeamIdent;
            userList = new ObservableCollection<User>(userService.GetAll().Where(x => x.TeamIdent == teamnr));
        }

        public ObservableCollection<User> UserList { get => userList; set => userList = value; }
    }
}
