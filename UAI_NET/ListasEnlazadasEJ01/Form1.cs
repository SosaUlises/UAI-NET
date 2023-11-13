using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasEJ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaPacientes lista = new ListaPacientes();
        int indice = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string domicilio = txtDireccion.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);


            if (txtCodigo.Text.Length > 0 &&
                txtNombre.Text.Length > 0 &&
                txtApellido.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 &&
                txtTelefono.Text.Length > 0)
            {
                Nodo unNuevoPaciente = new Nodo(codigo,nombre,apellido,domicilio,telefono);
               
                lista.AgregarPaciente(unNuevoPaciente); // Agregamos a la Lista
                MostrarLista();

                txtCodigo.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtNombre.Text = "";

            }
            else
            {
                MessageBox.Show("Debes completar todos los campos!",
                    "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void AgregarItemLista(Nodo unPaciente)
        {

            if(unPaciente != null)
            {
                int n = viewPacientes.Rows.Add();
                viewPacientes.Rows[n].Cells[0].Value = unPaciente.Codigo;
                viewPacientes.Rows[n].Cells[1].Value = unPaciente.Nombre;
                viewPacientes.Rows[n].Cells[2].Value = unPaciente.Apellido;
                viewPacientes.Rows[n].Cells[3].Value = unPaciente.Direccion;
                viewPacientes.Rows[n].Cells[4].Value = unPaciente.Telefono;
                AgregarItemLista(unPaciente.Siguiente);
            }
        }

        public void MostrarLista()
        {
            viewPacientes.Rows.Clear();

            if(lista.inicio != null)
            {
                AgregarItemLista(lista.inicio);
            }
        }

        private void viewPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            // Cargamos en los textBox
            txtCodigo.Text = Convert.ToString(viewPacientes.Rows[indice].Cells[0].Value);
            txtNombre.Text = Convert.ToString(viewPacientes.Rows[indice].Cells[1].Value);
            txtApellido.Text = Convert.ToString(viewPacientes.Rows[indice].Cells[2].Value);
            txtDireccion.Text = Convert.ToString(viewPacientes.Rows[indice].Cells[3].Value);
            txtTelefono.Text = Convert.ToString(viewPacientes.Rows[indice].Cells[4].Value);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int codigoPacientaSeleccionado = Convert.ToInt32(viewPacientes.Rows[indice].Cells[0].Value);


            if(indice != -1)
            {
                DialogResult r = MessageBox.Show("Estas seguro de eliminar este paciente?",
                    "Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
                {
                    
                    lista.EliminarPaciente(codigoPacientaSeleccionado);
                    MostrarLista();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(viewPacientes.Rows[indice].Cells[0].Value);
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string domicilio = txtDireccion.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);


            if(indice != -1)
            {
                DialogResult r = MessageBox.Show("Estas seguro de modificar este paciente?",
                   "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    lista.ActualizarPaciente(index,codigo,nombre,apellido,domicilio,telefono);
                    MostrarLista();
                }
                }
        }

        private void btnAgregarDespuesSeleccion_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(viewPacientes.Rows[indice].Cells[0].Value);

            // Crear un nuevo nodo con los datos que deseas agregar
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string domicilio = txtDireccion.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);

            Nodo nuevoNodo = new Nodo(codigo, nombre, apellido, domicilio, telefono);

            lista.AgregarDespuesDeSeleccion(nuevoNodo, index);
            MostrarLista();
        }
    }    
}
