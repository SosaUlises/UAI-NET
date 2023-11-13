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
    public partial class FormCalcularCaloriasQuemadas : Form
    {
        int indice = -1;

        public FormCalcularCaloriasQuemadas()
        {
            InitializeComponent();
        }

        private void FormCalcularCaloriasQuemadas_Load(object sender, EventArgs e)
        {
            // Agregamos elementos de la List ActFisicas al comboBox
            for (int i = 0; i < ClassListas.ListActFisicas.Count; i++)
            {
                cmbActividades.Items.Add(ClassListas.ListActFisicas[i]);
            }
        }

        private void cmbActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cmbActividades.SelectedIndex; // Indice de la act. seleccionada
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int gastoCalorico = ClassListas.listGastoCalorico[indice];
            int duracion = Convert.ToInt32(txtDuracion.Text);

            int resultado = gastoCalorico * duracion;
            ClassListas.ResultadoQuemado.Add(resultado); // Guardamos en la List para resumen

            lblresultado.Text = resultado.ToString();
        }

   
    }
}
