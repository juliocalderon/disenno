using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Progra_Clases;

namespace WebApplication6.Progra_Clases
{
    interface ReadOnlyProducto_Especifico
    {
        int getPreciounitario();
        String getNombre();
        String getDescripcionEspecifica();
        String getImagen();
    }
}