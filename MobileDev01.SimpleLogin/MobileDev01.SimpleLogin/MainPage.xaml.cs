using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileDev01.SimpleLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {
            InitializeComponent();
        }

        async private void OnLoginButtonClick(object sender, EventArgs e) {
            if(usernameEntry.Text == null || usernameEntry.Text.Length == 0) {
                await DisplayAlert("Error: Falta información", "El campo del nombre de usuario no puede estar vacío.", "OK");
                usernameEntry.Focus();
            } else if(passwordEntry.Text == null || passwordEntry.Text.Length == 0) {
                await DisplayAlert("Error: Falta información", "El campo de contraseña no puede estar vacío.", "OK");
                passwordEntry.Focus();
            } else { 
                await DisplayAlert("Bienvenido", $"Hola {usernameEntry.Text}", "Gracias");
            }
        }
    }
}
