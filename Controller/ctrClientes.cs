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
        private List<Model.clientes> listaClientes = new List<Model.clientes>();

        public static ctrClientes obtenerctrClientes()
        {
            return new ctrClientes();
        }

        public void agregarCliente(string nombre, string apellido, string cedula, string telefono, string direccion)
        {
            Model.clientes cliente = new Model.clientes(nombre, apellido, cedula, telefono, direccion);
            listaClientes.Add(cliente);
        }
        
    }
}
