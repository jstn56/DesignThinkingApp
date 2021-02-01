using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DesignThinking.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
        public CameraViewModel()
        {
            Title = "Kamera/Galerie";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}