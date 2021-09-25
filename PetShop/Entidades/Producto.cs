using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

   
    public class Producto
    {

        int id;
        string nombre;
        float precio;
        TipoProducto tipo;
        Mascota paraMascota;
        int cantidad;
        string detalle;

        static int idIncremental;


        static Producto()
        {
            idIncremental = 0;
        }

        int IdIncremental
        {
            get { return idIncremental; }
            set { idIncremental = value; }
        }

        int getNuevoId()
        {

            int id = IdIncremental;
            IdIncremental = id++;
            return id;

        }



        public Producto(string nombre, float precio, TipoProducto tipo, Mascota paraMascota, int cantidad)
        {

            this.id = getNuevoId();
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tipo = tipo;
            this.ParaMascota = paraMascota;
            this.Cantidad = cantidad;
            
        }

        public Producto(string nombre, float precio, TipoProducto tipo, Mascota paraMascota, int cantidad, string observacion)
            :this(nombre, precio, tipo, paraMascota, cantidad)
        {
            this.Detalle = detalle;

        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }




        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Detalle
        {
            set { detalle = value; }
            get { return detalle; }
        }


        public float Precio
        {
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
            get
            { return precio; }
        }

        public TipoProducto Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public Mascota ParaMascota
        {
            set { paraMascota = value; }
            get { return paraMascota; }
        }

        public int Cantidad
        {
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
            }
            get
            { return cantidad; }
        }


        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (string.Equals(prod1.Nombre, prod2.Nombre) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            if (string.Equals(prod1.Nombre, prod2.Nombre) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int operator -(Producto prod, int cantidadVendida)
        {
            int res = prod.Cantidad - cantidadVendida;
            return res;
        }

        public static int operator +(Producto prod, int cantidadVendida)
        {
            int res = prod.Cantidad + cantidadVendida;
            return res;
        }



        public void EditarProducto(string nombre, float precio, TipoProducto tipo, Mascota paraMascota,
            int cantidad, string detalle)
        {
            if (this.Nombre != nombre)
            {
                this.Nombre = nombre;
            }

            if (this.Precio != precio)
            {
                this.Precio = precio;
            }

            if (this.Tipo != tipo)
            {
                this.Tipo = tipo;
            }

            if (this.ParaMascota != paraMascota)
            {
                this.ParaMascota = paraMascota;
            }


            if (this.Cantidad != cantidad)
            {
                this.Cantidad = cantidad;
            }

            if (this.Detalle != detalle)
            {
                this.Detalle = detalle;
            }

        }











    }
}
