using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasEJ03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista lista = new Lista();
        int indice = 0;
      
    private void Form1_Load(object sender, EventArgs e)
        {
            lista.CargarPersonas();
            int EdadPorIndice;
            int DNIPorIndice;
            
            for (int i = 0; i < lista.numeroDePersonasAleatorio; i++)
            {
                lista.ObtenerIndiceEdades(i, out EdadPorIndice);
                lista.ObtenerIndiceDni(i, out DNIPorIndice);
                int costo = 0;

                if (EdadPorIndice >= 5 && EdadPorIndice <= 13)
                {
                    costo = 1000;
                }else if (EdadPorIndice > 13 && EdadPorIndice <= 18)
                {
                    costo = 1500;
                }else if(EdadPorIndice > 18 && EdadPorIndice <= 60)
                {
                    costo = 1900;
                }
                else
                {
                    costo = 1200;
                }

                Nodo persona = new Nodo(EdadPorIndice, DNIPorIndice, costo);
                lista.AgregarPersona(persona);

                MostrarLista(); // Cargar Lista

            }
        }

        public void AgregarItemLista(Nodo persona)
        {
            if (persona != null)
            {
                int n = viewPersonas.Rows.Add();
                viewPersonas.Rows[n].Cells[0].Value = persona.dni;
                viewPersonas.Rows[n].Cells[1].Value = persona.edad;
                viewPersonas.Rows[n].Cells[2].Value = persona.costo;
                AgregarItemLista(persona.Siguiente);
            }
        }

        public void MostrarLista()
        {
            viewPersonas.Rows.Clear();

            if (lista.inicio != null)
            {
                AgregarItemLista(lista.inicio);
            }
        }

        private void viewPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int seleccionGrilla = Convert.ToInt32(viewPersonas.Rows[indice].Cells[0].Value);

            DialogResult r =
                MessageBox.Show("Sacar de la fila a esta persona?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                lista.EliminarPersona(seleccionGrilla);
                MostrarLista();
            }
        }
    }
}
