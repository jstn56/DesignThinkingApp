using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using DesignThinking.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class PRFirstViewModel : BaseViewModel
    {
        private PRFirstPage prFirstPage;
        private ICommand openPRSecond;
        private ICommand dashboardCommand;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public PRFirstViewModel(PRFirstPage prFirstPage)
        {
            Title = "Problem recherchieren";
            this.prFirstPage = prFirstPage;
            openPRSecond = new Command(o => OpenPRSecond());
            dashboardCommand = new Command(o => BackToDashboard());
            Methods = new ObservableCollection<MethodViewModel>();
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 1,
                Name = "6-W Methode (Empathize) ",
                Description = "In der 6-W Methode werden grundlegende Fragen bezüglich einer Situation oder eines" +
                " Szenarios gestellt. Behandelt werden in der Regel die Fragen Wer? Warum? Was? Wann? Wo? Wie?",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/136",
                RoomType = "Problemraum",
                ThinkingType = "Divergent"
            }, prFirstPage
                ));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 2,
                Name = "Process Mapping (Define)",
                Description = "Diese Methode sieht vor, dass zu Beginn des Projektes alle notwendigen Prozesse," +
                " sowie deren einzelne Schritte, visuell dargestellt werden. Dazu werden alle an der Entwicklung" +
                " eines Produktes beteiligten Mitarbeiter konsultiert, um gemeinsam einen Übersichtsplan über alle" +
                " notwendigen Prozesse zu erstellen. Daher wird die Process Mapping Methode in der Definitionsphase" +
                " zu Beginn des Projektes eingesetzt, um das Projektmanagement zu unterstützen.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1325",
                RoomType = "Problemraum",
                ThinkingType = "Divergent"
            }, prFirstPage));
            openPRSecond = new Command(o => OpenPRSecond());
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 3,
                Name = "Rapid Ethnography (Define)",
                Description = "Diese Methode sieht vor, dass vor der Entwicklung eines neuen Produktes so viel Zeit wie" +
                " möglich mit den zukünftigen Nutzern verbracht wird, um deren Bedürfnisse und Anforderungen an das Produkt" +
                " so genau wie möglich kennen zu lernen. Die Eindrücke der Testperson werden mit Kameras, Audiorekordern oder" +
                " Schreibmaterial dokumentiert, um diese später auswerten zu können. Die Rapid Ethnography wird in der " +
                "Definitionsphase des Design Thinking Prozesses eingesetzt, um vor dem Beginn der Entwicklung genau" +
                " analysieren zu können, welchen Anforderungen das Produkt genügen sollte.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1256",
                RoomType = "Problemraum",
                ThinkingType = "Divergent"
            }, prFirstPage));
            openPRSecond = new Command(o => OpenPRSecond());
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 4,
                Name = "Moodboard (Empathize)",
                Description = "Diese Methode sieht vor, dass eine oder mehrere Personen auf einem Board grafisch einordnen," +
                " wie sie beispielsweise ihr persönliches Umfeld, die Umgebung des Kunden oder die visuelle Gestaltung eines" +
                " Produktes erleben. Dadurch, dass zusammenhängende Konzepte in der Nähe zueinander eingeordnet werden, lässt" +
                " sich genauer definieren, wie eine Testperson bestimmte Situationen oder Produkte empfindet. Dazu wird das Moodboard " +
                "in der Empathize-Phase eingesetzt, um einen genauen Überblick über die persönliche Wahrnehmung des Kunden zu erreichen.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1241",
                RoomType = "Problemraum",
                ThinkingType = "Divergent"
            }, prFirstPage));
        }

        private async void BackToDashboard()
        {
            await prFirstPage.Navigation.PopToRootAsync();
        }

        private async void OpenPRSecond()
        {
            await prFirstPage.Navigation.PushAsync(new PRSecondPage());
        }

        public ICommand PRSecond { get => openPRSecond; set => openPRSecond = value; }
        public ICommand DashboardCommand { get => dashboardCommand; set => dashboardCommand = value; }
    }
}
