using System;
using System.Windows.Input;
using DesignThinking.Models;
using DesignThinking.Views;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class ProtocolMethodViewModel : BaseViewModel
    {
        private ProtocolMethod model;
        private ICommand method;
        private ContentPage contentPage;

        public ProtocolMethodViewModel(ProtocolMethod model, ContentPage contentPage)
        {
            this.model = model;
            method = new Command(o => OpenProtocolMethod());
            this.contentPage = contentPage;
        }

        private async void OpenProtocolMethod()
        {
            await contentPage.Navigation.PushAsync(new ShowProtocolMethodPage(model, this));
        }

        public ProtocolMethod Model { get => model; set => model = value; }
        public ICommand OpenProtocolMethodCommand { get => method; set => method = value; }
    }
}
