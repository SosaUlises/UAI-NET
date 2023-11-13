using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {

        Pila miPila = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            Nodo unNuevoNodo = new Nodo();

            unNuevoNodo.Nombre = txtNombre.Text;
            miPila.Apilar(unNuevoNodo);
            MostrarPila();
        }

        void MostrarPila()
        {
            listBox.Items.Clear();

            if(miPila.ListaTope() != null) // Si hay elementos dentro de la lista
            {
                MostrarNodoEnPila(miPila.ListaTope());
            }
        }

        void MostrarNodoEnPila(Nodo unNodo)
        {
            listBox.Items.Add(unNodo.Nombre);

            if(unNodo.Siguiente != null)
            {
                MostrarNodoEnPila(unNodo.Siguiente);
            }
        }

        private void BtnDesapilar_Click(object sender, EventArgs e)
        {
            miPila.Desapilar();
            MostrarPila();
        }
    }
}
