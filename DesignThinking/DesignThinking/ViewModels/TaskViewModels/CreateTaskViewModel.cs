using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using DesignThinking.Views.Protocol;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class CreateTaskViewModel : BaseViewModel
    {
        private CreateTaskPage createTaskPage;
        private ICommand imageCommand;
        private ICommand safeCommand;
        private Models.Task model;
        private ITaskService taskService;
        private ITeamService teamService;
        private string shortDescription;
        private DateTime? deadline;
        private string selectedPriority;
        private User selectedUser;
        private ObservableCollection<string> priority;
        private ObservableCollection<User> users;
        private IUserService userService;

        public CreateTaskViewModel(CreateTaskPage createTaskPage)
        {
            userService = new UserService();
            Title = "Aufgabe erstellen";
            this.createTaskPage = createTaskPage;
            this.taskService = new TaskService();
            this.teamService = new TeamService();
            priority = new ObservableCollection<string>();
            users = new ObservableCollection<User>(userService.GetAll().Where(x => x.TeamIdent == Session.CurrentUser.TeamIdent));

            priority.Add("Niedrig");
            priority.Add("Mittel");
            priority.Add("Hoch");
            imageCommand = new Command(o => OpenImage());
            safeCommand = new Command(o => SafeTask());
        }

        private async void SafeTask()
        {
            var teamident = Session.CurrentUser.TeamIdent;

            taskService.Save(new Models.Task
            {
                TeamIdent = teamident,
                ShortDescription = this.shortDescription,
                UserIdent = this.selectedUser.ident,
                Deadline = this.deadline.GetValueOrDefault(),
                Priority = this.selectedPriority,
            });
            if (Parent is ProjectViewModel task)
                task.RefreshList();
            await createTaskPage.DisplayAlert("Erfolgreich", "Die Aufgabe wurde erstellt.", "OK");

            await createTaskPage.Navigation.PopAsync();
        }

        private async void OpenImage()
        {
            await createTaskPage.Navigation.PushAsync(new ImagePage(this));
        }
        public Models.Task Model { get => model; set => model = value; }
        public ICommand ImageCommand { get => imageCommand; set => imageCommand = value; }
        public ICommand SafeCommand { get => safeCommand; set => safeCommand = value; }
        public string ShortDescription
        { 
            get => shortDescription; 
            set
            {
                if(shortDescription != value) { shortDescription = value; }
                OnPropertyChanged();
            }
        }
        public DateTime Deadline
        {
            get => deadline ?? DateTime.Now.Date;
            set
            {
                if (deadline != value) { deadline = value; }
                OnPropertyChanged();
            }
        }
        public string SelectedPriority { get => selectedPriority; set => selectedPriority = value; }
        public User SelectedUser { get => selectedUser; set => selectedUser = value; }
        public ObservableCollection<string> Priority { get => priority; set => priority = value; }
        public ObservableCollection<User> Users { get => users; set => users = value; }
    }
}
