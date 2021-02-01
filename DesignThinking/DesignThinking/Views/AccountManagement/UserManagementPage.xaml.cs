using DesignThinking.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views
{
    public partial class UserManagementPage : ContentPage
    {
        public UserManagementPage(BaseViewModel baseViewModel)
        {
            InitializeComponent();
            BindingContext = new UserManagementViewModel(this) { Parent = baseViewModel};
        }
    }
}