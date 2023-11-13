using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP2
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            // Llenamos Grid
            for (int i = 0; i < ClaseGlobal.Lista.Count; i++)
            {

                int n = viewProductos.Rows.Add();
                viewProductos.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                viewProductos.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getStock();

                if(ClaseGlobal.Lista[i].getStock() < 5) {
                    MessageBox.Show($"PRODUCTO: {ClaseGlobal.Lista[i].getNombre()} STOCK MENOR A 5, NECESITA REPOSICION", "Stock",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
