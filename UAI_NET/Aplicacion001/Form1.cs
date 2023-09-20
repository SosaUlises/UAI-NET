using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int dato1, dato2, result;

            dato1 = Convert.ToInt32(txtNumero1.Text);
            dato2 = Convert.ToInt32(txtNumero2.Text);
            result = dato1 + dato2;

            lblResultado.Text = result.ToString();

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            int dato1, dato2, result;

            dato1 = Convert.ToInt32(txtNumero1.Text);
            dato2 = Convert.ToInt32(txtNumero2.Text);
            result = dato1 - dato2;

            lblResultado.Text = result.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int dato1, dato2, result;

            dato1 = Convert.ToInt32(txtNumero1.Text);
            dato2 = Convert.ToInt32(txtNumero2.Text);
            result = dato1 / dato2;

            lblResultado.Text = result.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int dato1, dato2, result;

            dato1 = Convert.ToInt32(txtNumero1.Text);
            dato2 = Convert.ToInt32(txtNumero2.Text);
            result = dato1 * dato2;

            lblResultado.Text = result.ToString();
        }
    }
}
