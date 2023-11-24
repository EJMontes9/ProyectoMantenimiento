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
    public partial class frmRegCliente : Form
    {
        public frmRegCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrClientes ctrCliente = ctrClientes.obtenerClientes();
            ctrCliente.IngresarClientes(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtTelefono.Text, txtDireccion.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }
    }
}
