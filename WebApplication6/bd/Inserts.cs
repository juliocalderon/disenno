using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using WebApplication6.bd;
using WebApplication6.Progra_Clases;

namespace WebApplication6.bd
{
    public class Inserts : Conexion
    {
        public void insertar_usuario(Usuario u)
        {
            iniciarConexion();
            //comando.CommandType = System.Data.CommandType.Text;
            String a = @"Insert Into USUARIO (NOMBRE, CEDULA, DIRRECCION, TELEFONO, CONTRASENNA, LOGI, CORREO_ELECTRONIO, logeado, rol) 
            Values (@nombre, @cedula, @direccion, @telefono, @contrasenna, @login, @correo, @logeado, @rol)";
            comando = new SqlCommand(a, conectar);
            comando.Parameters.AddWithValue("@login", u.getLogin());
            comando.Parameters.AddWithValue("@cedula", u.getcedula());
            comando.Parameters.AddWithValue("@direccion", u.getDirreccion());
            comando.Parameters.AddWithValue("@telefono", u.gettelefono());
            comando.Parameters.AddWithValue("@contrasenna", u.getContra());
            comando.Parameters.AddWithValue("@nombre", u.getNombre());
            comando.Parameters.AddWithValue("@correo", u.getCorreo());
            comando.Parameters.AddWithValue("@logeado", "false");
            comando.Parameters.AddWithValue("@rol", "Cliente");

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
        }

        public void insertar_usuario2(Usuario u)
        {
            iniciarConexion();
            //comando.CommandType = System.Data.CommandType.Text;
            String a = @"Insert Into USUARIO (NOMBRE, CEDULA, DIRRECCION, TELEFONO, CONTRASENNA, LOGI, CORREO_ELECTRONIO, logeado, rol) 
            Values (@nombre, @cedula, @direccion, @telefono, @contrasenna, @login, @correo, @logeado, @rol)";
            comando = new SqlCommand(a, conectar);
            comando.Parameters.AddWithValue("@login", u.getLogin());
            comando.Parameters.AddWithValue("@cedula", u.getcedula());
            comando.Parameters.AddWithValue("@direccion", u.getDirreccion());
            comando.Parameters.AddWithValue("@telefono", u.gettelefono());
            comando.Parameters.AddWithValue("@contrasenna", u.getContra());
            comando.Parameters.AddWithValue("@nombre", u.getNombre());
            comando.Parameters.AddWithValue("@correo", u.getCorreo());
            comando.Parameters.AddWithValue("@logeado", "false");
            comando.Parameters.AddWithValue("@rol", "Admin");

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
        }

        public void insertarproducto(Producto p)
        {
            iniciarConexion();
            String a = @"Insert Into PRODUCTO (CATEGORIA,NOMBRE,DESCRIPCION) 
            Values (@categoria, @nombre, @descripcion)";
            comando = new SqlCommand(a, conectar);
            comando.Parameters.AddWithValue("@categoria", p.getCategoria());
            comando.Parameters.AddWithValue("@nombre", p.getNombre());
            comando.Parameters.AddWithValue("@descripcion", p.getDescripcion());

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
        }

        public void insertarptoductoespecifico(Producto_Especifico pe) {
            iniciarConexion();
            String a = @"Insert Into PRODUCTO_ESPECIFICO(PRECIOUNITARIO,DESCRIPCIONESPECIFICO,NOMBRE) 
            Values (@preciounitario, @descripcionespecifico, @nombre)";
            comando = new SqlCommand(a, conectar);
            comando.Parameters.AddWithValue("@preciounitario", pe.getPreciounitario());
            comando.Parameters.AddWithValue("@descripcionespecifico", pe.getDescripcionespecífica());
            comando.Parameters.AddWithValue("@nombre", pe.getnombre());

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
        }

        public void insertarinventario() {
            iniciarConexion();
            String a = @"Insert Into PRODUCTO_ESPECIFICO(PRECIOUNITARIO,DESCRIPCIONESPECIFICO,NOMBRE) 
            Values (@preciounitario, @descripcionespecifico, @nombre)";

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
        }

        public void insertacompra() { 
            
        }

        public void insertahistorialcompra() { 
        
        }

        public void llenar_usuarios()
        {
            iniciarConexion();
            string consulta = @"SELECT * FROM USUARIO";
            comando = new SqlCommand(consulta, conectar);
            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                String usuario = (reader["LOGI"]).ToString();
                String contrasena = (reader["CONTRASENNA"]).ToString();
                String nombre = (reader["NOMBRE"]).ToString();
                String correo = (reader["CORREO_ELECTRONIO"]).ToString();
                String direccion = (reader["DIRRECCION"]).ToString();
                int telefono = Convert.ToInt32(reader["TELEFONO"]);
                int cedula = Convert.ToInt32(reader["CEDULA"]);
                String logueado = (reader["logeado"]).ToString();
                String rol = (reader["rol"]).ToString();
                Usuario u = new Usuario(nombre,usuario,contrasena,correo,direccion,cedula,telefono,logueado,rol);
                Globales.listausuario.Add(u);
            }
        }

    }
}