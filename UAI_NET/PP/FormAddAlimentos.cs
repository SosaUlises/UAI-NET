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
    public partial class FormAddAlimentos : Form
    {
        
        public FormAddAlimentos()
        {
            InitializeComponent();
        }

        private void btnAddAlimento_Click(object sender, EventArgs e)
        {
             string alimento = txtNombre.Text;
             int calorias = Convert.ToInt32(txtValorCalorico.Text);

            ClassListas.AgregarAlimento(alimento);
            ClassListas.AgregarValorCalorico(calorias);

            MessageBox.Show("Alimento agregado");  
        }

    }
}
