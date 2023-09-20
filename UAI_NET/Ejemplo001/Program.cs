using System;


namespace Ejemplo001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!!!");
            
            Saludo();

            string cadena = "Saludo desde cadena";

            Saludo2(cadena);

            Console.WriteLine(Saludo3(cadena, "")); 

            Console.ReadKey();
        }

        private static void Saludo()
        {
            Console.WriteLine("Hola mundo 2!!!");
        }

        private static void Saludo2(string cadena)
        {
            Console.WriteLine(cadena);
        }

        private static string Saludo3(string cadena, string resp)
        {
            Console.WriteLine(cadena);
            return "Respuesta al saludo";
        }

    }
}
