using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPP
{
    public partial class frmRegMante : Form
    {
        private ctrClientes ctrClientes = ctrClientes.obtenerClientes();
        private ctrMecanicos ctrMecanicos = ctrMecanicos.obtenerctrMecanicos();
        private ctrMantenimiento ctrMantenimiento = ctrMantenimiento.obtenerctrMantenimiento();
        private ctrVehiculos ctrVehiculos = ctrVehiculos.obtenerctrVehiculos();
        public frmRegMante()
        {
          
            InitializeComponent();
            llenarMecanicos();
            llenarClientes();
        }

        private void llenarClientes()
        {
            List<string> listacli = ctrClientes.ListarClientes();
            
            cbCliente.DataSource = listacli;
        }

        private void llenarMecanicos()
        {
            List<string> listamec = ctrMecanicos.listarMecanicos();

            cbMecanico.DataSource = listamec;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }


        private void cbTipoIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el valor del combobox
            string tipo = cbTipo.SelectedItem.ToString();
            gbRepuestos.Visible = false;

            if (tipo == "Correctivo")
            {
                gbRepuestos.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string codigo = ""+ctrMantenimiento.generarSecuencial();

            decimal TotPagar= 0;

            if (cbTipo.Text == "Preventivo")
            {
                TotPagar= 350;
            }

            if (cbTipo.Text == "Correctivo")
            {
                TotPagar =decimal.Parse(txtPrecio.Text) + 100;
                
            }
            
            ctrVehiculos.agregarVehiculos(txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtColor.Text);
            ctrMantenimiento.agregarMantenimiento(codigo, cbMecanico.Text, cbCliente.Text, dtpFecha.Text, ctrVehiculos.obtenerVehiculo(),rtDiagnostico.Text,rtTrabajos.Text,cbTipo.Text,TotPagar);

            MessageBox.Show("Mantenimiento registrado con exito");

            //limpiar los campos
            cbCliente.Text = "";
            cbMecanico.Text = "";
            cbTipo.Text = "";
            dtpFecha.Text = "";

            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtColor.Clear();

            rtDiagnostico.Clear();
            rtTrabajos.Clear();

            txtRepuesto.Clear();
            txtPrecio.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListaMante frmListaMante = new frmListaMante();
            frmListaMante.Show();
        }
    }
}
