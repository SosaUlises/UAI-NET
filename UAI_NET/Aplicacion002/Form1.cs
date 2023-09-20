using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion002
{
    public partial class Form1 : Form
    {

        int selected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = view.Rows.Add();
            int total;

            total = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text);

            view.Rows[fila].Cells[0].Value = txtFactura.Text;
            view.Rows[fila].Cells[1].Value = txtNombre.Text;
            view.Rows[fila].Cells[2].Value = txtApellido.Text;
            view.Rows[fila].Cells[3].Value = txtCuit.Text;
            view.Rows[fila].Cells[4].Value = cmbProducto.SelectedItem.ToString();
            view.Rows[fila].Cells[5].Value = txtCantidad.Text;
            view.Rows[fila].Cells[6].Value = txtPrecio.Text;
            view.Rows[fila].Cells[7].Value = total;


            txtFactura.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPrecio.Text = "";
            txtCuit.Text = "";
            txtCantidad.Text = "";
            cmbProducto.Text = "";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(selected != -1)
            {
                DialogResult r =
                MessageBox.Show("Desea eliminar esta cliente?","Borrar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    
                if( r == DialogResult.Yes) 
                {
                    view.Rows.RemoveAt(selected);
                }        
                                    
            }
            
        }

        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            txtFactura.Text = (string)view.Rows[selected].Cells[0].Value;
            txtNombre.Text = (string)view.Rows[selected].Cells[1].Value;
            txtApellido.Text = (string)view.Rows[selected].Cells[2].Value;
            txtPrecio.Text = (string)view.Rows[selected].Cells[6].Value;
            txtCuit.Text = (string)view.Rows[selected].Cells[3].Value;
            txtCantidad.Text = (string)view.Rows[selected].Cells[5].Value;
            cmbProducto.Text = (string)view.Rows[selected].Cells[4].Value;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(selected != -1)
            {

                DialogResult r = MessageBox.Show("Desea modificar este cliente?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.Yes) {
                
                int total;                

                total = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text);

                view.Rows[selected].Cells[0].Value = txtFactura.Text;
                view.Rows[selected].Cells[1].Value = txtNombre.Text;
                view.Rows[selected].Cells[2].Value = txtApellido.Text;
                view.Rows[selected].Cells[3].Value = txtCuit.Text;
                view.Rows[selected].Cells[4].Value = cmbProducto.SelectedItem.ToString();
                view.Rows[selected].Cells[5].Value = txtCantidad.Text;
                view.Rows[selected].Cells[6].Value = txtPrecio.Text;
                view.Rows[selected].Cells[7].Value = total;
                
                }
            }
        }
    }
}
