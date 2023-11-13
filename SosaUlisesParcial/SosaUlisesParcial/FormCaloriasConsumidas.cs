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
    public partial class FormCaloriasConsumidas : Form
    {
        
        public FormCaloriasConsumidas()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void FormCaloriasConsumidas_Load(object sender, EventArgs e)
        {
            // Llenamos comboBox
            for (int i = 0; i < Clase.ListaAlimento.Count; i++)
            {
                cmbAlimento.Items.Add(Clase.ListaAlimento[i]);
            }
        }
        private void cmbAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cmbAlimento.SelectedIndex; // Indice de la seleccion del comboBox
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int total = 0;

            total = (Clase.ListaValorCalorico[indice] * cantidad); 
            lblTotal.Text = total.ToString(); // Mostramos resultado

            Clase.ListaCaloriasConsumidas.Add(total); // Guardamos resultado en una lista

           
            MessageBox.Show("Calculo realizado con exito!!",
                   "Calculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbAlimento.Text = "";
            txtCantidad.Text = "";
        }

        
    }
}
