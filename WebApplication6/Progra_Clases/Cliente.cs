using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Cliente:Rol
    {

        public void AgregarCarrito(Producto_Especifico p,String comentario, int cantidad,String cliente) {
            Producto_Carrito pc = new Producto_Carrito(p,comentario,cantidad);
            Globales.lista_Producto_Carrito.Add(pc);
            Carrito c = new Carrito(Globales.lista_Producto_Carrito,cliente,400,400);
            Globales.listacarrito.Add(c);
            Globales.lista_Producto_Carrito.Remove(pc);
        }

        public override void Eliminar_Producto(String nombre, String categoria) // Sacar del carrito
        {
            for(int j = 0; j < Globales.lista_Producto_Carrito.Count; j ++){
                if(Globales.lista_Producto_Carrito[j].getProducto().getnombre() == nombre){
                    Globales.lista_Producto_Carrito.Remove(Globales.lista_Producto_Carrito[j]);
                }
            }
        }

        public void ModificarCarrito(Producto_Especifico p, int cantidadnueva, String comentarionuevo) {
            for (int i = 0; i < Globales.lista_Producto_Carrito.Count; i++){
                if (Globales.lista_Producto_Carrito[i].getProducto() == p){
                    Globales.lista_Producto_Carrito[i].setCantidad(cantidadnueva);
                    Producto_Carrito pc = new Producto_Carrito(p,comentarionuevo,cantidadnueva);
                    Globales.lista_Producto_Carrito.Add(pc);
                }
            }
        }

        public void ConsultarCarrito(Producto_Especifico p){
            for (int i = 0; i < Globales.lista_Producto_Carrito.Count; i++){
                if(Globales.lista_Producto_Carrito[i].getProducto() == p){
                    Globales.lista_Producto_Carrito[i].getProducto();
                    Globales.lista_Producto_Carrito[i].getComentario();
                    Globales.lista_Producto_Carrito[i].getCantidad();
                }
            }
        }

        public void ConsultarPromocion(String nombre) {
            for (int i = 0; i < Globales.listapromociones.Count; i++) { 
                if(Globales.listapromociones[i].getNombre() == nombre){
                    Globales.listapromociones[i].getNombre();
                    Globales.listapromociones[i].getDescripcionpromo();
                    Globales.listapromociones[i].getPreciopromo();
                }
            }
        }

    }
}