using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP
{

    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void caloriasConsumidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaloriasConsumidas formCaloConsumidas = new FormCaloriasConsumidas();
            formCaloConsumidas.ShowDialog();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAlimentos formAlimentos = new FormAddAlimentos();
            formAlimentos.ShowDialog();
        }

        private void actividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddFisica formActFisica = new FormAddFisica();
            formActFisica.ShowDialog();
        }

        private void caloriasQuemadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalcularCaloriasQuemadas formCaloriasQuemadas = new FormCalcularCaloriasQuemadas();
            formCaloriasQuemadas.ShowDialog();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClassListas.ResultadoQuemado.Count == 0 && ClassListas.ResultadoConsumido.Count == 0)
            {
                MessageBox.Show("Debe realizar carga de datos antes de ver su resumen!");
            }
            else
            {
            FormResumen FormResumenes = new FormResumen();
            FormResumenes.ShowDialog();
            }
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
