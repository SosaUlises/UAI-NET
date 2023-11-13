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
    public partial class FormCaloriasQuemadas : Form
    {
        
        public FormCaloriasQuemadas()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void FormCaloriasQuemadas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Clase.ListActFisica.Count; i++)
            {
                cmbActividades.Items.Add(Clase.ListActFisica[i]);
            }
        }

        private void cmbActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cmbActividades.SelectedIndex;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int duracion = Convert.ToInt32(txtDuracion.Text);
            int total = 0;

            total = (Clase.ListaGastoCalorico[indice] *  duracion);
            lblTotal.Text = total.ToString();

            Clase.ListaCaloriasQuemadas.Add(total); // Guardamos el total en la Lista
        }
    }
}
