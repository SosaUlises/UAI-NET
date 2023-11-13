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
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }
        
        int totalConsumido = 0;
        int totalQuemado = 0;

        private void FormResumen_Load(object sender, EventArgs e)
        {
          
            for (int i = 0; i < Clase.ListaCaloriasConsumidas.Count; i++)
            {
                
                totalConsumido += Clase.ListaCaloriasConsumidas[i]; // Suma del consumo ingresado
            }

            for (int i = 0; i < Clase.ListaCaloriasQuemadas.Count; i++)
            {
                
                totalQuemado += Clase.ListaCaloriasQuemadas[i]; // Suma de las calorias quemadas
            }

            int saldoCaloricoNeto = totalConsumido - totalQuemado;

            int n = viewResumen.Rows.Add();

            // Mostramos en la GRID
            viewResumen.Rows[n].Cells[0].Value = totalConsumido;
            viewResumen.Rows[n].Cells[1].Value = totalQuemado;
            viewResumen.Rows[n].Cells[2].Value = saldoCaloricoNeto;
        }
    }
}
