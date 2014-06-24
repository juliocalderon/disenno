using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication6.bd;

namespace WebApplication6.bd
{
    public class Conexion
    {
        protected System.Data.SqlClient.SqlConnection conectar;
        protected System.Data.SqlClient.SqlCommand comando;

        public void iniciarConexion()
        {
            conectar = new SqlConnection(@"Data Source=BDDISTRIBUIDAS;Initial Catalog=cestexquisdisenno;Persist Security Info=True;User ID=sa;Password=admin");
            //comando.CommandType = ; 
        }
    }
}