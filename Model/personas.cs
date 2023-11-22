using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class personas
    {
        private string nombre;
        private string apellido;
        private string cedula;

        public personas(string nombre, string apellido, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
        }

        public personas()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}
