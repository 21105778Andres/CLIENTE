


using Xamarin.Forms;

namespace CLIENTES.VistaModelo
{
    public class VMpatron : BaseViewModel
    {
        #region Variables

        string _Texto;

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion


        #region Constructor
        public VMpatron(INavigation navegation)
        {
            Navigation = navegation;


        }

        #endregion

        #region Objetos


        #endregion

        #region PROCESOS


        #endregion

        #region Comandos



        #endregion

    }
}