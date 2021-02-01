using System;
using DesignThinking.Business.Service;
using DesignThinking.Models;
using Xamarin.Forms;

namespace DesignThinking
{
    public partial class App : Application
    {
        public static string FilePath;
        private MethodService methodService;

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            Init();
        }


        private void Init()
        {
            
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
