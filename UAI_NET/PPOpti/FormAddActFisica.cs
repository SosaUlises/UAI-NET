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
    public partial class FormAddActFisica : Form
    {
        public FormAddActFisica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string actFisica = txtActFisica.Text;
            int gastoCalorico = Convert.ToInt32(txtGasto.Text);

            Clase.ListActFisica.Add(actFisica);
            Clase.ListaGastoCalorico.Add(gastoCalorico);

            MessageBox.Show("Actividad agregada a la base de datos!", "Actividad Fisica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
