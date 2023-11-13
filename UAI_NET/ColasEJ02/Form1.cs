using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasEJ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPrioridad.Items.Add("1");
            cmbPrioridad.Items.Add("2");
            cmbPrioridad.Items.Add("3");
        }
        int seleccion = -1;
        Cola miCola = new Cola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int prioridad = Convert.ToInt32(cmbPrioridad.Items[seleccion]);

            Nodo nuevoNodo = new Nodo(nombre, prioridad);
            miCola.Encolar(nuevoNodo);
            MostrarCola();
        }

        private void cmbPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = cmbPrioridad.SelectedIndex;
        }

        public void MostrarCola()
        {
            gridCola.Rows.Clear();

            if (miCola.inicio != null)
            {
                MostrarNodoEnPantalla(miCola.inicio);
            }
        }
        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            int n = gridCola.Rows.Add();
            gridCola.Rows[n].Cells[0].Value = unNodo.Prioridad;
            gridCola.Rows[n].Cells[1].Value = unNodo.Nombre;

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnPantalla(unNodo.Siguiente);
            }

        }
    }
}
