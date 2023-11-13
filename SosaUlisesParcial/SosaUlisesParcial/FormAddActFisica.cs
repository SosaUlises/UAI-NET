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
    public partial class FormAddActFisica : Form
    {
        public FormAddActFisica()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string actFisica = txtActFisica.Text;
            int gastoCalorico = Convert.ToInt32(txtGastoCalorico.Text);

            // Agregamos a las listas
            Clase.ListaActFisica.Add(actFisica);
            Clase.ListaGastoCalorico.Add(gastoCalorico);

            MessageBox.Show("Actividad fisica agregada a la base de datos!",
                "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}
