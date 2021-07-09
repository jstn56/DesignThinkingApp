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
        private ICommand dashboardCommand;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public PRSecondViewModel(PRSecondPage pRSecondPage)
        {
            Title = "Problem definieren";
            this.prSecondPage = pRSecondPage;
            Methods = new ObservableCollection<MethodViewModel>();
            openPRFirst = new Command(o => OpenPRFirst());
            openLRFirst = new Command(o => OpenLRFirst());
            dashboardCommand = new Command(o => BackToDashboard());
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
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 22,
                Name = "Jobs to be Done (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 23,
                Name = "MoSCoW Voting (Define)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 24,
                Name = "Analogous Empathy (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 25,
                Name = "Camera Journal (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 26,
                Name = "Problem Framing (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 27,
                Name = "Predict Next Year's Headline (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 28,
                Name = "Shadowing (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 29,
                Name = "Bet-Cost-Matrix (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 30,
                Name = "Suchfeldbestimmung (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 31,
                Name = "Emotional Journey Map (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 32,
                Name = "Personas (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 33,
                Name = "Storyboard (Empathize)",
                Description = "Eine Stakeholder Map ist eine Karte, auf der jeder Stakeholder entsprechend seines" +
                " Einflusses und seinem Interesse an dem Projekt eingeordnet wird. Üblicherweise werden vier Zonen" +
                " und damit Gruppen definiert und es wird festgelegt, auf welche Weise Stakeholder gemanaged werden," +
                " die der jeweiligen Gruppe zugeordnet werden. Oft verwendet wird für die Gruppeneinteilung ´Vollständig zufriedenstellen´," +
                " ´Im Blick behalten´, ´Vollständig informieren´, ´Ganz nah managen´.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1242",
                RoomType = "Problemraum",
                ThinkingType = "Konvergent"
            }, prSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 34,
                Name = "5-Warum-Technik (Empathize)",
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

        private async void BackToDashboard()
        {
            await prSecondPage.Navigation.PopToRootAsync();
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
        public ICommand DashboardCommand { get => dashboardCommand; set => dashboardCommand = value; }
    }
}
