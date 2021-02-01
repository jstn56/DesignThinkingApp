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
    public partial class LRFirstPage : ContentPage
    {
        public LRFirstPage()
        {
            InitializeComponent();
            BindingContext = new LRFirstViewModel(this);
        }
    }
}