using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    public class Cola
    {
        Nodo inicio;

        public void Encolar(Nodo unNodo)
        {
            if(inicio == null)
            {
                inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(inicio);
                aux.Siguiente = unNodo;
            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if(unNodo.Siguiente == null) 
            {
                return unNodo;
            }
            else
            {
               return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void Desencolar()
        {
            inicio = inicio.Siguiente;
        }

        public Nodo Inicio
        {
            get {return inicio;}
        }

        public bool Vacia()
        {
            return (inicio == null);
        }
    }
}
