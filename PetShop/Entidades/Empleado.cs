using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        int id;
        string user;
        string password;
        bool esAdmin;

        static int idIncremental;

        static Empleado()
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



       

        public Empleado(string nombre, string apellido, long telefono, DateTime fechaNacimiento,
            string user, string password)
             : base(nombre, apellido, telefono, fechaNacimiento)
        {
            this.id = getNuevoId();
            this.User = user;
            this.Password = password;
            this.EsAdmin = false;
            
        }

        #region get/set
        

        public string User
        {

            set
            {
                if (!value.Contains(" "))
                {
                    user = value;
                }
            }
            get { return user; }
        }

        public string Password
        {
            set
            {
                if (!value.Contains(" "))
                {
                    password = value;
                }
            }

        }
        public bool EsAdmin
        {
            set { esAdmin = value; }
            get { return esAdmin; }

        }








        #endregion

        public override string Mostrar()
        {
            return "Seguir";
        }

        //NOOOOOOOOOOO, es del admin
        //public List<Empleado> agregarEmpleado(Empleado auxEmpleado)
        //{
        //    Negocio.agregarEmpleado(auxEmpleado);
        //    return Negocio.ListEmpleados;
        //}

        public bool validarPassword(int indce, string password)
        {
            
            if (Negocio.ListEmpleados[indce].password == password)
            {
                return true;
            }
            return false;
            
        }

        

       

        public Stack<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.Clientes.Push(nuevoCliente);

            return Negocio.Clientes;
        }

        public Cliente AltaCliente(string nombre, string apellido, long telefono)
        {
            Cliente auxCliente = new Cliente(nombre, apellido, telefono);
            Negocio.agregarCliente(auxCliente);
            return Negocio.getUltimoCliente();
        }

        public Stack<Cliente> verClientes()
        {
            return Negocio.Clientes;
        }



      














    }

}
