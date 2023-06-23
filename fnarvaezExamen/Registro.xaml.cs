using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fnarvaezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        
        public Registro(string user)
        {
            InitializeComponent();
            userconect.Text = "usuario conectado: " + user;
            

        }

        private void fecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            int valorInicial= 1500;
            
         
                double valor = Convert.ToDouble(monto.Text);
                double respt = (valorInicial - valor) / 4;
                double porcentaje = 0.4;
                double porce = (respt * porcentaje) + respt;
               pagom.Text=porce.ToString();
            
                


        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(fecha,txtNomb,txtApe,txtEdad,pkCiudad,pkPais,monto,pagom));
        }
    }
}