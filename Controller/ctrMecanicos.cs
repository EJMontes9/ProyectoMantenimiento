using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ctrMecanicos
    {

        private List<Model.mecanicos> listaMecanicos = new List<Model.mecanicos>();

        public static ctrMecanicos obtenerctrClientes()
        {
            return new ctrMecanicos();
        }

        public void agregarMecanicos(string nombre, string apellido, string cedula, string especialidad, string experiencia)
        {
            Model.mecanicos mecanicos = new Model.mecanicos(nombre, apellido, cedula, especialidad, experiencia);
            listaMecanicos.Add(mecanicos);
        }
    }
}
