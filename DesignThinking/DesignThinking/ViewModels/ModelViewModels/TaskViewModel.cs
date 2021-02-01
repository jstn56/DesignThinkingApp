using System;
using System.Threading.Tasks;
using System.Windows.Input;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Views;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class TaskViewModel : BaseViewModel
    { 
        private ICommand method;
        private ContentPage contentPage;
        private Models.Task model;
        private IUserService userService;

        public TaskViewModel(Models.Task model, ContentPage contentPage)
        {
            this.model = model;

            method = new Command(o => OpenTask());
            this.contentPage = contentPage;
            userService = new UserService();
            model.User = userService.Get(model.UserIdent);
        }

        private async void OpenTask()
        {
            await contentPage.Navigation.PushAsync(new ShowTaskPage(model, this));
        }

        public Models.Task Model { get => model; set => model = value; }
        public ICommand TaskCommand { get => method; set => method = value; }
    
    }
}
