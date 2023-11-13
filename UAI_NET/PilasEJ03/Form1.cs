using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasEJ03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pila miPila = new Pila();

        private void btnApilar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int numero = Convert.ToInt32(txtNumero.Text);

            Nodo expediente = new Nodo(nombre,numero);
            miPila.Apilar(expediente);
            MostrarPila();
        }

        void MostrarPila()
        {
            gridView.Rows.Clear();

            if (miPila.ListaTope() != null)
            {
                MostrarDatosPilas(miPila.ListaTope());
            }
        }

        void MostrarDatosPilas(Nodo unNodo)
        {
            int n = gridView.Rows.Add();
            gridView.Rows[n].Cells[0].Value = unNodo.Numero;
            gridView.Rows[n].Cells[1].Value = unNodo.Nombre;

            if (unNodo.Siguiente != null)
            {
                MostrarDatosPilas(unNodo.Siguiente);
            }
        }

    }
}
