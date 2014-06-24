using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Historial_Compra
    {

        private List<Compra> compra;
        private Historial_Compra singleton;

        private Historial_Compra()
        {
            this.compra = new List<Compra>();
        }

        public List<Compra> getCompra()
        {
            return compra;
        }

        public Historial_Compra GetSingleton() 
        {
            if (singleton == null)
            {
                singleton = new Historial_Compra();
            }
            return singleton;
        }

    }
}