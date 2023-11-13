using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasEJ01
{
    public class ListaPacientes
    {

        public Nodo inicio;
        

        public void AgregarPaciente(Nodo paciente)
        {
            if(inicio == null)
            {
                // Si la lista esta vacia
                inicio = paciente;
            }
            else
            {
                Nodo aux = inicio;
                inicio = paciente;
                inicio.Siguiente = aux;
            }
        }

        public void EliminarPaciente(int codigo)
        {
            Nodo actual = inicio;
            Nodo anterior = null;

            // Recorrer lista hasta encontrar el nodo con el codigo dado
            while (actual != null && actual.Codigo != codigo)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if( actual == null)
            {
                return; // Si no se encuentra, no se hace nada
            }

            // Si el nodo a eliminar es el primero
            if(anterior == null)
            {
                inicio = actual.Siguiente;
            }
            else
            {   //Si no es el primer nodo
                anterior.Siguiente = actual.Siguiente;
            }
        }

        public void ActualizarPaciente(int index, int codigo, string nombre, string apellido,
            string domicilio, int telefono)
        {

            Nodo seleccionado = inicio;

            // Recorrer lista hasta encontrar el nodo con el codigo dado
            while (seleccionado != null && seleccionado.Codigo != index)
            {
                seleccionado = seleccionado.Siguiente;
            }

            // Verificar si se encontró el nodo con el código dado
            if (seleccionado != null)
            {
                // Actualizar los campos del nodo encontrado
                seleccionado.Codigo = codigo;
                seleccionado.Nombre = nombre;
                seleccionado.Apellido = apellido;
                seleccionado.Direccion = domicilio;
                seleccionado.Telefono = telefono;
            }
        }

        public void AgregarDespuesDeSeleccion(Nodo nuevoNodo, int index)
        {
            Nodo existente = inicio;

            // Recorrer lista hasta encontrar el nodo con el codigo dado
            while (existente != null && existente.Codigo != index)
            {
                existente = existente.Siguiente;
            }

            // Conectar el nuevo nodo al siguiente nodo del nodo existente
            nuevoNodo.Siguiente = existente.Siguiente;

            // Conectar el nodo existente al nuevo nodo
            existente.Siguiente = nuevoNodo;
        }
        
    }
}
