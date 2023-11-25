using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class mantenimiento
    {
        private string codigo;
        private string mecanico;
        private string cliente;
        private string fecha;
        private vehiculos vehiculo;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private decimal totPagar;

        public mantenimiento(string codigo, string mecanico, string cliente, string fecha, vehiculos vehiculo, string diagnostico, string trabajosRealizados, string tipoMantenimiento, decimal totPagar)
        {
            this.codigo = codigo;
            this.mecanico = mecanico;
            this.cliente = cliente;
            this.fecha = fecha;
            this.vehiculo = vehiculo;
            this.diagnostico = diagnostico;
            this.trabajosRealizados = trabajosRealizados;
            this.tipoMantenimiento = tipoMantenimiento;
            this.totPagar = totPagar;
        }

        public mantenimiento()
        {
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Mecanico { get => mecanico; set => mecanico = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public vehiculos Vehiculo { get => vehiculo; set => vehiculo = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string TrabajosRealizados { get => trabajosRealizados; set => trabajosRealizados = value; }
        public string TipoMantenimiento1 { get => tipoMantenimiento; set => tipoMantenimiento = value; }
        public decimal TotPagar { get => totPagar; set => totPagar = value; }
    }
}
