using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Negocio
    {
        static string nombre;
        static string calle;
        static int numero;
        static int codigoPostal;

        static Stack<Cliente> clientes;
        static List<Venta> ventas;
        static List<Producto> listProductos;
        static List<Empleado> listEmpleados;

        static Negocio()
        {
            nombre = "Dogs PetShop";
            calle = "Av Rivadavia";
            numero = 5556;
            codigoPostal = 1212;

            Negocio.listEmpleados = new List<Empleado>()
            {
                new Empleado("Camila", "Tavera", 112365896, new DateTime(2000,04,04), " ", " "),
                
                new Administrador("yosi", "Tavera", 55522231, new DateTime(2000,04,04), " asd", "asd ")
            };

            clientes = new Stack<Cliente>();
            ventas = new List<Venta>();

            listProductos = new List<Producto>()
            {
                new Producto("Purina", 580, TipoProducto.Alimentos, Mascota.Perro, 5),
                new Producto("Bola de tela", 580, TipoProducto.Juguetes, Mascota.Gato, 5),
                new Producto("Desinfectante", 580, TipoProducto.Limpieza, Mascota.Pez, 3)
            };
        }


        

        public static Stack<Cliente> Clientes
        {
            set { clientes = value; }
            get { return Negocio.clientes; }
            
        }

        public static List<Producto> ListProductos
        {
            get { return Negocio.listProductos; }
        }

        public static List<Empleado> ListEmpleados
        {
            get { return Negocio.listEmpleados; }
            
        }


        public static Stack<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.clientes.Push(nuevoCliente);

            return Negocio.clientes;
        }


        public static List<Venta> agregarVenta(Venta nuevaVenta)
        {
            if (nuevaVenta != null)
                ventas.Add(nuevaVenta);
            return Negocio.ventas;
        }

        public static List<Empleado> agregarEmpleado(Empleado nuevoEmpleado)
        {
            if (nuevoEmpleado != null)
                listEmpleados.Add(nuevoEmpleado);
            return Negocio.listEmpleados;
        }

        public static Cliente getUltimoCliente()
        {
            if (clientes.Count() > 0)
                return clientes.Peek();
            else
                return null;
        }

        //public static int ExisteProducto(Producto producto)
        //{
        //    listProductos.IndexOf(producto);
        //}

        //public static bool stockProducto(Producto producto

        public static bool validarIngreso(string user, string password)
        {
            
            //List<Empleado> empleadoAux = new List<Empleado>Negocio.ListEmpleados;
            int index;
            foreach(Empleado item in Negocio.ListEmpleados)
            {
                if(item.User==user)
                {
                    index=ListEmpleados.IndexOf(item);
                    if (item.validarPassword(index, password) == true)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }


        /// <summary>
        /// le paso el nombre y me devuelve la cantidad que queda en stock
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private static Producto validarStock(Producto producto, int cantidad)
        {
            foreach(Producto item in ListProductos)
            {
                if (item == producto && item.Cantidad>=cantidad)
                    return item;

            }
            return null;

        }

        private static bool validarCliente(Cliente cliente, float precio)
        {
           if (cliente.PlataDisponible >= precio)
           {
                return true;
           }
           return false;

        }

        public static bool Vender(Producto producto, int cantidad)
        {

            Producto prodAux = validarStock(producto, cantidad);
            if (prodAux != null)
            {
                prodAux.Cantidad=prodAux - 1;
                return true;
            }
            return false;

        }


        public static string getDescripcion(int id)
        {

            foreach (Producto prod in Negocio.ListProductos)
            {
                if (prod.Id == id)
                {
                    return prod.Detalle;
                }
            }
            return null;
        }



        public static Producto editarProductoDeStock(int id, string nombre, float precio, TipoProducto tipo, Mascota paraMascota,
            int cantidad, string detalle)
        {
            Producto productoEdit = buscarProducto(id);
            if (productoEdit != null)
            {
                productoEdit.EditarProducto(nombre, precio, tipo, paraMascota, cantidad, detalle);

            }
            return productoEdit;

        }

        public static Producto borrarProductoDeStock(int id)
        {
            Producto productoEdit = buscarProducto(id);
           
    
            if (productoEdit != null)
            {
                listProductos.Remove(productoEdit);                
               
            }
            return productoEdit;

        }



        public static Producto buscarProducto(int id)
        {
            Producto prodAux;
            for(int i=0; i<listProductos.Count(); i++)
            {
                prodAux = ListProductos[i];
                if (prodAux.Id == id)
                {
                    return prodAux;
                }

                
            }
            return null;
        }

        public static void agregarProducto(Producto prod)
        {
            ListProductos.Add(prod);
        }

        







    }
}
