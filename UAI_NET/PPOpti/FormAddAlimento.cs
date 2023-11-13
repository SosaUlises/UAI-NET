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

            Clase.ListAlimentos.Add(alimento);
            Clase.ListValorCalorico.Add(valorCalorico);

            MessageBox.Show("Alimento cargado en la base de datos!", "Alimento", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
