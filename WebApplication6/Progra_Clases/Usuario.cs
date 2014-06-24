using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Usuario
    {

        private String nombre;
        private String login;
        private String contrasenna;
        private String correo;
        private String direccion;
        private int cedula;
        private int telefono;
        private String log;
        private String rol;

        public Usuario(String nombre, String login, String contra,String correo, String dirrec, int ced, int tel, String log, String rol )
        {

            this.nombre = nombre;
            this.login = login;
            this.contrasenna = contra;
            this.correo = correo;
            this.direccion = dirrec;
            this.cedula = ced;
            this.telefono = tel;
            this.log = log;
            this.rol = rol;

        }

        public String getNombre() {
                return nombre;
        }
         
        public void setNombre(String nombre){
                this.nombre = nombre;
        }


        public String getLogin(){
            return login;
        }

        public void setLogin(String login){
            this.login = login;
        }

        public String getContra(){
            return contrasenna;
        }

        public void setContra(String contra)
        {
            this.contrasenna = contra;
        }

        public String getCorreo(){
            return correo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }


        public String getDirreccion()
        {
            return direccion;
        }
         
        public void setdireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public int getcedula()
        {
            return cedula;
        }

        public void setcedula(int cedula)
        {
            this.cedula = cedula;
        }

        public int gettelefono()
        {
            return telefono;
        }

        public void settelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public String getlogeado() {
            return log;
        }

        public void setlogeado(String login)
        {
            this.log = login;
        }

        public String getrol() {
            return rol;
        }

        public void setrol(String rol) {
            this.rol = rol;
        }
    }
}