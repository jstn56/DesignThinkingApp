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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateProtocolPage : ContentPage
    {
        public CreateProtocolPage(BaseViewModel parent)
        {
            InitializeComponent();
            var viewModel = new CreateProtocolViewModel(this);
            viewModel.Parent = parent;
            BindingContext = viewModel;
        }
    }
}