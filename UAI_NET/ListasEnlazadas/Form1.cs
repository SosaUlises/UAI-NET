using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    public partial class Form1 : Form
    {
        ListaEnlazada listaNodos = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemLista (Nodo unNodo)
        {
            if(unNodo != null)
            {
                listBox.Items.Add(unNodo.Nombre);
                AgregarItemLista(unNodo.Siguiente);
            }
        }

        public void MostrarLista()
        {
            listBox.Items.Clear();

            if(listaNodos.Inicio != null)
            {

                AgregarItemLista(listaNodos.Inicio);

            }
        }



        private void btnPrincipio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {

                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombre.Text;
                listaNodos.AgregarAlInicio(unNuevoNodo);
                MostrarLista();

            }
            else
            {
                MessageBox.Show("Debes ingresar un nombre!");
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {

                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombre.Text;
                listaNodos.AgregarAlFinal(unNuevoNodo);
                MostrarLista();

            }
            else
            {
                MessageBox.Show("Debes ingresar un nombre!");
            }
        }
    }
}
