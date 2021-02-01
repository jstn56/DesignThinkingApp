using DesignThinking.Models;
using DesignThinking.Views;
using DesignThinking.Views.Protocol;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private DashboardPage dashboardPage;
        private ICommand openProtocolPage;
        private ICommand openPRFirst;
        private ICommand openPRSecond;
        private ICommand openLRFirst;
        private ICommand openLRSecond;
        private ICommand openIRFirst;
        private ICommand openIRSecond;

        public DashboardViewModel(DashboardPage dashboardPage)
        {
            Title = "Dashboard";
            this.dashboardPage = dashboardPage;
            openProtocolPage = new Command(o => OpenProtocolPage());
            openPRFirst = new Command(o => OpenPRFirst());
            openPRSecond = new Command(o => OpenPRSecond());
            openLRFirst = new Command(o =>OpenLRFirst());
            openLRSecond = new Command(o => OpenLRSecond());
            openIRFirst = new Command(o => OpenIRFirst());
            openIRSecond = new Command(o => OpenIRSecond());

        }

        private async void OpenProtocolPage()
        {
            await dashboardPage.Navigation.PushAsync(new ProtocolOverviewPage(null));
        }

        private async void OpenPRFirst()
        {
            await dashboardPage.Navigation.PushAsync(new PRFirstPage());
        }

        private async void OpenPRSecond()
        {
            await dashboardPage.Navigation.PushAsync(new PRSecondPage());
        }

        private async void OpenLRFirst()
        {
            await dashboardPage.Navigation.PushAsync(new LRFirstPage());
        }

        private async void OpenLRSecond()
        {
            await dashboardPage.Navigation.PushAsync(new LRSecondPage());
        }

        private async void OpenIRFirst()
        {
            await dashboardPage.Navigation.PushAsync(new IRFirstPage());
        }

        private async void OpenIRSecond()
        {
            await dashboardPage.Navigation.PushAsync(new IRSecondPage());
        }
        public ICommand ProtocolPage { get => openProtocolPage; set => openProtocolPage = value; }
        public ICommand PRFirst { get => openPRFirst; set => openPRFirst = value; }
        public ICommand PRSecond { get => openPRSecond; set => openPRSecond = value; }
        public ICommand LRFirst { get => openLRFirst; set => openLRFirst = value; }
        public ICommand LRSecond { get => openLRSecond; set => openLRSecond = value; }
        public ICommand IRFirst { get => openIRFirst; set => openIRFirst = value; }
        public ICommand IRSecond { get => openIRSecond; set => openIRSecond = value; }

    }
}