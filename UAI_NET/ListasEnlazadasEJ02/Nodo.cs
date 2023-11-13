using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasEJ02
{
    public class Nodo
    {
        public string Nombre;
        public string Apellido;
        public int Dni;
        public string Domicilio;
        public int Telefono;
        public Nodo Siguiente;

        public Nodo(string nombre, string apellido, int dni, string domicilio, int telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Domicilio = domicilio;
            Telefono = telefono;
            Siguiente = null;
        }
    }
}
