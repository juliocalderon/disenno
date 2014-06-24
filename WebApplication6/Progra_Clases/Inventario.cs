using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Inventario
    {

        private Producto_Especifico item;
        private int existencia;

        public Inventario(Producto_Especifico it, int exist)
        {
            this.item = it;
            this.existencia = exist;
        }

        public void AgregarInventario(int preciounitario, String descripcionproducespecifico, String cate, String nomb, String descrip, int existencia, String nombre, String imagen)
        {
            Producto nuevoproducto = new Producto(cate, nomb, descrip);
            Producto_Especifico nuevoproductoespecifico = new Producto_Especifico(preciounitario, descripcionproducespecifico, nuevoproducto, nombre,imagen,false);
            Globales.lista_Producto_Especifico.Add(nuevoproductoespecifico);
            Inventario nuevo_inventario = new Inventario(nuevoproductoespecifico, existencia);
            Globales.listainventario.Add(nuevo_inventario);
        }

        public Producto_Especifico getItem()
        {
            return item;
        }

        public void setItem(Producto_Especifico item)
        {
            this.item = item;
        }

        public int getExistencia()
        {
            return existencia;
        }

        public void setExistencia(int existencia)
        {
            this.existencia = existencia;
        }

    }
}