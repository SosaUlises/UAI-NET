using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasEJ03
{
    public class Nodo
    {
        public int edad;
        public int dni;
        public int costo;
        public Nodo Siguiente;


        public Nodo(int ed,int dnii, int cos)
        {
            edad = ed;
            dni = dnii;
            costo = cos;
            Siguiente = null;
        }

    }
}
