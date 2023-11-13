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
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            
            for(int i = 0; i < Clase.ListaCaloriasConsumidas.Count; i++)
            {
                int n = viewResumen.Rows.Add();
                int consumidas = Clase.ListaCaloriasConsumidas[i];
                int quemadas = Clase.ListaCaloriasQuemadas[i];
                int saldoNeto = ( consumidas - quemadas);

                viewResumen.Rows[n].Cells[0].Value = consumidas;
                viewResumen.Rows[n].Cells[1].Value = quemadas;
                viewResumen.Rows[n].Cells[2].Value = saldoNeto;
            }
        }
    }
}
