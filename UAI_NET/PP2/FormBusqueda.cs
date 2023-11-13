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
    public partial class FormBusqueda : Form
    {
        public FormBusqueda()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            string ingreso = txtNombre.Text;
            int bandera = 0;

            for (int i = 0; i < ClaseGlobal.Lista.Count;i++)
            {
                if (ClaseGlobal.Lista[i].getNombre() == ingreso)
                {
                    int n = viewBusqueda.Rows.Add();

                    viewBusqueda.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                    viewBusqueda.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getDescripcion();
                    viewBusqueda.Rows[n].Cells[2].Value = ClaseGlobal.Lista[i].getCategoria();
                    viewBusqueda.Rows[n].Cells[3].Value = ClaseGlobal.Lista[i].getPrecio();
                    viewBusqueda.Rows[n].Cells[4].Value = ClaseGlobal.Lista[i].getStock();
                    viewBusqueda.Rows[n].Cells[5].Value = ClaseGlobal.Lista[i].getProveedor();
                    bandera = 1;
                }
            }
            if (bandera == 0)
            {
                MessageBox.Show("Producto no encontrado!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            string ingreso = txtProveedor.Text;
            int bandera = 0;

            for (int i = 0; i < ClaseGlobal.Lista.Count; i++)
            {
                if (ClaseGlobal.Lista[i].getProveedor() == ingreso)
                {
                    int n = viewBusqueda.Rows.Add();

                    viewBusqueda.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                    viewBusqueda.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getDescripcion();
                    viewBusqueda.Rows[n].Cells[2].Value = ClaseGlobal.Lista[i].getCategoria();
                    viewBusqueda.Rows[n].Cells[3].Value = ClaseGlobal.Lista[i].getPrecio();
                    viewBusqueda.Rows[n].Cells[4].Value = ClaseGlobal.Lista[i].getStock();
                    viewBusqueda.Rows[n].Cells[5].Value = ClaseGlobal.Lista[i].getProveedor();
                    bandera = 1;
                }
            }
            if(bandera == 0)
                {
                    MessageBox.Show("Producto no encontrado!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            // Llenamos comboBox
            cmbCat.Items.Add("Perecederos menos de un mes");
            cmbCat.Items.Add("Perecedereos menos de seis meses");
            cmbCat.Items.Add("No perecederos con vencimiento menor al año");
            cmbCat.Items.Add("Vencimiento extendido a tres años");
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            string ingreso = cmbCat.Items[cmbCat.SelectedIndex].ToString();
            int bandera = 0;

            for (int i = 0; i < ClaseGlobal.Lista.Count; i++)
            {
                if (ClaseGlobal.Lista[i].getCategoria() == ingreso)
                {
                    int n = viewBusqueda.Rows.Add();

                    viewBusqueda.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                    viewBusqueda.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getDescripcion();
                    viewBusqueda.Rows[n].Cells[2].Value = ClaseGlobal.Lista[i].getCategoria();
                    viewBusqueda.Rows[n].Cells[3].Value = ClaseGlobal.Lista[i].getPrecio();
                    viewBusqueda.Rows[n].Cells[4].Value = ClaseGlobal.Lista[i].getStock();
                    viewBusqueda.Rows[n].Cells[5].Value = ClaseGlobal.Lista[i].getProveedor();
                    bandera = 1;
                }  
            }

            if(bandera == 0)
                {
                    MessageBox.Show("Producto no encontrado!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
