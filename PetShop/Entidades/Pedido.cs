using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        Producto productoComprado;
        int cantidad;
        float precio;

        public Pedido(Producto productoComprado, int cantidad, float precio)
        {
            this.productoComprado = productoComprado;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Producto ProductoComprado
        {
            set { productoComprado = value; }
            get { return productoComprado; }
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
            get { return cantidad; }
        }

        public float Precio
        {
            set { precio = this.productoComprado.Precio * Cantidad; }
            get { return precio;}
        }



    }
}
