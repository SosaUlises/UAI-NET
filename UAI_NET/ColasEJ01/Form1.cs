using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasEJ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cola miCola = new Cola();
        Cola miColaMujeres = new Cola();
        Cola miColaHombres = new Cola();
        int seleccion = -1;

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string sexo = cmb.Items[seleccion].ToString().Trim();

            Nodo unCliente = new Nodo(nombre,sexo);
            miCola.Encolar(unCliente);
            miColaMujeres.EncolarMUJERES(unCliente);
            miColaHombres.EncolarHOMBRES(unCliente);
            MostrarCola();
            MostrarColaHombres();
            MostrarColaMujeres();
        }

        public void MostrarCola()
        {
            gridView.Rows.Clear();
           
            if(miCola.inicio != null)
            {
             MostrarNodoEnPantalla(miCola.inicio);
            }
        }

        public void MostrarColaHombres()
        {
            gridHombres.Rows.Clear();

            if (miColaHombres.inicio != null)
            {
             MostrarNodoEnPantallaHombres(miColaHombres.inicio);
            }
        }

        public void MostrarColaMujeres()
        {
            gridMujeres.Rows.Clear();

            if (miColaMujeres.inicio != null)
            {
                MostrarNodoEnPantallaMujeres(miColaMujeres.inicio);
            }
        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            
                int n = gridView.Rows.Add();
                gridView.Rows[n].Cells[0].Value = unNodo.Nombre;
                gridView.Rows[n].Cells[1].Value = unNodo.Sexo;

            if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantalla(unNodo.Siguiente);
                }
           
        }

        private void MostrarNodoEnPantallaHombres(Nodo unNodo)
        {

            int z = gridHombres.Rows.Add();
            gridHombres.Rows[z].Cells[0].Value = unNodo.Nombre;
            gridHombres.Rows[z].Cells[1].Value = unNodo.Sexo;

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnPantallaHombres(unNodo.Siguiente);
            }

        }

        private void MostrarNodoEnPantallaMujeres(Nodo unNodo)
        {

            int a = gridMujeres.Rows.Add();
            gridMujeres.Rows[a].Cells[0].Value = unNodo.Nombre;
            gridMujeres.Rows[a].Cells[1].Value = unNodo.Sexo;

            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnPantallaMujeres(unNodo.Siguiente);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb.Items.Add("Hombre");
            cmb.Items.Add("Mujer");
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = cmb.SelectedIndex;
        }
    }
}



