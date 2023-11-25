using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ctrClientes
    {
        private List<clientes> list = new List<clientes>();
        private static ctrClientes ctrCliente = new ctrClientes();
        public static ctrClientes obtenerClientes()
        {
            return ctrCliente;
        }

        public string IngresarClientes(string nombre, string apellido, string cedula, string telefono, string direccion)
        {
            clientes cliente = new clientes(nombre, apellido, cedula, telefono, direccion);
            list.Add(cliente);
            return "Cliente ingresado correctamente";
        }

        public List<string> ListarClientes()
        {
            List<string> lista = new List<string>();
            foreach (clientes cliente in list)
            {
                lista.Add(cliente.Nombre);
            }
            return lista;
        } 
    }
}
