using DesignThinking.Base;
using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class ProjectPage : ContentPage
    {
        private ProjectViewModel viewModel;
        public ProjectPage()
        {
            InitializeComponent();
            viewModel = new ProjectViewModel(this);
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