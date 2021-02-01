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
    public partial class IRSecondPage : ContentPage
    {
        public IRSecondPage()
        {
            InitializeComponent();
            BindingContext = new IRSecondViewModel(this);
        }
    }
}