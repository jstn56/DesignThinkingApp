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
    public partial class CreateTaskPage : ContentPage
    {
        public CreateTaskPage(BaseViewModel parent)
        {
            InitializeComponent();
            var viewModel = new CreateTaskViewModel(this);
            viewModel.Parent = parent;
            BindingContext = viewModel;
        }
    }
}
