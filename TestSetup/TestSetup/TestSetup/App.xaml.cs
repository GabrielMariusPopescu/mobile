using System;
using TestSetup.Services;
using TestSetup.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSetup
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
