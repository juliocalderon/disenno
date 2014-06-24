using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Progra_Clases;

namespace WebApplication6
{
    public partial class Promos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            meter_promos();
            panelpromos1.Controls.Add(Globales.TablaPromos);
        }

        private void meter_promos()
        {
            if (Globales.tablaInicializada == false)
            {
                for (int i = 0; i < Globales.listapromociones.Count; i++)
                {
                    TableCell nombre = new TableCell();
                    TableCell descrip = new TableCell();
                    TableCell precio = new TableCell();
                    TableCell agrega = new TableCell();
                    TableRow promo = new TableRow();

                    Button mibotonpromo = new Button();
                    mibotonpromo.CssClass = "item-add-btn icon-cart-text";
                    //mibotoncompras.
                    //mibotonproductos.Click += ver_produc;
                    mibotonpromo.Text = "Agregar";

                    Label nombrepromo = new Label();
                    nombrepromo.Text = Globales.listapromociones[i].getNombre();
                    Label descripcion = new Label();
                    descripcion.Text = Globales.listapromociones[i].getDescripcionpromo();
                    Label preciopromo = new Label();
                    preciopromo.Text = Globales.listapromociones[i].getPreciopromo().ToString();

                    promo.Attributes["class"] = "item-meta-container";
                    nombre.Attributes["class"] = "item-name";
                    descrip.Attributes["class"] = "item-name";
                    precio.Attributes["class"] = "item-name";
                    agrega.Attributes["class"] = "item-name";
                    nombre.Controls.Add(nombrepromo);
                    descrip.Controls.Add(descripcion);
                    precio.Controls.Add(preciopromo);
                    agrega.Controls.Add(mibotonpromo);
                    promo.Attributes["id"] = Globales.listapromociones[i].getNombre();
                    promo.Cells.Add(nombre);
                    promo.Cells.Add(descrip);
                    promo.Cells.Add(precio);
                    promo.Cells.Add(agrega);
                    Globales.TablaPromos.Rows.Add(promo);
                }
            }
        }

    }
}
