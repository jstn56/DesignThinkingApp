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
    public partial class ShowTaskPage : ContentPage
    {
        public ShowTaskPage(Models.Task model, BaseViewModel parent)
        {
            InitializeComponent();
            var viewModel = new ShowTaskViewModel(this, model);
            viewModel.Parent = parent;
            BindingContext = viewModel;
        }
    }
}
