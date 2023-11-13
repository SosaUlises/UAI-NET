using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEJ01
{
    public class PilaOriginal
    {
        Nodo tope; // Donde se agregan

        public Nodo ListaTope()
        {
            return tope;
        }

        public void Apilar(Nodo contenedor)
        {
            if(tope == null)
            {
                tope = contenedor;
            }
            else
            {
                Nodo aux = tope;
                tope = contenedor;
                tope.Siguiente = aux;
            }
        }

        public void Desapilar(int Id)
        {
            Nodo PilaActual = tope;
            Nodo PilaAnterior = null;

            while(PilaActual != null && PilaActual.Identificador != Id)
            {
                PilaAnterior = PilaActual;
                PilaActual = PilaActual.Siguiente;
            }

            // Si el NODO a eliminar es el primero!
            if (PilaAnterior == null)
            {
                tope = PilaActual.Siguiente;
            }
            else
            {  // Si no es el primero!
                PilaAnterior.Siguiente = PilaActual.Siguiente;
            }
        }

    }
}
