using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Progra_Clases;

namespace WebApplication6
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Producto p1 = new Producto("Queque","Queque","Es un queque");
            Producto p2 = new Producto("Queque","Quequitos","Esto es otro queque");
            Producto p3 = new Producto("Galleta","Cookie","Esto es una galleta");

            Producto_Especifico pe1 = new Producto_Especifico(23, "Esto es un queque con fresas", p1, "Queque de Vainilla", "images/fotos-fondos-reposteria-L-sqVbk5.png",false);
            Producto_Especifico pe2 = new Producto_Especifico(48, "Esto es otro queque", p2, "queque jajajaja", "images/placeholder-d.png",false);
            Producto_Especifico pe3 = new Producto_Especifico(2000, "Esto es una galleta", p3, "Galletas toda", "images/galletas-de-mms.png",false);
            
            Globales.lista_Producto_Especifico.Add(pe1);
            Globales.lista_Producto_Especifico.Add(pe2);
            Globales.lista_Producto_Especifico.Add(pe3);

            Producto_Carrito pc1 = new Producto_Carrito(pe1,"",45);
            Producto_Carrito pc2 = new Producto_Carrito(pe2,"jajaja",80);
            Producto_Carrito pc3 = new Producto_Carrito(pe3, "holis", 35);

            Globales.lista_Producto_Carrito.Add(pc1);
            Globales.lista_Producto_Carrito.Add(pc2);
            Globales.lista_Producto_Carrito.Add(pc3);

            Carrito c1 = new Carrito(Globales.lista_Producto_Carrito,"jacr",400,489);
            Carrito c2 = new Carrito(Globales.lista_Producto_Carrito,"jacr2",400,1000);
            Carrito c3 = new Carrito(Globales.lista_Producto_Carrito,"jajaja",8000,8000000);

            Globales.listacarrito.Add(c1);
            Globales.listacarrito.Add(c2);
            Globales.listacarrito.Add(c3);

            Compra cr1 = new Compra(Globales.lista_Producto_Especifico,"15/11/1992",23,"jacr","holis",89,"por ahí","15:00");
            Compra cr2 = new Compra(Globales.lista_Producto_Especifico, "07/11/1992", 40, "merce", "holis", 39, "por aqui", "5:00");
            Compra cr3 = new Compra(Globales.lista_Producto_Especifico, "30/02/1990", 50, "jacr", "holis",50, "Dios sabe donde", "15:00");

            Globales.lista_compras.Add(cr1);
            Globales.lista_compras.Add(cr2);
            Globales.lista_compras.Add(cr3);

            Usuario u1 = new Usuario("Julio","jacr","jacr","a@a.com","por ahí",1,1,"false","Admin");
            Usuario u2 = new Usuario("Merce","merce","merce","merce@merce.com","por ahí tambien",1,1,"false","Admin");

            Usuario u3 = new Usuario("Julio", "shaka", "jacr", "a@a.com", "por ahí", 1, 1, "false","Cliente");
            Usuario u4 = new Usuario("Julio", "fea", "jacr", "a@a.com", "por ahí", 1, 1, "false","Cliente");

            Globales.listausuario.Add(u1);
            Globales.listausuario.Add(u2);
            Globales.listausuario.Add(u3);
            Globales.listausuario.Add(u4);

            Promociones promo1 = new Promociones("Galletas toda en todas","Tus galletas Favoritas ahorita regaladas",200);

            Globales.listapromociones.Add(promo1);


        }
    }
}