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

        private void LoginButton_Clicked(object sender, EventArgs e) {
            if(UserName.Text.Length == 0) {
                DisplayAlert("Error: Falta información", "El campo del nombre de usuario no puede estar vacío.", "OK");
                UserName.Focus();
            } else if(Password.Text.Length == 0) {
                DisplayAlert("Error: Falta información", "El campo de contraseña no puede estar vacío.", "OK");
                Password.Focus();
            } else { 
                DisplayAlert("Bienvenido", $"Hola {UserName.Text}", "Gracias");
            }
        }
    }
}
