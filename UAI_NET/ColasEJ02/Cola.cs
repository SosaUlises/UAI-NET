using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasEJ02
{
    internal class Cola
    {
        public Nodo inicio;

        public void Encolar(Nodo unCliente)
        {
            if (inicio == null || unCliente.Prioridad < inicio.Prioridad)
            {
                unCliente.Siguiente = inicio;
                inicio = unCliente;
            }
            else
            {
                Nodo aux = inicio;
                while (aux.Siguiente != null && unCliente.Prioridad >= aux.Siguiente.Prioridad)
                {
                    aux = aux.Siguiente;
                }
                unCliente.Siguiente = aux.Siguiente;
                aux.Siguiente = unCliente;
            }
        }

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }
    }
}
