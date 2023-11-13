using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEJ01
{
    public class Nodo
    {
        public int Identificador;
        public Nodo Siguiente;

        public Nodo(int id)
        {
            Identificador = id;
            Siguiente = null;
        }
    }
}
