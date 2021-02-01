using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using DesignThinking.Views.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class ShowTaskViewModel : BaseViewModel
    {
        private ShowTaskPage showTaskPage;
        private Models.Task model;
        private ICommand imageCommand; 
        private ICommand safeCommand;
        private ICommand showCommand;
        private ITaskService taskService;

        public ShowTaskViewModel(ShowTaskPage showTaskPage, Models.Task model)
        {
            Title = "Aufgabenansicht";
            this.showTaskPage = showTaskPage;
            this.model = model;
            this.taskService = new TaskService();
            imageCommand = new Command(o => OpenImage());
            safeCommand = new Command(o => Safe());
            showCommand = new Command(o => ShowImage());
        }

        private async void ShowImage()
        {
            await showTaskPage.Navigation.PushAsync(new ShowImagePage(this));
        }

        private async void Safe()
        {
            taskService.Update(Model, 0);

            if (Parent is TaskViewModel viewModel)
                if (viewModel.Parent is ProjectViewModel task)
                    task.RefreshList();

            await showTaskPage.Navigation.PopAsync();
        }

        private async void OpenImage()
        {
            await showTaskPage.Navigation.PushAsync(new ImagePage(this));
        }

        public Models.Task Model { get => model; set => model = value; }
        public ICommand ImageCommand { get => imageCommand; set => imageCommand = value; }
        public ICommand SafeCommand { get => safeCommand; set => safeCommand = value; }
        public ICommand ShowImageCommand { get => showCommand; set => showCommand = value; }
    }
}
