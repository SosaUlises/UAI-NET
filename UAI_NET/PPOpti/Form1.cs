using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPOpti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAlimento formAlimento = new FormAddAlimento();
            formAlimento.ShowDialog();
        }

        private void actFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddActFisica formActFisica = new FormAddActFisica();
            formActFisica.ShowDialog();
        }

        private void caloriasConsumidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaloriasConsumidas formCConsumidas = new FormCaloriasConsumidas();
            formCConsumidas.ShowDialog();
        }

        private void caloriasQuemadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaloriasQuemadas formQuemadas = new FormCaloriasQuemadas();
            formQuemadas.ShowDialog();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(Clase.ListaCaloriasQuemadas.Count == 0 || Clase.ListaCaloriasConsumidas.Count == 0)
            {
                MessageBox.Show("Debes realizar ingreso de datos antes de ver su RESUMEN!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormResumen formResumen = new FormResumen();
                formResumen.ShowDialog();
            }

            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
