using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Centralita
    {
        #region ATRIBUTOS

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region CONSTRUCTOR

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region PROPIEDADES

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region METODOS

        private float CalcularGanancia(TipoLlamada tipo)
        {
            if (tipo.Equals("Local"))
            {
    
                foreach (Llamada llamada in listaDeLlamadas)
                {
                       
                }
            }
            return (float)2;
        }

        #endregion

    }
}
