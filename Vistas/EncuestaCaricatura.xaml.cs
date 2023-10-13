using CLIENTES.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIENTES.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CLIENTES.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EncuestaCaricatura : ContentPage
    {
        public EncuestaCaricatura()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RESPUESTA());
        }
    }
}