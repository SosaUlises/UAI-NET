using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasEJ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pila MiPila = new Pila();
        int seleccionado = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo unPueblo = new Nodo(txtPueblo.Text);
            MiPila.Apilar(unPueblo);
            MostrarPila();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string seleccionGrilla =  grid.Rows[seleccionado].Cells[0].Value.ToString();
            MiPila.Desapilar(seleccionGrilla);
            MostrarPila();
        }

        void MostrarPila()
        {
            grid.Rows.Clear();

            if(MiPila.ListaTope() != null)
            {
                MostrarDatosPilas(MiPila.ListaTope());
            }
        }

        void MostrarDatosPilas(Nodo unNodo)
        {
            int n = grid.Rows.Add();
            grid.Rows[n].Cells[0].Value = unNodo.Pueblo;

            if (unNodo.Siguiente != null)
            {
                MostrarDatosPilas(unNodo.Siguiente);
            }
        }
    }
}
