using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Carrito
    {
        private List<Producto_Carrito> listacarrito;
        private String cliente;
        private int total_por_pagar;
        private int subtotal;

        public Carrito(List<Producto_Carrito> listc, String client, int tpp, int subtot)
        {
            this.listacarrito = listc;
            this.cliente = client;
            this.total_por_pagar = tpp;
            this.subtotal = subtot;
        }

        public List<Producto_Carrito> getListaCarrito() {
            return listacarrito;
        }

        public void setListaCarrito(List<Producto_Carrito> ListaCarrito) {
            this.listacarrito = ListaCarrito;
        }

        public String getCliente() {
            return cliente;
        }

        public void setCliente(String cliente) {
            this.cliente = cliente;
        }

        public int getTotalPorPagar()
        {
            return total_por_pagar;
        }

        public void setTotalPorPagar(int total_por_pagar)
        {
            this.total_por_pagar = total_por_pagar;
        }

        public void AgregarCarrito(Producto_Carrito nuevo_producto_carrito)
        {
            listacarrito.Add(nuevo_producto_carrito);
            subtotal = nuevo_producto_carrito.Subtotal();
            total_por_pagar = total_por_pagar + subtotal;
        }

        public void EliminarCarrito(Producto_Carrito nuevo_producto_carrito)
        {
            listacarrito.Remove(nuevo_producto_carrito);
            subtotal = nuevo_producto_carrito.Subtotal();
            total_por_pagar = total_por_pagar + subtotal;
        }

        public void ConsultaCarrito(Producto_Especifico nuevo_producto_carrito)
        {
            for (int i = 0; i < Globales.lista_Producto_Carrito.Count; i++)
            {
                if (Globales.lista_Producto_Carrito[i].getProductoEspecifico() == nuevo_producto_carrito)
                {
                    Globales.lista_Producto_Carrito[i].getProductoEspecifico();
                    Globales.lista_Producto_Carrito[i].getCantidad();
                    Globales.lista_Producto_Carrito[i].getComentario();
                }
            }
        }


    }
}