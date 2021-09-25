using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {


        float plataDisponible;
        List<Venta> listCompras;
        int cantidadCompras;
        

        public Cliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible) :
            base(nombre, apellido, telefono, fechaNacimiento)

        {

            this.PlataDisponible = plataDisponible;
            this.listCompras = null; ;
        }

        

        public override string Mostrar()
        {
            return "Cliente toy";
        }

        #region set, get


        public float PlataDisponible
        {
            set
            {
                if (value >= 0)
                {
                    plataDisponible = value;
                }
            }
            get { return plataDisponible; }
        }

        public List<Venta> ListCompras
        {
            set
            {
                if (value != null)
                { listCompras = value; }
            }
            get { return listCompras; }
        }

        int CantidadCompras
        {
            get { return cantidadCompras; }
            set { cantidadCompras = value; }
        }

        #endregion

        public bool AgregarVenta(Venta venta)
        {
            bool ret = false;
            if (venta != null)
            {
                this.ListCompras.Add(venta);
                this.CantidadCompras = this.CantidadCompras + 1;

                ret = true;

            }
            return ret;
        }
    }
}

   

//        public Cliente AltaCliente(string nombre, string apellido, long telefono)
//        {
           
//            Cliente auxCliente = new Cliente(nombre, apellido, telefono);
//            return auxCliente;
//        }

//        public Cliente AltaCliente(string nombre, string apellido, long telefono, float precio) 
//        {
//            Cliente auxCliente = new Cliente(nombre, apellido, telefono, precio);
//            return auxCliente;

//        }

//        public Cliente AltaCliente(string nombre, string apellido, long telefono, float precio, List<Venta> productosComprados)
//        {
//            Cliente auxCliente = new Cliente(nombre, apellido, telefono, precio);
//            return auxCliente;

//        }


//        public string clienteStr(Cliente cliente)
//        {
//            StringBuilder st = new StringBuilder();
//            st.Append(cliente.Nombre + " " + cliente.Apellido + " " + cliente.Telefono);
//            return st.ToString();
//        }


//    }
//}
