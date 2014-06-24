using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebApplication6.Progra_Clases
{
    public static class Globales
    {   
        
        public static List<Producto> listaproducto = new List<Producto>();
        public static List<Producto_Especifico> lista_Producto_Especifico = new List<Producto_Especifico>(); 
        public static List<Producto_Carrito> lista_Producto_Carrito = new List<Producto_Carrito>();
        public static List<Carrito> listacarrito = new List<Carrito>();
        public static List<Usuario> listausuario = new List<Usuario>();
        public static List<Promociones> listapromociones = new List<Promociones>() ;
        public static List<Inventario> listainventario = new List<Inventario>();
        public static List<Compra> lista_compras = new List<Compra>();
        public static Table TablaProductos = new Table();
        public static Table TablaPromos = new Table();
        public static Table TablaCarrito = new Table();
        public static Table TablaHistorial = new Table();
        public static bool tablaInicializada = false;
        public static bool categoriasCargadas = false;
        public static bool productoscargadosprecios = false;
        public static bool productoscargadospromociones = false;
        public static String usuarioLogeado = "";

    }
}