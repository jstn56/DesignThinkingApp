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
    public class ShowProtocolMethodViewModel : BaseViewModel
    {
        private ShowProtocolMethodPage showProtocolMethodPage;
        private ProtocolMethod model;
        private ICommand imageCommand;
        private ICommand safeCommand;
        private ICommand showCommand;
        private IProtocolMethodService protocolMethodService;


        public ShowProtocolMethodViewModel(ShowProtocolMethodPage showProtocolMethodPage, ProtocolMethod model)
        {
            Title = "Durchgeführte Methode";
            this.showProtocolMethodPage = showProtocolMethodPage;
            this.model = model;
            imageCommand = new Command(o => OpenImage());
            showCommand = new Command(o => ShowImage());
            safeCommand = new Command(o => Safe());
            protocolMethodService = new ProtocolMethodService();
        }

        private async void ShowImage()
        {
            await showProtocolMethodPage.Navigation.PushAsync(new ShowImagePage(this));
        }

        private async void Safe()
        {
            protocolMethodService.Update(Model, 0);
            
            
            if (Parent is ProtocolMethodViewModel viewModel)
                if (viewModel.Parent is ProtocolMethodOverviewViewModel protocolMethod)
                    protocolMethod.RefreshList();

            await showProtocolMethodPage.Navigation.PopAsync();
        }

        private async void OpenImage()
        {
            await showProtocolMethodPage.Navigation.PushAsync(new ImagePage(this));
        }

        public ProtocolMethod Model { get => model; set => model = value; }
        public ICommand ImageCommand { get => imageCommand; set => imageCommand = value; }
        public ICommand ShowImageCommand { get => showCommand; set => showCommand = value; }
        public ICommand SafeCommand { get => safeCommand; set => safeCommand = value; }
    }
}
