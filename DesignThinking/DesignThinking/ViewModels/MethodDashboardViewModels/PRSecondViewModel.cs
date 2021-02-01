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
    public class PRSecondViewModel : BaseViewModel
    {
        private PRSecondPage prSecondPage;
        private ICommand openPRFirst;
        private ICommand openLRFirst;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public PRSecondViewModel(PRSecondPage pRSecondPage)
        {
            Title = "Problemraum";
            this.prSecondPage = pRSecondPage;
            Methods = new ObservableCollection<MethodViewModel>();
            openPRFirst = new Command(o => OpenPRFirst());
            openLRFirst = new Command(o => OpenLRFirst());
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 5,
                Name = "Konkurrent - Komplementor Map (Define)",
                Description = "Die Konkurrent - Komplementor Map ist eine Möglichkeit die Position des" +
                " Unternehmens oder Produktes in seiner Branche sichtbar zu machen. Es wird zudem aufgezeigt," +
                " wie Produkte miteinander konkurrieren oder sich ergänzen können.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1354",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 6,
                Name = "Stakeholder Map (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
        }
        private async void OpenLRFirst()
        {
            await prSecondPage.Navigation.PushAsync(new LRFirstPage());
        }

        private async void OpenPRFirst()
        {
            await prSecondPage.Navigation.PushAsync(new PRFirstPage());
        }

        public ICommand PRFirst { get => openPRFirst; set => openPRFirst = value; }
        public ICommand LRFirst { get => openLRFirst; set => openLRFirst = value; }
    }
}
