using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasEJ02
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        ListaAlumnos lista = new ListaAlumnos();
        int seleccion = 0;


        public void AgregarItemLista(Nodo unAlumno)
        {
            if (unAlumno != null)
            {
                int n = viewAlumnos.Rows.Add();
                viewAlumnos.Rows[n].Cells[0].Value = unAlumno.Nombre;
                viewAlumnos.Rows[n].Cells[1].Value = unAlumno.Apellido;
                viewAlumnos.Rows[n].Cells[2].Value = unAlumno.Dni;
                viewAlumnos.Rows[n].Cells[3].Value = unAlumno.Domicilio;
                viewAlumnos.Rows[n].Cells[4].Value = unAlumno.Telefono;
                AgregarItemLista(unAlumno.Siguiente);
            }
        }

        public void MostrarLista()
        {
            viewAlumnos.Rows.Clear();

            if(lista.inicio != null )
            {
                AgregarItemLista(lista.inicio);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 &&
                TxtApellido.Text.Length > 0 &&
                TxtDni.Text.Length > 0 &&
                TxtDomicilio.Text.Length > 0 &&
                TxtTelefono.Text.Length > 0 
                )
            {
                string nombre = txtNombre.Text;
                string apellido = TxtApellido.Text;
                int dni = Convert.ToInt32(TxtDni.Text);
                string domicilio = TxtDomicilio.Text;
                int telefono = Convert.ToInt32(TxtTelefono.Text);

                Nodo nuevoAlumno = new Nodo(nombre,apellido,dni,domicilio,telefono);
                lista.AgregarAlumno(nuevoAlumno);
                MostrarLista();

                txtNombre.Text = "";
                TxtApellido.Text = "";
                TxtDni.Text = "";
                TxtDomicilio.Text = "";
                TxtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Debes completas todos los campos!","Registro",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void viewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = e.RowIndex;

            txtNombre.Text = Convert.ToString(viewAlumnos.Rows[seleccion].Cells[0].Value);
            TxtApellido.Text = Convert.ToString(viewAlumnos.Rows[seleccion].Cells[1].Value);
            TxtDni.Text = Convert.ToString(viewAlumnos.Rows[seleccion].Cells[2].Value);
            TxtDomicilio.Text = Convert.ToString(viewAlumnos.Rows[seleccion].Cells[3].Value);
            TxtTelefono.Text = Convert.ToString(viewAlumnos.Rows[seleccion].Cells[4].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int seleccionDataGrid = Convert.ToInt32(viewAlumnos.Rows[seleccion].Cells[2].Value);

            DialogResult r =
                MessageBox.Show("Desea eliminar a este alumno?",
                "Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
            {
                lista.EliminarAlumno(seleccionDataGrid);
                MostrarLista();
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int seleccionDataGrid = Convert.ToInt32(viewAlumnos.Rows[seleccion].Cells[2].Value);
            string nombre = txtNombre.Text;
            string apellido = TxtApellido.Text;
            int dni = Convert.ToInt32(TxtDni.Text);
            string domicilio = TxtDomicilio.Text;
            int telefono = Convert.ToInt32(TxtTelefono.Text);


            DialogResult r =
                MessageBox.Show("Desea modificar a este alumno?",
                "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                lista.ModificarAlumno(seleccionDataGrid,nombre,apellido,dni,domicilio,telefono);
                MostrarLista();
            }
        }

        private void btnDespues_Click(object sender, EventArgs e)
        {
            int seleccionDataGrid = Convert.ToInt32(viewAlumnos.Rows[seleccion].Cells[2].Value);

            if (txtNombre.Text.Length > 0 &&
                TxtApellido.Text.Length > 0 &&
                TxtDni.Text.Length > 0 &&
                TxtDomicilio.Text.Length > 0 &&
                TxtTelefono.Text.Length > 0
                )
            {
                string nombre = txtNombre.Text;
                string apellido = TxtApellido.Text;
                int dni = Convert.ToInt32(TxtDni.Text);
                string domicilio = TxtDomicilio.Text;
                int telefono = Convert.ToInt32(TxtTelefono.Text);

                Nodo nuevoAlumno = new Nodo(nombre, apellido, dni, domicilio, telefono);
                lista.AgregarDespues(seleccionDataGrid,nuevoAlumno);
                MostrarLista();

                txtNombre.Text = "";
                TxtApellido.Text = "";
                TxtDni.Text = "";
                TxtDomicilio.Text = "";
                TxtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Debes completas todos los campos!", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAntes_Click(object sender, EventArgs e)
        {
            int seleccionDataGrid = Convert.ToInt32(viewAlumnos.Rows[seleccion].Cells[2].Value);

            if (txtNombre.Text.Length > 0 &&
                TxtApellido.Text.Length > 0 &&
                TxtDni.Text.Length > 0 &&
                TxtDomicilio.Text.Length > 0 &&
                TxtTelefono.Text.Length > 0
                )
            {
                string nombre = txtNombre.Text;
                string apellido = TxtApellido.Text;
                int dni = Convert.ToInt32(TxtDni.Text);
                string domicilio = TxtDomicilio.Text;
                int telefono = Convert.ToInt32(TxtTelefono.Text);

                Nodo nuevoAlumno = new Nodo(nombre, apellido, dni, domicilio, telefono);
                lista.AgregarAntes(seleccionDataGrid, nuevoAlumno);
                MostrarLista();

                txtNombre.Text = "";
                TxtApellido.Text = "";
                TxtDni.Text = "";
                TxtDomicilio.Text = "";
                TxtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Debes completas todos los campos!", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}
