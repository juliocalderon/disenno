using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Progra_Clases
{
    public class Compra
    {

        private List<Producto_Especifico> listaproductos;
        private String fecha;
        private int cantidad;
        private String nombreusuario;
        private String descripcion;
        private int total;
        private String envio;
        private String hora;

        public Compra(List<Producto_Especifico> listcom, String fech, int cant, String nombuser, String descrip, int total, String envio, String hora)
        {

            this.listaproductos = listcom;
            this.fecha = fech;
            this.cantidad = cant;
            this.nombreusuario = nombuser;
            this.descripcion = descrip;
            this.total = total;
            this.envio = envio;
            this.hora = hora;

        }

        public void AgregarCompra(List<Producto_Especifico> listcom, String fech, int cant, String nombuser, String descrip, int total, String envio, String hora)
        {
            Compra nuevacompra = new Compra(listcom,fech,cant,nombuser,descrip,total,envio,hora);
            Globales.lista_compras.Add(nuevacompra);

        }


        public List<Producto_Especifico> getListaproductos()
        {
            return listaproductos;
        }

        public void setListaCarrito(List<Producto_Especifico> Listaproductos)
        {
            this.listaproductos = Listaproductos;
        }

        public String getFecha()
        {
            return fecha;
        }

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public String getNombreusuario()
        {
            return nombreusuario;
        }

        public void setNombreusuario(String nombreusuario)
        {
            this.nombreusuario = nombreusuario;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getTotal()
        {
            return total;
        }

        public void setTotal(int total)
        {
            this.total = total;
        }

        public String getEnvio()
        {
            return envio;
        }

        public void setEnvio(String envio)
        {
            this.envio = envio;
        }

        public String getHora()
        {
            return hora;
        }

        public void setHora(String hora)
        {
            this.hora = hora;
        }

        public void AgregaCarrito()
        {

        }

    }
}