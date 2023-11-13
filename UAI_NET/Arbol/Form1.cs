using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Nodo raiz;
        Nodo seleccionado;

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if(raiz != null)
            {
                DialogResult r = MessageBox.Show("Se eliminara el arbol, desea continuar?",
                    "Crear Raiz", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(r == DialogResult.Yes)
                {
                    string nombre = txtRaiz.Text;  
                    Nodo nuevaRaiz = new Nodo(nombre);
                    raiz = nuevaRaiz;
                }
            }
            else
            {
                string nombre = txtRaiz.Text;
                Nodo nuevaRaiz = new Nodo(nombre);
                raiz = nuevaRaiz;
            }

            cambiarSeleccionado(raiz);
            LlenarTreeView();
        }

        public void cambiarSeleccionado(Nodo n)
        {
            seleccionado = n;
            lblNombreNodo.Text = n.Nombre;
        }

        public void LlenarTreeView()
        {
            treeView.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            treeView.ExpandAll(); // mostrar treeView desplegado
            EvaluarArbol();
        }

        public void MostrarNodo(Nodo nodo, TreeNode padre, string lado)
        {
            if (nodo == null) return;

            TreeNode nuevo = new TreeNode();

            if(padre == null && lado == String.Empty) // Significa que es RAIZ
            {
                padre = new TreeNode();
                nuevo.Text = nodo.Nombre;
                nuevo.Tag = nodo;
                treeView.Nodes.Add(nuevo);
            }
            else
            {
                nuevo.Text = $"{lado} - {nodo.Nombre}";
                nuevo.Tag = nodo;

                padre.Nodes.Add(nuevo);
            }

            if (nodo.Derecha != null) MostrarNodo(nodo.Derecha, nuevo, "D");
            if (nodo.Izquierda != null) MostrarNodo(nodo.Izquierda, nuevo, "I");
        }

        public void EvaluarArbol()
        {
            lblAltura.Text = $"Altura:{Alto(raiz)}";
            int inicio = 0;
            lblAncho.Text = $"Ancho:{Ancho(raiz, ref inicio)}";
        }

        int Ancho(Nodo nodo, ref int ancho)
        {
            if (nodo.Derecha == null && nodo.Izquierda == null) ancho += 1;
            
            if(nodo.Derecha != null) Ancho(nodo.Derecha, ref ancho);
            if (nodo.Izquierda != null) Ancho(nodo.Izquierda, ref ancho);

            return ancho;
            
        }

        int Alto(Nodo nodo)
        {
            if (nodo == null) return 0;
            
            int izq = Alto(nodo.Izquierda) + 1;
            int der = Alto(nodo.Derecha) + 1;

            return Math.Max(izq, der);
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                string rama = txtRama.Text;
                Nodo nuevaRama = new Nodo(rama);

                seleccionado.Derecha = nuevaRama;
                LlenarTreeView();
            }
            else
            {
                MessageBox.Show("Debes tener un nodo seleccionado");
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                string rama = txtRama.Text;
                Nodo nuevaRama = new Nodo(rama);

                seleccionado.Izquierda = nuevaRama;
                LlenarTreeView();
            }
            else
            {
                MessageBox.Show("Debes tener un nodo seleccionado");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cambiarSeleccionado((Nodo)e.Node.Tag); 
        }

        void RecorridoPreOrden(Nodo nodo)
        {
            Visitar(nodo);
            if (nodo.Izquierda != null) RecorridoPreOrden(nodo.Izquierda);
            if (nodo.Derecha != null) RecorridoPreOrden(nodo.Derecha);


        }
        void RecorridoInOrden(Nodo nodo)
        {
            if (nodo.Izquierda != null) RecorridoInOrden(nodo.Izquierda);
            Visitar(nodo);
            if (nodo.Derecha != null) RecorridoInOrden(nodo.Derecha);
        }

        void RecorridoPostOrden(Nodo nodo)
        {
            if (nodo.Izquierda != null) RecorridoPostOrden(nodo.Izquierda);
            if (nodo.Derecha != null) RecorridoPostOrden(nodo.Derecha);
            Visitar(nodo);
        }

        void Visitar(Nodo nodo)
        {
            txtRecorrido.Text += "-" + nodo.Nombre;
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            RecorridoPreOrden(raiz);
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            RecorridoInOrden(raiz);
        }

        private void btnpostOrdern_Click(object sender, EventArgs e)
        {
            RecorridoPostOrden(raiz);
        }
    }
    }

