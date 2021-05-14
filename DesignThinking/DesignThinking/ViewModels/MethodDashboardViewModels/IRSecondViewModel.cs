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
    public class IRSecondViewModel : BaseViewModel
    {
        private IRSecondPage irSecondPage;
        private ICommand openIRFirst;
        private ICommand dashboardCommand;
        public ObservableCollection<MethodViewModel> Methods { get; set; }

        public IRSecondViewModel(IRSecondPage iRSecondPage)
        {
            Title = "Tests beurteilen";
            this.irSecondPage = iRSecondPage;
            openIRFirst = new Command(o => OpenIRFirst());
            dashboardCommand = new Command(o => BackToDashboard());
            Methods = new ObservableCollection<MethodViewModel>();
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 15,
                Name = "Thinking Aloud-Test (Test)",
                Description = "Bei der Thinking Aloud-Methode geht es vorallem darum, dass die Testnutzer bei der Interaktion" +
                " mit dem Prototypen genau erklären, warum sie genau diese Handlungen durchführen. Hierdurch können wichtige" +
                " Einblicke in Bezug auf die User Experience gewonnen und live miterlebt werden, wie Nutzer mit dem Prototypen" +
                " interagieren und wo gegebenenfalls noch Schwachstellen liegen.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/206",
                RoomType = "Implementierungsraum",
                ThinkingType = "Konvergent"
            }, irSecondPage));
            Methods.Add(new MethodViewModel(new Method
            {
                ident = 16,
                Name = "Capture Grid (Test)",
                Description = "Bei der Capture Grid oder auch Feedback Capture Grid Methode sollen während des Testens alle Neuerungen," +
                " die hierbei aufgedeckt werden, wie etwa neue Ideen, entdeckte Vor-oder Nachteile aber auch Unklarheiten, visuell und übersichtlich" +
                " in einem Raster festgehalten werden.",
                Weblink = "https://it-studienprojekt.hosting.uni-hildesheim.de/node/101",
                RoomType = "Implementierungsraum",
                ThinkingType = "Konvergent"
            }, irSecondPage));
        }

        private async void BackToDashboard()
        {
            await irSecondPage.Navigation.PopToRootAsync();
        }

        //Für das inserten in der datenbank 
        //private void Insert()
        //{
        //    foreach (var item in Methods)
        //    {
        //        IMethodService methodService = new MethodService();
        //        methodService.Save(item.Model);
        //    }
        //}

        private async void OpenIRFirst()
        {
            await irSecondPage.Navigation.PushAsync(new IRFirstPage());
        }

        public ICommand IRFirst { get => openIRFirst; set => openIRFirst = value; }
        public ICommand DashboardCommand { get => dashboardCommand; set => dashboardCommand = value; }
    }
}
