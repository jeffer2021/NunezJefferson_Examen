using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NunezJefferson_Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtPass.Text;

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                await DisplayAlert("Aviso", "Debe ingresar un usuario", "Aceptar");
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                await DisplayAlert("Aviso", "Debe ingresar una contraseña", "Aceptar");
                txtPass.Focus();
                return;
            }
            else
            {
                if ((usuario == "estudiante2021") && (contraseña == "uisrael2021"))
                {
                    await Navigation.PushAsync(new Registro(txtUser.Text));
                }
                else
                {
                    lblResultado.Text = "El usuario o contraseña son incorrectos";
                }
            }
        }
    }
}
