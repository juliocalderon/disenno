using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Progra_Clases;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String productopasa = Convert.ToString(Request.QueryString["key"]);
            mete_carrito(productopasa);
            panelcarrito.Controls.Add(Globales.TablaCarrito);
        }

        private void mete_carrito(string productopasa)
        {
            if (Globales.tablaInicializada == false)
            {
                for (int i = 0; i < Globales.lista_Producto_Especifico.Count; i++)
                {
                    if(productopasa.ToString() == Globales.lista_Producto_Especifico[i].getnombre()){
                        int sub = 0;
                        TableCell imagen = new TableCell();
                        TableCell nombre = new TableCell();
                        TableCell preciounitario = new TableCell();
                        TableCell subtotal = new TableCell();
                        TableCell cantidad = new TableCell();
                        TableCell descrip = new TableCell();
                        TableRow producto = new TableRow();

                        Image imagenproductos = new Image();
                        imagenproductos.ImageUrl = Globales.lista_Producto_Especifico[i].getimagen();
                        imagenproductos.Attributes["class"] = "item-image";

                        TextBox cant = new TextBox();
                        cant.Text = "0";
                        cant.ID = "" + Globales.lista_Producto_Especifico[i].getPreciounitario();

                        LinkButton mibotoncompras = new LinkButton();
                        mibotoncompras.ID = "" + Globales.lista_Producto_Especifico[i].getPreciounitario();
                        mibotoncompras.CssClass = "item-add-btn icon-cart-text";
                        //mibotonproductos.Click += ver_produc;
                        mibotoncompras.Text = "Comprar";

                        Label nombreproducto = new Label();
                        nombreproducto.Text = Globales.lista_Producto_Especifico[i].getnombre();
                        Label descripcion = new Label();
                        descripcion.Text = Globales.lista_Producto_Especifico[i].getDescripcionespecífica();
                        Label preciounitarioprod = new Label();
                        preciounitarioprod.Text = Globales.lista_Producto_Especifico[i].getPreciounitario().ToString();
                        Label subtotalp = new Label();
                        subtotalp.Text = sub.ToString();

                        producto.Attributes["class"] = "item-meta-container";
                        imagen.Attributes["class"] = "item-name";
                        nombre.Attributes["class"] = "item-name";
                        cantidad.Attributes["class"] = "item-name";
                        descrip.Attributes["class"] = "item-name";
                        preciounitario.Attributes["class"] = "item-name";
                        subtotal.Attributes["class"] = "item-name";
                        imagen.Controls.Add(imagenproductos);
                        nombre.Controls.Add(nombreproducto);
                        descrip.Controls.Add(descripcion);
                        cantidad.Controls.Add(cant);
                        preciounitario.Controls.Add(preciounitarioprod);
                        subtotal.Controls.Add(subtotalp);
                        producto.Attributes["id"] = Globales.lista_Producto_Especifico[i].getnombre();
                        producto.Cells.Add(nombre);
                        producto.Cells.Add(descrip);
                        producto.Cells.Add(preciounitario);
                        producto.Cells.Add(cantidad);
                        producto.Cells.Add(subtotal);
                        producto.Cells.Add(imagen);
                        Globales.TablaCarrito.Rows.Add(producto);
                    }
                }
            }
        }


    }
}