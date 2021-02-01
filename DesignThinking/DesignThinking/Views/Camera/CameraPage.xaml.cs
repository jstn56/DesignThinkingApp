using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            InitializeComponent();
            BindingContext = new CameraViewModel();
        }
    }
}