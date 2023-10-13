using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;


namespace CLIENTES.VistaModelo
{
     public class VMpag1:BaseViewModel
    {
        #region VARIABLES
        private string _Texto;

        #endregion

        #region Constructor
        public VMpag1(INavigation navegation)
        {
            Navigation = navegation;
            

        }

        #endregion

        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        #endregion

        #region PROCESOS
        public async Task ProcesosAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region Comandos

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

        #endregion
    }
}
