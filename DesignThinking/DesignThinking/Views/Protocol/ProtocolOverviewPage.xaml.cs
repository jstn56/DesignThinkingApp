using DesignThinking.ViewModels;
using DesignThinking.ViewModels.ProtocolViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views.Protocol
{
    public partial class ProtocolOverviewPage : ContentPage
    {
        private ProtocolOverviewViewModel viewModel;
        public ProtocolOverviewPage(BaseViewModel parent)
        {
            InitializeComponent();
            viewModel = new ProtocolOverviewViewModel(this) { Parent = parent };
            BindingContext = viewModel;
        }
        public ProtocolOverviewPage()
        {
            InitializeComponent();
            viewModel = new ProtocolOverviewViewModel(this) { Parent = null };
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