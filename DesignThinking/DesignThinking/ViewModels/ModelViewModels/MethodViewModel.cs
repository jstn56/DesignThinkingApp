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
    public class MethodViewModel : BaseViewModel
    {
        private Method model;
        private ICommand method;
        private ContentPage currentContentPage;

        public MethodViewModel(Method model, ContentPage contentPage)
        {
            this.model = model;
            method = new Command(o => OpenMethod());
            currentContentPage = contentPage;
            
        }



        private async void OpenMethod()
        {
            await currentContentPage.Navigation.PushAsync(new ShowMethodPage(model));
        }

        public Method Model { get => model; set => model = value; }
        public ICommand MethodCommand { get => method; set => method = value; }
    }
}
