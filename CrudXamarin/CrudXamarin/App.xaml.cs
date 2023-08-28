using CrudXamarin.Services;
using CrudXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage (new HomePage());
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
