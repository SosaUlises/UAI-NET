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
    public partial class FormAddAlimento : Form
    {
        public FormAddAlimento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string alimento = txtAlimento.Text;
            int valorCalorico = Convert.ToInt32(txtValorCalorico.Text);

            // Agregamos a las listas
            Clase.ListaAlimento.Add(alimento);
            Clase.ListaValorCalorico.Add(valorCalorico);

            MessageBox.Show("Alimento agregado a la base de datos!!",
                "Agregado",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Close();

        }
    }
}
