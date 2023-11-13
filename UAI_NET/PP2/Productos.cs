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
    public partial class FormProductos : Form
    {
        int selected = 0;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Llenamos comboBox
            cmbCategoria.Items.Add("Perecederos menos de un mes");
            cmbCategoria.Items.Add("Perecedereos menos de seis meses");
            cmbCategoria.Items.Add("No perecederos con vencimiento menor al año");
            cmbCategoria.Items.Add("Vencimiento extendido a tres años");

            // Llenamos Grid
            for (int i = 0; i < ClaseGlobal.Lista.Count; i++)
            {

            int n = viewProductos.Rows.Add();
  
                viewProductos.Rows[n].Cells[0].Value = ClaseGlobal.Lista[i].getNombre();
                viewProductos.Rows[n].Cells[1].Value = ClaseGlobal.Lista[i].getDescripcion();
                viewProductos.Rows[n].Cells[2].Value = ClaseGlobal.Lista[i].getCategoria();
                viewProductos.Rows[n].Cells[3].Value = ClaseGlobal.Lista[i].getPrecio();
                viewProductos.Rows[n].Cells[4].Value = ClaseGlobal.Lista[i].getStock();
                viewProductos.Rows[n].Cells[5].Value = ClaseGlobal.Lista[i].getProveedor();
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string categoria = cmbCategoria.Items[cmbCategoria.SelectedIndex].ToString();
            int precio = Convert.ToInt32(txtPrecio.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            string proveedor = txtProveedor.Text;

            ClaseGlobal.Producto NuevoProducto = new ClaseGlobal.Producto(nombre, descripcion, categoria,precio,stock,proveedor);
            ClaseGlobal.Lista.Add(NuevoProducto);

            // Lo cargamos en el GRID
            int n = viewProductos.Rows.Add();
            viewProductos.Rows[n].Cells[0].Value = nombre;
            viewProductos.Rows[n].Cells[1].Value = descripcion;
            viewProductos.Rows[n].Cells[2].Value = categoria;
            viewProductos.Rows[n].Cells[3].Value = precio;
            viewProductos.Rows[n].Cells[4].Value = stock;
            viewProductos.Rows[n].Cells[5].Value = proveedor;
            // Borramos el texto de los campos
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtProveedor.Text = "";
            txtStock.Text = "";
            cmbCategoria.Text = "";
        }

        private void viewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;

            // Relleno los TEXTBOXS con el valor seleccionado en la GRID
            txtNombre.Text = Convert.ToString(viewProductos.Rows[selected].Cells[0].Value);
            txtDescripcion.Text = Convert.ToString(viewProductos.Rows[selected].Cells[1].Value);
            cmbCategoria.Text = Convert.ToString(viewProductos.Rows[selected].Cells[2].Value);
            txtPrecio.Text = Convert.ToString(viewProductos.Rows[selected].Cells[3].Value);
            txtStock.Text = Convert.ToString(viewProductos.Rows[selected].Cells[4].Value);
            txtProveedor.Text = Convert.ToString(viewProductos.Rows[selected].Cells[5].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(selected != -1)
            {
                DialogResult r =
                    MessageBox.Show("Estas seguro que deseas modificar este producto?", "Modificar",MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    // Modificamos los valores con el metodo SET del objeto
                    ClaseGlobal.Lista[selected].setNombre(txtNombre.Text);
                    ClaseGlobal.Lista[selected].setDescripcion(txtDescripcion.Text);
                    ClaseGlobal.Lista[selected].setCategoria(cmbCategoria.Items[cmbCategoria.SelectedIndex].ToString());
                    ClaseGlobal.Lista[selected].setPrecio(Convert.ToInt32(txtPrecio.Text));
                    ClaseGlobal.Lista[selected].setStock(Convert.ToInt32(txtStock.Text));
                    ClaseGlobal.Lista[selected].setProveedor(txtProveedor.Text);

                    MessageBox.Show("Producto Modificado!");
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(selected != -1)
            {
                DialogResult r =
                    MessageBox.Show("Estas seguro de eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    viewProductos.Rows.RemoveAt(selected);
                    ClaseGlobal.Lista.RemoveAt(selected); // Borramos de la lista y del grid

                    // Borramos el texto de los campos
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtProveedor.Text = "";
                    txtStock.Text = "";
                    cmbCategoria.Text = "";
                }
            }
        }

       
        
    }
}
