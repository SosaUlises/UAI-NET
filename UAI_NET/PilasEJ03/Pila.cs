using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEJ03
{
    public class Pila
    {
        public Nodo tope;

        public Nodo ListaTope()
        {
            return tope;
        }


        public void Apilar(Nodo Expediente)
        {
            if (tope == null)
            {
                tope = Expediente;

            }
            else if(Expediente.Numero < tope.Numero)
            {
                // Caso especial: Si la pila está vacía o el nuevo nodo tiene un número de expediente menor al tope
                Expediente.Siguiente = tope;
                tope = Expediente;
            }
            else
            {
                // Encuentra el nodo en la pila donde el nuevo nodo debe ser insertado
                Nodo temp = tope;
                while (temp.Siguiente != null && temp.Siguiente.Numero < Expediente.Numero)
                {
                    temp = temp.Siguiente;
                }

                // Inserta el nuevo nodo después del nodo 'temp'
                Expediente.Siguiente = temp.Siguiente;
                temp.Siguiente = Expediente;
            }
        }
    }
}
