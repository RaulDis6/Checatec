using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checatec.ViewModels;
using Checatec.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Checatec.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string usuario = entryUsuario?.Text;
            string password = entryPassword?.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Por favor, ingresa usuario y contraseña.", "OK");
                return;
            }

            if (usuario == "admin" && password == "1234")
            {
                await DisplayAlert("Éxito", "Inicio de sesión correcto.", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
            }
        }

        private async void OnRecuperarContrasenaTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Recuperar Contraseña", "Funcionalidad en desarrollo.", "OK");
        }

        private async void OnAyudaTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Ayuda", "Aquí puedes obtener asistencia.", "OK");
        }
    }
}