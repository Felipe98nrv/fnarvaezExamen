using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fnarvaezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(DatePicker fecha,Entry txtNomb,Entry txtApe,Entry txtEdad,Picker pkCiudad,Picker pkPais,Entry monto,Entry pagom)
        {
            InitializeComponent();
            txtNom.Text = txtNomb.ToString();
            txtApellido.Text=txtApe.ToString();
            txtEdadent.Text=txtEdad.ToString();
            txtCiudad.Text=pkCiudad.ToString();
            txtPais.Text=pkPais.ToString();

            txtMonto.Text=monto.ToString();
            txtFecha.Text = fecha.ToString();
            txtTotal.Text=pagom.ToString();
        }
    }
}