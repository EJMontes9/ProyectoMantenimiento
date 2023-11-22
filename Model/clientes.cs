using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class clientes : personas
    {
        private string telefono;
        private string direccion;

        public clientes(string nombre, string apellido, string cedula, string telefono, string direccion) : base(nombre, apellido, cedula)
        {
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public clientes()
        {
        }

        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
