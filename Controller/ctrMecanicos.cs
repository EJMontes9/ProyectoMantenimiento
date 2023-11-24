using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ctrMecanicos
    {
        private List<mecanicos> listaMecanicos = new List<mecanicos>();
        private static ctrMecanicos mecanico = new ctrMecanicos();
        public static ctrMecanicos obtenerctrClientes()
        {
            return mecanico;
        }

        public void agregarMecanicos(string nombre, string apellido, string cedula, string especialidad, string experiencia)
        {
           mecanicos mecanico = new mecanicos(nombre, apellido, cedula, especialidad, experiencia);
            listaMecanicos.Add(mecanico);
        }

        public List<string> listarMecanicos()
        {
            List<string> lista = new List<string>();
            foreach (mecanicos mecanico in listaMecanicos)
            {                
                lista.Add(mecanico.Nombre);
            }
            return lista;
        }
    }
}
