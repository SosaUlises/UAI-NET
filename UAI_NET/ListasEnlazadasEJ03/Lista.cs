using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasEJ03
{
    public class Lista
    {
        public int numeroDePersonasAleatorio;
        public Nodo inicio;
        Random nrandom = new Random();
        public List<int> ListaEdades = new List<int>();
        public List<int> ListaDNI = new List<int>();

        public Lista()
        {
            numeroDePersonasAleatorio = nrandom.Next(0, 51);
        }

        public void AgregarPersona(Nodo persona)
        {
            if (inicio == null)
            {
                inicio = persona;
            }
            else
            {
                Nodo aux = inicio;
                inicio = persona;
                inicio.Siguiente = aux;
            }

        }

        public void CargarPersonas()
        {
            for (int i = 0; i < numeroDePersonasAleatorio; i++)
            {
                int edad = nrandom.Next(5, 61); // Genera una edad aleatoria entre 5 y 60 años
                 ListaEdades.Add(edad); 

                int dni = nrandom.Next(10000000, 45000000); // genera documento aleatorio
                 ListaDNI.Add(dni);
            }
        }
        public void ObtenerIndiceEdades(int indice, out int elemento)
        {
            if (indice >= 0 && indice < ListaEdades.Count)
            {
                elemento = ListaEdades[indice];
            }
            else
            {
                elemento = 0;
            }
        }
        public void ObtenerIndiceDni(int indice, out int elemento)
        {
            if (indice >= 0 && indice < ListaDNI.Count)
            {
                elemento = ListaDNI[indice];
            }
            else
            {
                elemento = 0;
            }
        }

        public void EliminarPersona(int seleccionado)
        {
            Nodo actual = inicio;
            Nodo anterior = null;

            while (actual != null && actual.dni != seleccionado)
            {
                anterior = actual;
                actual = actual.Siguiente;
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

        }
}
