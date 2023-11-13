using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasEJ01
{
    public class Nodo
    {
        public string Nombre;
        public string Sexo;
        public Nodo Siguiente;

        public Nodo(string nom, string sex)
        {
            Nombre = nom;
            Sexo = sex;
            Siguiente = null;
        }
    }
}
