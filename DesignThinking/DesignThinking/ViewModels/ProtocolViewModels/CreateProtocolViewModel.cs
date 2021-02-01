using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views.Protocol;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DesignThinking.ViewModels.ProtocolViewModels
{
    public class CreateProtocolViewModel : BaseViewModel
    {
        private CreateProtocolPage protocolPage;
        private Protocol model;
        private ICommand safeCommand;
        private IProtocolService protocolService;
        public CreateProtocolViewModel(CreateProtocolPage protocolPage)
        {
            Title = "Protokoll erstellen";
            this.model = new Protocol { Created = DateTime.Now };
            this.protocolPage = protocolPage;
            this.protocolService = new ProtocolService();
            safeCommand = new Command(o => SafeMethod());
        }

        private async void SafeMethod()
        {
            var teamident = Session.CurrentUser.TeamIdent;
            model.TeamIdent = teamident;
            protocolService.Save(model);
            if (Parent is ProtocolOverviewViewModel protocol)
                protocol.RefreshList();
            await protocolPage.DisplayAlert("Erfolgreich", "Das Protokoll wurde erstellt.", "OK");

            await protocolPage.Navigation.PopAsync();
        }
        public Protocol Model { get => model; set => model = value; }
        public ICommand SafeCommand { get => safeCommand; set => safeCommand = value; }
    }
}
