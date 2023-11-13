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
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            for(int i=0; i < ClassListas.ResultadoConsumido.Count;i++)
            {
            int indice = viewResumen.Rows.Add();
            int consumido = ClassListas.ResultadoConsumido[i];
            int quemado = ClassListas.ResultadoQuemado[i];
            int saldoNeto = (consumido - quemado);

            viewResumen.Rows[indice].Cells[0].Value = consumido;
            viewResumen.Rows[indice].Cells[1].Value = quemado;
            viewResumen.Rows[indice].Cells[2].Value = saldoNeto;
            }
            
        }
    }
}
