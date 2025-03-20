using System;
using Checatec.Services;
using Checatec.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Checatec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Definir la página de inicio como LoginPage
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}



