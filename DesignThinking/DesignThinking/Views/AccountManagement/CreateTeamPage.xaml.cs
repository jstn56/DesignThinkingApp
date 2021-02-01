using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class CreateTeamPage : ContentPage
    {
        public CreateTeamPage()
        {
            InitializeComponent();
            BindingContext = new CreateTeamViewModel(this);
        }

        void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }
    }
}