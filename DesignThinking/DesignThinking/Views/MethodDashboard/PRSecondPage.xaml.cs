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
    public partial class PRSecondPage : ContentPage
    {
        public PRSecondPage()
        {
            InitializeComponent();
            BindingContext = new PRSecondViewModel(this);
        }
    }
}