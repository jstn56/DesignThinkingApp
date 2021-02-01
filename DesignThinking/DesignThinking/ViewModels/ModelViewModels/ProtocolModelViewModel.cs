using DesignThinking.Models;
using DesignThinking.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DesignThinking.ViewModels.ModelViewModels
{
    public class ProtocolModelViewModel : BaseViewModel
    {
        private Protocol model;
        private ICommand method;
        private ContentPage contentPage;

        public ProtocolModelViewModel(Protocol model, ContentPage contentPage)
        {
            this.model = model;
            method = new Command(o => OpenProtocolMethod());
            this.contentPage = contentPage;
        }

        private async void OpenProtocolMethod()
        {
            await contentPage.Navigation.PushAsync(new ProtocolMethodOverviewPage(this));
        }
        public Protocol Model { get => model; set => model = value; }
        public ICommand OpenProtocolCommand { get => method; set => method = value; }
    }
}
