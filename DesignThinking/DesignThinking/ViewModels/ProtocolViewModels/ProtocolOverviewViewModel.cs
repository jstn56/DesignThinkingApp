using DesignThinking.Base;
using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.ViewModels.ModelViewModels;
using DesignThinking.Views.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace DesignThinking.ViewModels.ProtocolViewModels
{
    public class ProtocolOverviewViewModel : BaseViewModel
    {
        private ProtocolOverviewPage protocolPage;
        private ICommand createProtocolCommand;
        private ObservableCollection<ProtocolModelViewModel> protocols;
        private IProtocolService protocolService;
        private object visible;
        public ProtocolOverviewViewModel(ProtocolOverviewPage protocolPage)
        {
            IsBusy = true;
            OnPropertyChanged(nameof(IsBusy));
            Title = "";
            createProtocolCommand = new Command(o => CreateMethod());
            this.protocolPage = protocolPage;
            this.protocolService = new ProtocolService();
            RefreshList();
        }
        private void LoadMethods()
        {
            foreach (var item in protocols)
                item.Model = protocolService.Get(item.Model.ident);
        }
        public void RefreshList()
        {

            Application.Current.Dispatcher.BeginInvokeOnMainThread(new Action(
                        () =>
                        {
                            protocols = new ObservableCollection<ProtocolModelViewModel>(protocolService.GetAll()
                                .Select(x => new ProtocolModelViewModel(x, protocolPage))
                                .Where(x => x.Model.TeamIdent == Session.CurrentUser?.TeamIdent));

                            OnPropertyChanged(nameof(Protocols));
                            LoadMethods();
                        }));
            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        private async void CreateMethod()
        {
            await protocolPage.Navigation.PushAsync(new CreateProtocolPage(this));
        }
        public ICommand CreateProtocolCommand { get => createProtocolCommand; set => createProtocolCommand = value; }
        public ObservableCollection<ProtocolModelViewModel> Protocols { get => protocols; set => protocols = value; }

        public bool Visible { get => Session.CurrentUser != null; set => visible = value; }
        public bool VisibleError { get => Session.CurrentUser == null; set => visible = value; }
    }
}
