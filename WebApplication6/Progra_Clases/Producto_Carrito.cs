using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Producto_Carrito
    {

        private Producto_Especifico lproducto;
        private String comentario;
        private int cantidad;
        private int precio;
        private int subtotal;

        public Producto_Carrito(Producto_Especifico produ, String coment, int cant)
        {
            this.lproducto = produ;
            this.comentario = coment;
            this.cantidad = cant;
        }

        public void AgregarProductoCarrito(Producto_Especifico productos)
        {
            lproducto = productos;
        }
        public Producto_Especifico getProductoEspecifico() {
            return lproducto;
        }

        public void setProductoEspecifico(Producto_Especifico pe){
            this.lproducto = pe;
        }
        
        public int Subtotal()
        {
            precio = lproducto.getPreciounitario();
            subtotal = precio * cantidad;
            return subtotal;
        }

        public void modificar(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public Producto_Especifico getProducto()
        {
            return lproducto;
        }

        public void setProducto(Producto_Especifico producto)
        {
            this.lproducto = producto;
        }

        public String getComentario()
        {
            return comentario;
        }

        public void setComentario(String comentario)
        {
            this.comentario = comentario;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }    

    }
}