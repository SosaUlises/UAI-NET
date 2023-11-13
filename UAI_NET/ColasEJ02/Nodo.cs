using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasEJ02
{
    public class Nodo
    {
        public string Nombre;
        public int Prioridad;
        public Nodo Siguiente;

        public Nodo(string n, int p)
        {
            Nombre = n;
            Prioridad = p;
            Siguiente = null;
        }
    }
}
