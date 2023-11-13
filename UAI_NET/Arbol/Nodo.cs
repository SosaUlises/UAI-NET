using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    public class Nodo
    {
        public string Nombre;
        public Nodo Derecha;
        public Nodo Izquierda;

        public Nodo(string n)
        {
            Nombre = n;
        }

        
    }
}
