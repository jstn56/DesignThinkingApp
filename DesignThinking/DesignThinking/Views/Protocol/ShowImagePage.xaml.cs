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
    public partial class ShowImagePage : ContentPage
    {
        public ShowImagePage(BaseViewModel parent)
        {
            InitializeComponent();
            BindingContext = new ShowImageViewModel(this, parent) { Parent = parent };
        }
    }
}