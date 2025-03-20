using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Checatec.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Regresa al LoginPage
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
