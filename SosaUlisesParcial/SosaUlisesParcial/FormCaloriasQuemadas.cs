using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosaUlisesParcial
{
    public partial class FormCaloriasQuemadas : Form
    {
        public FormCaloriasQuemadas()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void FormCaloriasQuemadas_Load(object sender, EventArgs e)
        {
           // Llenamos el comboBox
            for(int i = 0; i < Clase.ListaActFisica.Count; i++)
            {
                cmbAct.Items.Add(Clase.ListaActFisica[i]);
            }
        }

        private void cmbAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cmbAct.SelectedIndex; // Indice del valor seleccionado del cmbBox
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int duracion = Convert.ToInt32(txtDuracion.Text);
            int total = 0;

            total = (Clase.ListaGastoCalorico[indice] * duracion);
            lblTotal.Text = total.ToString(); // Mostramos en el label

            Clase.ListaCaloriasQuemadas.Add(total); // Guardamos en la lista

            MessageBox.Show("Calculo realizado con exito!!",
                   "Calculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDuracion.Text = "";
            cmbAct.Text = "";
        }
    }
}
