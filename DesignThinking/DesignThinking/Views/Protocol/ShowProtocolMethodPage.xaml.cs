using DesignThinking.Models;
using DesignThinking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class ShowProtocolMethodPage : ContentPage
    {
        public ShowProtocolMethodPage(ProtocolMethod model, BaseViewModel parent)
        {
            InitializeComponent();
            var viewModel = new ShowProtocolMethodViewModel(this, model);
            viewModel.Parent = parent;
            BindingContext = viewModel;
        }
    }
}
