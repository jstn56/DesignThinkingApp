using DesignThinking.Base;
using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProtocolMethodOverviewPage : ContentPage
    {
        private ProtocolMethodOverviewViewModel viewModel;
        public ProtocolMethodOverviewPage(BaseViewModel parent)
        {
            InitializeComponent();
            viewModel= new ProtocolMethodOverviewViewModel(this) { Parent = parent };
            BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
            if (viewModel != null)
            {
                viewModel.OnPropertyChanged(nameof(viewModel.VisibleError));
                viewModel.OnPropertyChanged(nameof(viewModel.Visible));
                viewModel.RefreshList();
            }
        }

       
    }
}