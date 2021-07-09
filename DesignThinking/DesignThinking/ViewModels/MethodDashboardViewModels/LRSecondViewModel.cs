using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class LRSecondViewModel : BaseViewModel
    {
        private LRSecondPage lrSecondPage;
        private ICommand openLRFirst;
        private ICommand openIRFirst;
        private ICommand dashboardCommand;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public LRSecondViewModel(LRSecondPage lRSecondPage)
        {
            Title = "Ideen auswählen";
            this.lrSecondPage = lRSecondPage;
            openLRFirst = new Command(o => OpenLRFirst());
            openIRFirst = new Command(o => OpenIRFirst());
            dashboardCommand = new Command(o => BackToDashboard());
            Methods = new ObservableCollection<MethodViewModel>();
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 43,
                Name = "How-Wow-Now Matrix (Ideate)",
                Description = "Die How-Wow-Now Matrix wird verwendet um Ideen hinsichtlich ihrer Umsetzbarkeit" +
                " und Innovation zu bewerten. Sie eignet sich besonders im Anschluss an die divergierende Ideenfindungsphase." +
                " Aus einem großen Pool an Ideen können mit Hilfe der Matrix die Ideen strukturiert sortiert werden, sodass am" +
                " Ende erkennbar ist, welche Ideen besonders geeignet sind weiterverfolgt zu werden.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/148",
                RoomType = "Lösungsraum",
                ThinkingType = "Konvergent"
            }, lrSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 44,
                Name = "Dotmocracy (Ideate)",
                Description = "Bei dieser Methode handelt es sich um einen demokratischen Auswahlprozess von Ideen," +
                " auch Dot-Voting genannt. Dieser Auswahlprozess findet in der Regel innerhalb der Ideenfindungsphase" +
                " des Design Thinkings statt.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/146",
                RoomType = "Lösungsraum",
                ThinkingType = "Konvergent"
            }, lrSecondPage));
        }

        private async void BackToDashboard()
        {
            await lrSecondPage.Navigation.PopToRootAsync();
        }

        private async void OpenLRFirst()
        {
            await lrSecondPage.Navigation.PushAsync(new LRFirstPage());
        }

        private async void OpenIRFirst()
        {
            await lrSecondPage.Navigation.PushAsync(new IRFirstPage());
        }

        public ICommand IRFirst { get => openIRFirst; set => openIRFirst = value; }
        public ICommand LRFirst { get => openLRFirst; set => openLRFirst = value; }
        public ICommand DashboardCommand { get => dashboardCommand; set => dashboardCommand = value; }
    }
}
