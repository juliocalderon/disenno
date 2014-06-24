using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;
using System.Data.SqlClient;
using WebApplication6.Progra_Clases;
using WebApplication6.bd;


namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresar(object sender, EventArgs e)
        {
            Inserts cargar = new Inserts();
            cargar.llenar_usuarios();
            Usuario uc = Globales.listausuario.Find(x => x.getLogin() == inputnombre.Text);
            if(uc != null){
                for(int i = 0; i < Globales.listausuario.Count; i++){
                    if ((Globales.listausuario[i].getLogin() == inputnombre.Text) && (Globales.listausuario[i].getContra() == inputcontrasenna.Text) && (Globales.listausuario[i].getrol() == "Admin"))
                    {
                        if (Globales.listausuario[i].getlogeado() == "false") { 
                            Server.Transfer("DefaultAdmin.aspx");
                            Globales.listausuario[i].setlogeado("true");
                        }
                        
                    }
                    if ((Globales.listausuario[i].getLogin() == inputnombre.Text) && (Globales.listausuario[i].getContra() == inputcontrasenna.Text) && (Globales.listausuario[i].getrol() == "Cliente"))
                    {
                        if (Globales.listausuario[i].getlogeado() == "false")
                        {
                            Server.Transfer("Default.aspx");
                            Globales.listausuario[i].setlogeado("true");
                        } 
                    }
                }
            }
        }

        protected void registrarme(object sender, EventArgs e)
        {
            Usuario u = new Usuario(inputnombrere.Text,inputnombrelogin.Text,inputconfirmacontra.Text,inputemail.Text,direccion.Text,int.Parse(inputcedula.Text),int.Parse(inputtelefono.Text),"false","Cliente");
            Globales.listausuario.Add(u);
            Inserts nuevou = new Inserts();
            nuevou.insertar_usuario(u);
        }

    }
}