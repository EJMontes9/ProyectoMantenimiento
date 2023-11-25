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
    public partial class frmRegMecanico : Form
    {
        public frmRegMecanico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrMecanicos ctrMecanico = ctrMecanicos.obtenerctrMecanicos();
            ctrMecanico.agregarMecanicos(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtEspecialidad.Text, txtExperiencia.Text);

            MessageBox.Show("Mecanico registrado con exito");

            //limpiar los campos
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEspecialidad.Clear();
            txtExperiencia.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }
    }
}
