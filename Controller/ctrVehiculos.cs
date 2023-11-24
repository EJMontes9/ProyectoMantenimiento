using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ctrVehiculos
    {
        private vehiculos vehiculos = new vehiculos();
        private static ctrVehiculos vehiculo = new ctrVehiculos();

        public static ctrVehiculos obtenerctrVehiculos()
        {
            return vehiculo;
        }

        public void agregarVehiculos(string placa, string marca, string modelo, string color)
        {
            vehiculos vehiculo = new vehiculos(placa, marca, modelo, color);
            
        }
    }
}
