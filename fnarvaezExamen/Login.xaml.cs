using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fnarvaezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngr_Clicked(object sender, EventArgs e)
        {
            string user = "estudiante2023";
            string password = "uisrael2023";

            if (txtuser.Text == user && txtpassword.Text == password)
            {
                Navigation.PushAsync(new Registro(user));
                
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contrasena incorrectos", "Cerrar");

            }
        }
    }
}