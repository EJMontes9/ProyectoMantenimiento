using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ctrMantenimiento
    {
        private List<mantenimiento> listaMantenimiento = new List<mantenimiento>();
        private static ctrMantenimiento mantenimiento = new ctrMantenimiento();
        private int secuencial=0;

        public static ctrMantenimiento obtenerctrMantenimiento()
        {
            return mantenimiento;
        }

        public void agregarMantenimiento(string codigo, string mecanico, string cliente, string fecha, vehiculos vehiculo, string diagnostico, string trabajosRealizados, string tipoMantenimiento, decimal totPagar)
        {
            mantenimiento mantenimiento = new mantenimiento(codigo, mecanico, cliente, fecha, vehiculo, diagnostico, trabajosRealizados, tipoMantenimiento, totPagar);
            listaMantenimiento.Add(mantenimiento);
        }

        //Obtener lista de mantenimientos
        public List<mantenimiento> listarMantenimientos()
        {
            return listaMantenimiento;
        }

        public int generarSecuencial()
        {
            secuencial++;
            return secuencial;
        }
    }
}
