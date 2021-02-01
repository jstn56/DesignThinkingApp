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
    public class IRFirstViewModel : BaseViewModel
    {
        private IRFirstPage irFirstPage;
        private ICommand openLRSecond;
        private ICommand openIRSecond;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public IRFirstViewModel(IRFirstPage irFirstPage)
        {
            Title = "Implementierungsraum";
            this.irFirstPage = irFirstPage;
           
            openLRSecond = new Command(o => OpenLRSecond());
            openIRSecond = new Command(o => OpenIRSecond());
            Methods = new ObservableCollection<MethodViewModel>();
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 12,
                Name = "Service-Blueprint (Prototyp)",
                Description = "Der Service-Blueprint ist eine auf Dienstleistungen ausgerichtete Methode," +
                " um den Leistungserstellungsprozesses zwischen Kunden und Dienstleister mit allen dafür" +
                " notwendigen Prozessschritten, Ereignissen und Entscheidungen zu visualisieren. Er erweitert" +
                " die Customer Journey durch die Einbeziehung von unterstützenden Technologien, Daten und Kundeninteraktionen",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/1331",
                RoomType = "Implementierungsraum",
                ThinkingType = "Divergent"
            }, irFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 13,
                Name = "Mock-Ups (Prototyp)",
                Description = "Mock-Ups sind eine grafische Visualisierungsmöglichkeit oder auch Attrappen und werden bei der Konzeptionierung" +
                " von grafischen Benutzeroberflächen verwendet, um einen voraussichtlichen Eindruck über die Bedienung einer Anwendung zu geben." +
                " Je nach Anforderung simuliert ein Mock-Up die vollständige Benutzeroberfläche inklusive aller Funktionen der Anwendung und Inhalte" +
                " oder nur einen ausgewählten Teil der für Nutzertests und Feedback ausgewählt wird. Mock-Ups ermöglichen somit die Einholung von" +
                " Meinungen und Erfahrungswerten aus Nutzersicht, vor der eigentlichen Entwicklung.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/105",
                RoomType = "Implementierungsraum",
                ThinkingType = "Divergent"
            }, irFirstPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 14,
                Name = "Papierprototyp (Prototyp)",
                Description = "Ein Papierprototyp visualisiert die elementaren Merkmale einer Produktidee, wie z.B. die Entwicklung einer Anwendung." +
                " Die Programmoberfläche wird dabei, samt der mit ihren möglichen Interaktionen, in Abstrakter Form dargestellt. Es geht dabei nicht" +
                " um das Testen der Anwendung, sondern der Darstellung des Konzepts und der möglichen Aufteilung einzelner Anwendungskomponenten. Dabei" +
                " werden bewusst einfache Hilfsmittel verwendet.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/106",
                RoomType = "Implementierungsraum",
                ThinkingType = "Divergent"
            }, irFirstPage));
        }

        private async void OpenLRSecond()
        {
            await irFirstPage.Navigation.PushAsync(new LRSecondPage());
        }

        private async void OpenIRSecond()
        {
            await irFirstPage.Navigation.PushAsync(new IRSecondPage());
        }

        public ICommand IRSecond { get => openIRSecond; set => openIRSecond = value; }
        public ICommand LRSecond { get => openLRSecond; set => openLRSecond = value; }
    }
}
