using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.ViewModels.ModelViewModels;
using DesignThinking.Views;
using DesignThinking.Views.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class CreateProtocolMethodViewModel : BaseViewModel
    {
        private CreateProtocolMethodPage createProtocolMethodPage;
        private ProtocolMethod model;
        private Method selectedMethod;
        private string selectedRoom;
        private string selectedPhase;
        private ObservableCollection<string> rooms;
        private ObservableCollection<string> thinkingTypes;
        private ObservableCollection<Method> methods;
        private ICommand imageCommand;
        private ICommand safeCommand;
        private IMethodService methodService;
        private IProtocolMethodService protocolService;
        private ITeamService teamService;



        public CreateProtocolMethodViewModel(CreateProtocolMethodPage createProtocolMethodPage)
        {
            Title = "Methode hinzufügen";
            this.createProtocolMethodPage = createProtocolMethodPage;
            this.methodService = new MethodService();
            this.protocolService = new ProtocolMethodService();
            this.teamService = new TeamService();
            imageCommand = new Command(o => OpenImage());
            safeCommand = new Command(o => SafeMethod());
            rooms = new ObservableCollection<string>();
            rooms.Add("Problem");
            rooms.Add("Lösung");
            rooms.Add("Implementierung");
            thinkingTypes = new ObservableCollection<string>();
            thinkingTypes.Add("Divergent");
            thinkingTypes.Add("Konvergent");

            methods = new ObservableCollection<Method>(methodService.GetAll());

        }

        private async void SafeMethod()
        {
            var teamident = Session.CurrentUser.TeamIdent;
            if (selectedMethod == null)
            {
                await createProtocolMethodPage.DisplayAlert("Fehler", "Es muss eine Methode ausgewählt werden.", "OK");
                return;
            }
            if (Parent is BaseViewModel viewModel)
            {
                if (viewModel.Parent is ProtocolModelViewModel protocolModelViewModel)
                {

                    protocolService.Save(new ProtocolMethod
                    {
                        ProtocolIdent = protocolModelViewModel.Model.ident,
                        RoomType = this.selectedRoom,
                        ThinkingType = this.selectedPhase,
                        MethodIdent = this.selectedMethod.ident,
                    });
                }
            }
            if (Parent is ProtocolMethodOverviewViewModel protocolMethod)
                protocolMethod.RefreshList();
            await createProtocolMethodPage.DisplayAlert("Erfolgreich", "Die Methode wurde erstellt.", "OK");

            await createProtocolMethodPage.Navigation.PopAsync();
        }

        private async void OpenImage()
        {
            await createProtocolMethodPage.Navigation.PushAsync(new ImagePage(this));
        }

        public ProtocolMethod Model { get => model; set => model = value; }
        public Method SelectedMethod { get => selectedMethod; set => selectedMethod = value; }
        public string SelectedRoom { get => selectedRoom; set => selectedRoom = value; }
        public string SelectedPhase { get => selectedPhase; set => selectedPhase = value; }
        public ObservableCollection<string> Rooms { get => rooms; set => rooms = value; }
        public ObservableCollection<string> ThinkingTypes { get => thinkingTypes; set => thinkingTypes = value; }

        public ObservableCollection<Method> Methods { get => methods; set => methods = value; }
        public ICommand ImageCommand { get => imageCommand; set => imageCommand = value; }
        public ICommand SafeCommand { get => safeCommand; set => safeCommand = value; }
    }
}
