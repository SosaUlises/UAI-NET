using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    public class ListaEnlazada
    {
        public Nodo Inicio;


        public void AgregarAlInicio(Nodo unNodo)
        {
            if( Inicio == null)
            {
                // Si ingresa, la lista esta vacia
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
            }
        }

        public Nodo buscarUltimo(Nodo unNodo)
        {
            if(unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return buscarUltimo(unNodo.Siguiente);
            }
        }

        public void AgregarAlFinal(Nodo unNodo)
        {
            if(Inicio == null)
            {
                Inicio = unNodo;

            }
            else
            {
                // Encontrar el ultimo
                Nodo aux = buscarUltimo(Inicio);
                aux.Siguiente = unNodo;

            }
        }
    }
}
