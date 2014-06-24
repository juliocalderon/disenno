using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Progra_Clases;

namespace WebApplication6.Progra_Clases
{
    public class Producto_Especifico: ReadOnlyProducto_Especifico
    {

        private int preciounitario;
        private String descripcionespecífica;
        private Producto producto;
        private String nombre;
        private String imagen;
        private Boolean enuso;

        public Producto_Especifico(int preciou, String descripespe, Producto producto, String nombre, String imagen, Boolean enuso)
        {
            this.preciounitario = preciou;
            this.descripcionespecífica = descripespe;
            this.producto = producto;
            this.nombre = nombre;
            this.imagen = imagen;
            this.enuso = enuso;
        }

        public void AgregarProductoEspecifico(int preciounitario, String descripcionproducespecifico, String cate, String nomb, String descrip, String nombre, String image) 
        {
            Producto nuevoproducto = new Producto(cate, nomb, descrip);
            Producto_Especifico nuevoproductoespecifico = new Producto_Especifico(preciounitario,descripcionproducespecifico,nuevoproducto,nombre,image,false);
            Globales.lista_Producto_Especifico.Add(nuevoproductoespecifico);
        }

        public void GetNombreProducto(Producto productoe) 
        { 
            for (int i = 0; i < Globales.lista_Producto_Especifico.Count; i ++){
                if(Globales.lista_Producto_Especifico[i].getProducto() == productoe){
                    Globales.lista_Producto_Especifico[i].getPreciounitario();
                    Globales.lista_Producto_Especifico[i].getDescripcionespecífica();
                    Globales.lista_Producto_Especifico[i].getProducto();
                }
            }
        }

        public int getPreciounitario() {
            return preciounitario;
        }
        
        int ReadOnlyProducto_Especifico.getPreciounitario()
        {
            return preciounitario;
        }

        public void setPreciounitario(int preciounitario)
        {
            this.preciounitario = preciounitario;
        }

        String ReadOnlyProducto_Especifico.getDescripcionEspecifica()
        {
            return descripcionespecífica;
        }

        public String getDescripcionespecífica()
        {
            return descripcionespecífica;
        }

        public void setDescripcionespecífica(String descripcionespecífica)
        {
            this.descripcionespecífica = descripcionespecífica;
        }

        public Producto getProducto()
        {
            return producto;
        }

        public void setProducto(Producto producto)
        {
            this.producto = producto;
        }

        String ReadOnlyProducto_Especifico.getNombre() {
            return nombre;
        }

        public String getnombre() 
        {
            return nombre;
        }

        public void setNombre(String nombre) {
            this.nombre = nombre;
        }

        String ReadOnlyProducto_Especifico.getImagen() {
            return imagen;
        }

        public String getimagen() {
            return imagen;
        }

        public void setimagen(String imagen) {
            this.imagen = imagen;
        }

        public Boolean getenuso() {
            return enuso;
        }

        public void setenuso(Boolean enuso) {
            this.enuso = enuso;
        }
    }
}