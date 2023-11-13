using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Pila
    {

        Nodo tope; // Donde vamos a agregar los nodos

        public Nodo ListaTope()
        {
            return tope;
        }

        public void Apilar(Nodo unNodo)
        {
            if(tope == null)
            {
                tope = unNodo;  // Si pila esta vacia
            }
            else
            {
                Nodo aux = tope;
                tope = unNodo;
                tope.Siguiente = aux;
            }
        }

        public void Desapilar()
        {
            if(tope != null)
            {
                tope = tope.Siguiente; // Cambiamos valores
            }
            
        }
    }
}
