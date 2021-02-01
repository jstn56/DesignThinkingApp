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
    public partial class CreateProtocolMethodPage : ContentPage
    {
        public CreateProtocolMethodPage(BaseViewModel parent)
        {
            InitializeComponent();
            var viewModel = new CreateProtocolMethodViewModel(this) { Parent = parent };
            viewModel.Parent = parent;
            BindingContext = viewModel;
        }
      
    }
}
