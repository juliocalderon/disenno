using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Progra_Clases;

namespace WebApplication6
{
    public partial class checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            meter_historial();
            panelhistorial1.Controls.Add(Globales.TablaHistorial);
        }

        private void meter_historial()
        {
            if (Globales.tablaInicializada == false)
            {
                for (int i = 0; i < Globales.lista_Producto_Especifico.Count; i++)
                {
                    /*ReadOnlyProducto_Especifico productoRead = (ReadOnlyProducto_Especifico)Globales.lista_Producto_Especifico[i];
                    TableCell imagen = new TableCell();
                    TableCell nombre = new TableCell();
                    TableCell agrega = new TableCell();
                    TableCell descrip = new TableCell();
                    TableCell cantidad = new TableCell();
                    TableRow producto = new TableRow();

                    Image imagenproductos = new Image();
                    imagenproductos.ImageUrl = productoRead.getImagen();
                    imagenproductos.Attributes["class"] = "item-image";

                    TextBox canti = new TextBox();
                    canti.ID = productoRead.getNombre() + 1;

                    Button mibotoncompras = new Button();
                    mibotoncompras.CssClass = "item-add-btn icon-cart-text";
                    mibotoncompras.ID = productoRead.getNombre();
                    mibotoncompras.Attributes["Value1"] = "Carrito.aspx?key=" + productoRead.getNombre();
                    //mibotonproductos.Click += ver_produc;
                    mibotoncompras.Text = "Comprar";
                    mibotoncompras.Attributes["onclick"] = "redireccion(this)";

                    Label nombreproducto = new Label();
                    nombreproducto.Text = productoRead.getNombre();
                    Label descripcion = new Label();
                    descripcion.Text = productoRead.getDescripcionEspecifica();

                    producto.Attributes["class"] = "item-meta-container";
                    imagen.Attributes["class"] = "item-name";
                    nombre.Attributes["class"] = "item-name";
                    agrega.Attributes["class"] = "item-name";
                    descrip.Attributes["class"] = "item-name";
                    cantidad.Attributes["class"] = "item-name";
                    imagen.Controls.Add(imagenproductos);
                    nombre.Controls.Add(nombreproducto);
                    descrip.Controls.Add(descripcion);
                    agrega.Controls.Add(mibotoncompras);
                    cantidad.Controls.Add(canti);
                    producto.Attributes["id"] = productoRead.getNombre();
                    producto.Cells.Add(nombre);
                    producto.Cells.Add(descrip);
                    producto.Cells.Add(cantidad);
                    producto.Cells.Add(agrega);
                    producto.Cells.Add(imagen);
                    Globales.lista_Producto_Especifico[i].setenuso(true);
                    Globales.TablaProductos.Rows.Add(producto);*/
                } Globales.tablaInicializada = true;
            }
        }
    }
}