using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class ProjectViewModel : BaseViewModel
    {
        private ProjectPage projectPage;
        private ICommand createTaskCommand;
        private ObservableCollection<TaskViewModel> tasksFalse;
        private ObservableCollection<TaskViewModel> tasksTrue;
        private ITaskService taskService;
        private object visible;

       
        public ProjectViewModel(ProjectPage projectPage)
        {
            Title = "Aufgabenübersicht";
            createTaskCommand = new Command(o => CreateTask());
            this.projectPage = projectPage;
            this.taskService = new TaskService();
            RefreshList();
            
        }
        private void LoadTasks()
        {
            foreach (var item in tasksFalse)
                item.Model.ShortDescription = taskService.Get(item.Model.ident).ShortDescription;
            foreach (var item in tasksTrue)
                item.Model.ShortDescription = taskService.Get(item.Model.ident).ShortDescription;
        }
        public void RefreshList()
        {
            Application.Current.Dispatcher.BeginInvokeOnMainThread(new Action(
                () =>
                {
                    tasksFalse = new ObservableCollection<TaskViewModel>(taskService.GetAll()
                .Select(task => new TaskViewModel(task, projectPage) { Parent = this })
                .Where(x => x.Model.IsCompleted == false && x.Model.TeamIdent == Session.CurrentUser?.TeamIdent));

                    tasksTrue = new ObservableCollection<TaskViewModel>(taskService.GetAll()
                        .Select(task => new TaskViewModel(task, projectPage) { Parent = this })
                        .Where(x => x.Model.IsCompleted == true && x.Model.TeamIdent == Session.CurrentUser?.TeamIdent));
                    OnPropertyChanged(nameof(TasksFalse));
                    OnPropertyChanged(nameof(TasksTrue));
                    LoadTasks();
                }));
            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        private async void CreateTask()
        {
            await projectPage.Navigation.PushAsync(new CreateTaskPage(this));
        }
        public ObservableCollection<TaskViewModel> TasksFalse { get => tasksFalse; set => tasksFalse = value; }
        public ObservableCollection<TaskViewModel> TasksTrue { get => tasksTrue; set => tasksTrue = value; }
        public ICommand CreateTaskCommand { get => createTaskCommand; set => createTaskCommand = value; }
        public bool Visible { get => Session.CurrentUser != null; set => visible = value; }
        public bool VisibleError { get => Session.CurrentUser == null; set => visible = value; }
    }
}