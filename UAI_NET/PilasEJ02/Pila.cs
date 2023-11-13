using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEJ02
{
    public class Pila
    {
        Nodo tope;

        public Nodo ListaTope()
        {
            return tope;
        }

        public void Apilar(Nodo Pueblo)
        {
            if (tope == null)
            {
                tope = Pueblo;
            }
            else
            {
                Nodo aux = tope;
                tope = Pueblo;
                tope.Siguiente = aux;
            }
        }

        public void Desapilar(string pueblo)
        {
            Nodo actual = tope;
            Nodo anterior = null;

            while(tope != null && actual.Pueblo != pueblo)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if(anterior == null)
            {
                tope = actual.Siguiente;
            }
            else
            {
                anterior.Siguiente = actual.Siguiente;
            }
        }
    }
}
