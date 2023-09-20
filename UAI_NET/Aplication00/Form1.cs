using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication00
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            int numero = 0;

            numero = Convert.ToInt32(txtNumero.Text);

            lblNumero.Text = numero.ToString();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            string Adicional = "";

            if(chbAire.Checked == true)
            {
                Adicional += chbAire.Text;
                Adicional += " ";
            }
            if (chbABS.Checked == true)
            {
                Adicional += chbABS.Text;
                Adicional += " ";
            }
            if (chbEstabilidad.Checked == true)
            {
                Adicional += chbEstabilidad.Text;
            }

            lblCheckBox.Text = Adicional;
        }

        private void btnOpcion_Click(object sender, EventArgs e)
        {
            string color = "Color seleccionado:  ";

            if(rbtn1.Checked == true)
            {
                color += rbtn1.Text;
            }
            if (rbtn2.Checked == true)
            {
                color += rbtn2.Text;
            }
            if (rbtn3.Checked == true)
            {
                color += rbtn3.Text;
            }

            lblColor.Text = color; 
        }
    }
}
