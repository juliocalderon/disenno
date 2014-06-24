using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Promociones
    {
        private String nombre;
        private String descripcionpromo;
        private int preciopromo;
        public Promociones(String nomb, String descriprom, int pp)
        {
            this.nombre = nomb;
            this.descripcionpromo = descriprom;
            this.preciopromo = pp;
        }

        public void AgregarPromo(String nombrepromo, String descripcionpromo, int preciopromo) 
        {
            Promociones promonueva = new Promociones(nombrepromo,descripcionpromo,preciopromo);
            Globales.listapromociones.Add(promonueva);
        }

        public void EliminarPromo(String nombrepromo) 
        {
            for (int i = 0; i < Globales.listapromociones.Count; i++) 
            {
                if(Globales.listapromociones[i].getNombre() == nombrepromo)
                {
                    Globales.listapromociones.Remove(Globales.listapromociones[i]);
                }
            }
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getDescripcionpromo()
        {
            return descripcionpromo;
        }

        public void setDescripcionpromo(String descripcionpromo)
        {
            this.descripcionpromo = descripcionpromo;
        }

        public int getPreciopromo()
        {
            return preciopromo;
        }

        public void setPreciopromo(int preciopromo)
        {
            this.preciopromo = preciopromo;
        }

        

    }
}