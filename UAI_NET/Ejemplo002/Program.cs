using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int[] numeros1 = new int[] { 10, 20, 30, 40 };
            
            List<int> listaNumeros = new List<int>(); // No tiene limite

            for (int i = 0; i < 4; i++)
            {
                numeros[i] = numeros1[3-i]; // Guardamos los valores al reves

                listaNumeros.Add(numeros1[i]);
            }

            listaNumeros.Remove(20); //Elimina el valor 20

            foreach (int item in listaNumeros)   // Foreach reccore toda la lista automaticamente
            {
                Console.WriteLine(item);
                Console.WriteLine("El numero es {0}",item);

            }
            Console.ReadKey();

        }
    }
}
