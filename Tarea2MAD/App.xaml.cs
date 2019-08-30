using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea2MAD.Views;

namespace Tarea2MAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage()) { BarBackgroundColor = Color.FromHex("ffaec8") };
            


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
