using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Producto
    {
        private String categoria;
        private String nombre;
        private String descripcion;

        public Producto(String cate, String nomb, String descrip)
        {
            this.categoria = cate;
            this.descripcion = descrip;
            this.nombre = nomb;
        }
        
        public void AgregarProducto(String cate, String nomb, String descrip)
        {
            Producto nuevoproducto = new Producto(cate, nomb, descrip);
            Globales.listaproducto.Add(nuevoproducto);
        } 

        public String getCategoria()
        {
            return categoria;
        }

        public void setCategoria(String categoria)
        {
            this.categoria = categoria;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }          
    }
}