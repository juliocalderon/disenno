using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Administrador:Rol
    {
       
        public void AgregarProducto(String categoria, String nombre, String descripcion)
        {
            Producto p = new Producto(categoria, nombre, descripcion);
            Globales.listaproducto.Add(p);
        }

        public override void Eliminar_Producto(String nombre, String categoria)
        {
            for (int i = 0; i < Globales.listaproducto.Count; i++) {
                if((Globales.listaproducto[i].getNombre() == nombre)&&(Globales.listaproducto[i].getCategoria() == categoria)){
                    Globales.listaproducto.Remove(Globales.listaproducto[i]);
                }
            }
        }

        public void ModificarProducto(String nombre, String categoria, String nombre2, String categoria2, String descripcion)
        {
            for (int i = 0; i < Globales.listaproducto.Count; i++)
            {
                if ((Globales.listaproducto[i].getNombre() == nombre) && (Globales.listaproducto[i].getCategoria() == categoria))
                {
                    Globales.listaproducto[i].setNombre(nombre2);
                    Globales.listaproducto[i].setCategoria(categoria2);
                    Globales.listaproducto[i].setDescripcion(descripcion);
                }
            }
        }

        public void ConsultaProducto(String nombre, String categoria)
        {
            for (int i = 0; i < Globales.listaproducto.Count; i++)
            {
                if((Globales.listaproducto[i].getNombre() == nombre)&&(Globales.listaproducto[i].getCategoria() == categoria))
                {
                    Globales.listaproducto[i].getNombre();
                    Globales.listaproducto[i].getCategoria();
                    Globales.listaproducto[i].getDescripcion();
                }
            }
        }

        public void AgregaInventario(Producto_Especifico item, int existencia)
        {
            Inventario i = new Inventario(item,existencia);
            Globales.listainventario.Add(i);
        }

        public void EliminarInventario(Producto_Especifico item)
        {
            int existencia = 0;
            Inventario i = new Inventario(item, existencia);
            Globales.listainventario.Remove(i);
        }

        public void ModificarInventario(Producto_Especifico item, int existencia2)
        {
            for (int i = 0; i < Globales.listainventario.Count; i++)
            { 
                if(Globales.listainventario[i].getItem() == item)
                {
                    Globales.listainventario[i].setExistencia(existencia2);
                }
            }
        }

        public void ConsultarInventario(Producto_Especifico item) 
        {
            for (int i = 0; i < Globales.listainventario.Count; i++) 
            { 
                if(Globales.listainventario[i].getItem() == item)
                {
                    Globales.listainventario[i].getItem();
                    Globales.listainventario[i].getExistencia();
                }
            }
        }


    }
}