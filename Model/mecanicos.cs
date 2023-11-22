using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class mecanicos : personas
    {
        private string especialidad;
        private string experiencia;

        public mecanicos(string nombre, string apellido, string cedula, string especialidad, string experiencia) : base(nombre, apellido, cedula)
        {
            this.especialidad = especialidad;
            this.experiencia = experiencia;
        }

        public mecanicos()
        {
        }

        public string Especialidad{ get => especialidad; set => especialidad = value; }

        public string Experiencia{ get => experiencia; set => experiencia = value; }
    }
}
