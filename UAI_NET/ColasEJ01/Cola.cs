using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasEJ01
{
    public class Cola
    {
       public Nodo inicio;

        public void Encolar(Nodo unCliente)
        {
            if (inicio == null)
            {
                inicio = unCliente;
            }
            else
            {
                Nodo aux = BuscarUltimo(inicio);
                aux.Siguiente = unCliente;
            }
        }

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if(unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void EncolarHOMBRES(Nodo unCliente)
        {
            if(unCliente.Sexo == "Hombre")
            {
             if (inicio == null)
            {
                inicio = unCliente;
            }
            else
            {
                Nodo aux = BuscarUltimo(inicio);
                aux.Siguiente = unCliente;
            }
            }
        }
        public void EncolarMUJERES(Nodo unCliente)
        {
            if (unCliente.Sexo == "Mujer")
            {
                if (inicio == null)
                {
                    inicio = unCliente;
                }
                else
                {
                    Nodo aux = BuscarUltimo(inicio);
                    aux.Siguiente = unCliente;
                }
            }
        }
    }
}
