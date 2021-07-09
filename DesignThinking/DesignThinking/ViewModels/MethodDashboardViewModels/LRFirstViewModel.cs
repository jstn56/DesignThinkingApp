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
    public class LRFirstViewModel : BaseViewModel
    {
        private LRFirstPage lrFirstPage;
        private ICommand openPRSecond;
        private ICommand openLRSecond;
        private ICommand dashboardCommand;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public LRFirstViewModel(LRFirstPage lrFirstPage)
        {
            Title = "Idee finden";
            this.lrFirstPage = lrFirstPage;
            openPRSecond = new Command(o => OpenPRSecond());
            openLRSecond = new Command(o => OpenLRSecond());
            dashboardCommand = new Command(o => BackToDashboard());
            Methods = new ObservableCollection<MethodViewModel>();
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 7,
                Name = "Power of Ten (Ideate)",
                Description = "Die Methode Power of Ten eignet sich gut für die Ideenfindung. Dabei wird ein Problem" +
                " auf verschiedene Betrachtungsstufen skaliert. So kann aus einer vergrößerten oder einer verkleinerten" +
                " Perspektive heraus die Problemlösung angegangen werden.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/255",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 8,
                Name = "Mash Up (Ideate)",
                Description = "Die Mash-Up Methode wird in der Ideenfindungsphase eingesetzt, um neue Konzepte oder Vorschläge" +
                " zu entwickeln. So soll die Kreativität des Entwicklungsteams gefördert werden. Dazu werden zwei bestehende Ideen," +
                " die meist nicht ansatzweise zusammenhängen, miteinander kombiniert, um neue Ideen zu generieren, die anders nicht" +
                " erdacht werden konnten.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/792",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 9,
                Name = "Bodystorming (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 35,
                Name = "NABC-Methode (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 36,
                Name = "Random Input (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 37,
                Name = "Walt-Disney-Methode (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 38,
                Name = "Gut Check (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 39,
                Name = "635-Methode (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 40,
                Name = "Collective Notebook (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 41,
                Name = "Mindmapping (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 42,
                Name = "Brainwriting (Ideate)",
                Description = "Der Einsatz der Methode Bodystorming eignet sich insbesondere für die Sammlung von Ideen, kann aber auch für" +
                " das Prototyping genutzt werden. Bodystorming stellt eine Erweiterung des Rollenspiels dar, denn es wird eine Situation aus" +
                " der Perspektive der betrachtenden Person körperlich nacherlebt. Besonders geeignet ist Bodystorming, wenn die Bedürfnisse von" +
                " Kunden noch nicht vollständig erfasst sind.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/254",
                RoomType = "Lösungsraum",
                ThinkingType = "Divergent"
            }, lrFirstPage));
        }

        private async void BackToDashboard()
        {
            await lrFirstPage.Navigation.PopToRootAsync();
        }

        private async void OpenLRSecond()
        {
            await lrFirstPage.Navigation.PushAsync(new LRSecondPage());
        }

        private async void OpenPRSecond()
        {
            await lrFirstPage.Navigation.PushAsync(new PRSecondPage());
        }

        public ICommand PRSecond { get => openPRSecond; set => openPRSecond = value; }
        public ICommand LRSecond { get => openLRSecond; set => openLRSecond = value; }
        public ICommand DashboardCommand { get => dashboardCommand; set => dashboardCommand = value; }
    }
}
