using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola miCola = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length > 0)
            {

             Nodo miNuevoNodo = new Nodo();
             miNuevoNodo.Nombre = txtNombre.Text;
             miCola.Encolar(miNuevoNodo);
                MostrarCola();
            }
            else
            {
                MessageBox.Show("Debes colocar un nombre!");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("Cola vacia!");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }

        private void MostrarCola()
        {
            listBox.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);
        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            if(unNodo != null)
            {
                listBox.Items.Add(unNodo.Nombre);
                if(unNodo.Siguiente != null)
            {
                MostrarNodoEnPantalla(unNodo.Siguiente);
            }
            }
        }
    }
}
