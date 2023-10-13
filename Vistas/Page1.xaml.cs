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
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();
            
          
        }

        private int _Edad = 10;

        public int Edad
        {
            get { return _Edad; }
            set { this._Edad = value; }
        }

        private string _Genero="M";

        public string Genero
        {
            get { return _Genero; }
            set { this._Genero = value; }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

           // DisplayAlert("Hola mundo", "Hola", "Holaa");



            if (this.Edad > 10 && this.Genero.Equals("M"))
            {
                Navigation.PushAsync(new EncuestaFutbol());
               
            }
            else if (this.Edad > 10 && this.Genero.Equals("F"))
            {
                Navigation.PushAsync(new  EncuestaModa());
                
            }
            else { Navigation.PushAsync(new EncuestaCaricatura()); }
        }
    }
}