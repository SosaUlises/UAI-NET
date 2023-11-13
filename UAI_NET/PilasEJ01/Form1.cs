using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasEJ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PilaOriginal MiPila = new PilaOriginal();
        int seleccionGrilla = 0;

        private void btnApilar_Click(object sender, EventArgs e)
        {
            Nodo NuevoContenedor = new Nodo(Convert.ToInt32(txtNumero.Text));
            MiPila.Apilar(NuevoContenedor);
            MostrarPila();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrilla = e.RowIndex;
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {

            int seleccionDataGrid = Convert.ToInt32(gridView.Rows[seleccionGrilla].Cells[0].Value);

            MiPila.Desapilar(seleccionDataGrid);
            MostrarPila();
        }

        void MostrarPila()
        {
            gridView.Rows.Clear();

            if (MiPila.ListaTope() != null) // Si hay elementos dentro de la lista
            {
                MostrarNodoEnPila(MiPila.ListaTope());
            }
        }

        void MostrarNodoEnPila(Nodo unNodo)
        {
            int n = gridView.Rows.Add();
            gridView.Rows[n].Cells[0].Value = unNodo.Identificador;

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnPila(unNodo.Siguiente);
            }
        }


    }
}
