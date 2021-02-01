using DesignThinking.Models;
using DesignThinking.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class ShowMethodViewModel : BaseViewModel
    {
        private ShowMethodPage showMethodPage;
        private Method model;
        private string link;

        public ShowMethodViewModel(ShowMethodPage showMethodPage, Method model)
        {
            Title = "Methodenansicht";
            this.showMethodPage = showMethodPage;
            this.model = model;
            link = model.Weblink;
            OpenWebCommand = new Command(async () => await Browser.OpenAsync(link));
        }
        public Method Model { get => model; set => model = value; }
        public ICommand OpenWebCommand { get; }

    }
}
