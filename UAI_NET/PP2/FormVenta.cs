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
    public partial class FormVenta : Form
    {
        int selected = 0;
      
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            // Llenamos Grid
            for (int i = 0; i < ClaseGlobal.Lista.Count; i++)
            {

                int n = viewVenta.Rows.Add();

                viewVenta.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                viewVenta.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getDescripcion();
                viewVenta.Rows[n].Cells[2].Value = ClaseGlobal.Lista[i].getPrecio();
                viewVenta.Rows[n].Cells[3].Value = ClaseGlobal.Lista[i].getStock();
            }
        }

        private void viewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;

            lblNombre.Text = ClaseGlobal.Lista[selected].getNombre();
            lblDescripcion.Text = ClaseGlobal.Lista[selected].getDescripcion();
            lblPrecio.Text = ClaseGlobal.Lista[selected].getPrecio().ToString();
            lblStock.Text = ClaseGlobal.Lista[selected].getStock().ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int total = 0;
            int nuevoStock = 0;

            if(selected != -1)
            {
                if(cantidad <= ClaseGlobal.Lista[selected].getStock()) // Verificamos que la cantidad sea menor o igual al stock disponible
                {
                    nuevoStock = (ClaseGlobal.Lista[selected].getStock() - cantidad); // Restamos la cantidad
                    ClaseGlobal.Lista[selected].setStock(nuevoStock); // Guardamos nuevo stock

                   total = (ClaseGlobal.Lista[selected].getPrecio() * cantidad);
                   lblTotal.Text = total.ToString();

                    MessageBox.Show("Venta realizada con exito! Venta descontada del stock del producto!","Venta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cantidad ingresada es superior al stock disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
    }
}
