using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasEJ02
{
    public class ListaAlumnos
    {
        public Nodo inicio;

        public void AgregarAlumno(Nodo nodoAlumno)
        {
            if( inicio == null)
            {
                inicio = nodoAlumno;
            }
            else
            {
                Nodo aux = inicio;
                inicio = nodoAlumno;
                inicio.Siguiente = aux;
            }

        }

        public void EliminarAlumno(int seleccionado)
        {
            Nodo actual = inicio;
            Nodo anterior = null;

            // Recorremos la lista, hasta encontrar el NODO seleccionado
            while (actual != null && actual.Dni != seleccionado)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            // Si no encuentra el NODO
            if(actual == null)
            {
                MessageBox.Show("No hay nada en la lista para eliminar!",
                    "Eliminar", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            // Si el NODO a eliminar es el primero!
            if (anterior == null)
            {
                inicio = actual.Siguiente;
            }
            else
            {  // Si no es el primero!
                anterior.Siguiente = actual.Siguiente;
            }
        }


        public void ModificarAlumno(int seleccionado, string nombre, string apellido,
            int dni, string domicilio, int telefono)
        {
            Nodo actual = inicio;

            while(actual != null && actual.Dni != seleccionado)
            {
                actual = actual.Siguiente;
            }

            actual.Nombre = nombre;
            actual.Apellido = apellido;
            actual.Dni = dni;
            actual.Telefono = telefono;
            actual.Domicilio = domicilio;
        }

        public void AgregarDespues(int seleccionado, Nodo Alumno)
        {
            // Recorremos la lista, hasta encontrar el NODO seleccionado
            Nodo actual = inicio;

            while (actual != null && actual.Dni != seleccionado)
            {
                actual = actual.Siguiente;
            }

            Alumno.Siguiente = actual.Siguiente;
            actual.Siguiente = Alumno;
        }

        public Nodo obtenerAnterior(Nodo Alumno)
        {
            Nodo actual = inicio;
            Nodo anterior = null;

            // Recorrer la lista hasta encontrar el nodo dado
            while (actual != null && actual != Alumno)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                return anterior;
            }
            else
            {
                return null;
            }
        }

        public void AgregarAntes(int seleccionado, Nodo Alumno)
        {
            // Recorremos la lista, hasta encontrar el NODO seleccionado
            Nodo actual = inicio;

            while (actual != null && actual.Dni != seleccionado)
            {
                actual = actual.Siguiente;
            }

            if(actual == inicio)
            {
                Alumno.Siguiente = inicio;
                inicio = Alumno;
            }
            else
            {
                //Encontrar anterior
                Nodo anteriorActual = obtenerAnterior(actual);

                Alumno.Siguiente = actual;
                anteriorActual.Siguiente = Alumno;
            }
        }

        
    }
}
