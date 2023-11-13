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
    public partial class FormCaloriasConsumidas : Form
    {
        public FormCaloriasConsumidas()
        {
            InitializeComponent();
        }

        int indiceCmb = 0;

        private void FormCaloriasConsumidas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Clase.ListAlimentos.Count; i++)
            {
                cmbAlimentos.Items.Add(Clase.ListAlimentos[i]);
            }
        }

        private void cmbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCmb = cmbAlimentos.SelectedIndex;
        } 

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidadIngresada = Convert.ToInt32(txtCantidad.Text);
            int mostrarTotal = 0;

            mostrarTotal = (Clase.ListValorCalorico[indiceCmb] * cantidadIngresada);

            lblTotal.Text = mostrarTotal.ToString();

            Clase.ListaCaloriasConsumidas.Add(mostrarTotal); // Guardamos resultado
        }
    }
}
