using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class ShowTeamPage : ContentPage
    {
        public ShowTeamPage()
        {
            InitializeComponent();
            BindingContext = new ShowTeamViewModel(this);
        }
    }
}