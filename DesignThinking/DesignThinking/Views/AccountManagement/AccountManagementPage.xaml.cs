using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class AccountManagementPage : ContentPage
    {
        public AccountManagementPage()
        {
            InitializeComponent();
            BindingContext = new AccountManagementViewModel(this);
        }
    }
}