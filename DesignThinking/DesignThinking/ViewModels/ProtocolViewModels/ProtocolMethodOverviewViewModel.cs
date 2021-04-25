using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class ProtocolMethodOverviewViewModel : BaseViewModel
    {

        private ProtocolMethodOverviewPage protocolPage;
        private ICommand createMethodCommand;
        private ObservableCollection<ProtocolMethodViewModel> protocolMethodsFalse;
        private ObservableCollection<ProtocolMethodViewModel> protocolMethodsTrue;
        private IProtocolMethodService protocolMethodService;
        private IProtocolService protocolService;
        private IMethodService methodService;
        private object visible;

        public ProtocolMethodOverviewViewModel(ProtocolMethodOverviewPage protocolPage)
        {
            IsBusy = true;
            OnPropertyChanged(nameof(IsBusy));
            Title = "Protokollverwaltung";
            createMethodCommand = new Command(o => CreateMethod());
            this.protocolPage = protocolPage;
            this.protocolMethodService = new ProtocolMethodService();
            this.protocolService = new ProtocolService();
            this.methodService = new MethodService();
            RefreshList();
        }

        private void LoadMethods()
        {
            foreach (var item in protocolMethodsFalse)
                item.Model.Method = methodService.Get(item.Model.MethodIdent);
            foreach (var item in protocolMethodsTrue)
                item.Model.Method = methodService.Get(item.Model.MethodIdent);
        }
        public void RefreshList()
        {

            Application.Current.Dispatcher.BeginInvokeOnMainThread(new Action(
                        () =>
                        {
                            protocolMethodsFalse = new ObservableCollection<ProtocolMethodViewModel>(protocolMethodService.GetAll()
                .Select(pm => new ProtocolMethodViewModel(pm, protocolPage) { Parent = this })
                .Where(x => x.Model.IsCompleted == false && protocolService.Get(x.Model.ProtocolIdent)?.TeamIdent == Session.CurrentUser?.TeamIdent));

                            protocolMethodsTrue = new ObservableCollection<ProtocolMethodViewModel>(protocolMethodService.GetAll()
                                .Select(pm => new ProtocolMethodViewModel(pm, protocolPage) { Parent = this })
                                .Where(x => x.Model.IsCompleted == true && protocolService.Get(x.Model.ProtocolIdent)?.TeamIdent == Session.CurrentUser?.TeamIdent));
                            OnPropertyChanged(nameof(ProtocolMethodsFalse));
                            OnPropertyChanged(nameof(ProtocolMethodsTrue));
                            LoadMethods();
                        }));
            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        private async void CreateMethod()
        {
            await protocolPage.Navigation.PushAsync(new CreateProtocolMethodPage(this));
        }
        public ICommand CreateMethodCommand { get => createMethodCommand; set => createMethodCommand = value; }
        public ObservableCollection<ProtocolMethodViewModel> ProtocolMethodsFalse { get => protocolMethodsFalse; set => protocolMethodsFalse = value; }
        public ObservableCollection<ProtocolMethodViewModel> ProtocolMethodsTrue { get => protocolMethodsTrue; set => protocolMethodsTrue = value; }

        public ProtocolMethodViewModel SelectedItem { get; set; }

        public bool Visible { get => Session.CurrentUser != null; set => visible = value; }
        public bool VisibleError { get => Session.CurrentUser == null; set => visible = value; }
    }
}