using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int idVenta;
        Cliente comprador;
        Empleado vendedor;
        DateTime fecha;
        List<Pedido> listPedidos;
        float precioTotal;

        static int idIncremental;

        static Venta()
        {
            idIncremental = 100;
        }

        public Venta(Cliente comprador, Empleado vendedor, DateTime fecha, List<Pedido> listPedidos,
            float precioTotal)
        {
            this.idVenta = getNuevoId();
            this.Comprador = comprador;
            this.Vendedor = vendedor;
            this.Fecha = fecha;
            this.ListPedidos = listPedidos;
            this.PrecioTotal = precioTotal;
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


        public Cliente Comprador
        {
            set { comprador = value; }
            get { return comprador; }
            
        }

        public Empleado Vendedor
        {
            set { vendedor = value; }
            get { return vendedor; }

        }


        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }

        }

        public List<Pedido> ListPedidos
        {
            set { listPedidos = new List<Pedido>(value); }
            get { return listPedidos; }
        }

        float PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        






        private float CalcularPrecioVenta()
        {
            float ret = 0;
            foreach(Pedido pedidoAux in ListPedidos)
            {
                ret += pedidoAux.Precio;
                
            }
            return ret;
        }

        public bool SetPrecioVenta()
        {
            bool ret = false;
            if (ListPedidos != null)
            {
                this.PrecioTotal = CalcularPrecioVenta();
                ret = true;
            }
            return ret;
        }






                
    }
}
