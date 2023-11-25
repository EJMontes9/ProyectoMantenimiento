using Controller;
using Model;
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
    public partial class frmListaMante : Form
    {
        ctrMantenimiento ctrMantenimiento = ctrMantenimiento.obtenerctrMantenimiento();
        public frmListaMante()
        {
            InitializeComponent();
            llenarDataGridView();
        }

        private void llenarDataGridView()
        {
            List<mantenimiento> listaMantenimiento = ctrMantenimiento.listarMantenimientos();
            dgvMantenimiento.DataSource = listaMantenimiento;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
