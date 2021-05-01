using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NunezJefferson_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblTexto.Text = "Usuario conectado: " + usuario;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;


            try
            {
                double pagoinicial = Convert.ToDouble(txtMontoinicial.Text);
                double montomensual = Convert.ToDouble(txtPagoMensual.Text);

                double cuota = ((montomensual + 90) * 3) + pagoinicial;
                txtPagoMensual.Text = cuota.ToString();


                await DisplayAlert("Alerta", "Elemento Guardado con Exito", "Aceptar");
                await Navigation.PushAsync(new Resumen(txtNombre.Text, txtPagoMensual.Text));


            }
            catch (Exception ex)
            {
                await DisplayAlert("Aviso", "Ingrese los datos", "Aceptar");
            }

        }
    }


}