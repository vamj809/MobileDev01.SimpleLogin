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
                DisplayAlert("Error: Falta información", "Debe llenar todos los campos.", "OK");
                UserName.Focus();
            } else if(Password.Text.Length == 0) {
                DisplayAlert("Error!", "Debe llenar todos los campos.", "OK");
                Password.Focus();
            } else { 
                DisplayAlert("¡Proceso Exitoso!", $"¡Bienvenido {UserName.Text}!", "Gracias");
            }
        }
    }
}
