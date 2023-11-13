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
    public partial class FormAddFisica : Form
    {

    
        public FormAddFisica()
        {
            InitializeComponent();
        }

        private void btnAddFisica_Click(object sender, EventArgs e)
        { 
            string actFisica = txtActFisica.Text;
            int gastoCalorico = Convert.ToInt32(txtGastoCalorico.Text);

            // Agregamos a la listas
            ClassListas.AgregarActFisica(actFisica);
            ClassListas.AgregarGastoCalorico(gastoCalorico);

            MessageBox.Show("Actividad agregada!");
        }
    }
}
