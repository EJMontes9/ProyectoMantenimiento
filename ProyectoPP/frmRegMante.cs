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
        public frmRegMante()
        {
            InitializeComponent();
            llenarClientes();
        }

        private void llenarClientes()
        {
            List<string> lista = ctrClientes.ListarClientes();
            
            cbCliente.DataSource = lista;
        }

        private void frmRegMante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoPPDataSet11.mecanicos' Puede moverla o quitarla según sea necesario.
            this.mecanicosTableAdapter.Fill(this.proyectoPPDataSet11.mecanicos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoPPDataSet11.mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.proyectoPPDataSet11.mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'proyectoPPDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.proyectoPPDataSet.clientes);
            // TODO: esta línea de código carga datos en la tabla 'proyectoPPDataSet1.clientes' Puede moverla o quitarla según sea necesario.
            

        }

        private void clientesBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.proyectoPPDataSet.clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void clientesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.mecanicosTableAdapter.FillBy(this.proyectoPPDataSet1.mecanicos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
