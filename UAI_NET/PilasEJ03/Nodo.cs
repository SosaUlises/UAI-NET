using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasEJ03
{
    public class Nodo
    {
        public string Nombre;
        public int Numero;
        public Nodo Siguiente;

        public Nodo(string no, int num)
        {
            Nombre = no;
            Numero = num;
            Siguiente = null;
        }
    }
}
