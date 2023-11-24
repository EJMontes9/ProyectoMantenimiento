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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegCliente frm = new frmRegCliente();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegMecanico frm = new frmRegMecanico();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegMante frm = new frmRegMante();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Terminar la ejecucion del programa
            Application.Exit();
        }
    }
}
