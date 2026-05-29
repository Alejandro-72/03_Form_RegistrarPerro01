using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Form_RegistrarPerro01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Perro p1 = new Perro(txtNombre.Text, txtRaza.Text, txtAltura.Text);

            txtMostrar.Text = p1.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtRaza.Text = "";
            txtAltura.Text = "";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            /* Agregue la etiqueta lbl1 titulo del formulario".*/
        }
    }
}
