using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class DefaultAdmin2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ModificarProductos(object sender, EventArgs e)
        {
            Server.Transfer("ModificarProductos.aspx");
        }

        protected void AdministrarInventario(object sender, EventArgs e)
        {
            Server.Transfer("ModificarInventario.aspx");
        }

        protected void AdministrarPromociones(object sender, EventArgs e)
        {
            Server.Transfer("ModificarPromos.aspx");
        }

        protected void AdministrarUsuarios(object sender, EventArgs e) {
            Server.Transfer("login-registro.aspx");
        }
    }
}