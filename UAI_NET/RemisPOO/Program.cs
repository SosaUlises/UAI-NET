using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RemisPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Remis> listaRemises = new List<Remis>();

            ingresarMoviles(listaRemises);
            mostrarMoviles(listaRemises);
            cotizarViajes(listaRemises);
            

            Console.ReadKey();
        }

        static void ingresarMoviles(List<Remis> listaRemises)
        {
            // declaro variables de trabajo
            int nUnidad, year, tipoCombus;
            char categoria;
            string patente, marcaModelo;
            string resp = "S";

            while (resp == "S")
            {

                // UNIDAD MOVIL
                do
                {
                    Console.Write("Ingrese el numero de unidad (1-50): ");
                    nUnidad = int.Parse(Console.ReadLine());
                } while (nUnidad < 1 || nUnidad > 50);

                // PATENTE MOVIL
                string patron = "^[A-Za-z]{2}\\d{3}[A-Za-z]{2}$"; // AA 123 BB
                do
                {
                    Console.Write("Ingrese la patente del vehiculo: ");
                    patente = Console.ReadLine();
                } while (patente.Length != 7 || !Regex.IsMatch(patente, patron, RegexOptions.IgnoreCase));

                // MARCA MODELO DE UNIDAD
                do
                {
                    Console.Write("Ingrese la marca y modelo del vehiculo: ");
                    marcaModelo = Console.ReadLine();
                } while (marcaModelo.Length < 1 || marcaModelo.Length > 15);

                // YEAR FABRICACION
                do
                {
                    Console.Write("Ingrese el anio de fabricacion: ");
                    year = int.Parse(Console.ReadLine());
                } while (year < 2018 || year > 2023);

                // TIPO COMBUSTIBLE

                do
                {
                    Console.Write("Ingrese el tipo de combustible: (1)Nafta (2)Gas (3)GasOil ");
                    tipoCombus = int.Parse(Console.ReadLine());
                } while (tipoCombus < 1 || tipoCombus > 3);

                // CATEGORIA
                do
                {
                    Console.Write("Ingrese categoria: (A)Urbano (B)InterUrbano (C)Larga distancia ");
                    char.TryParse(Console.ReadLine(), out categoria);
                    categoria = char.ToUpper(categoria); 
                } while (categoria != 'A' && categoria != 'B' && categoria != 'C');

                // Agregamos el remis 
                Remis Movil = new Remis(nUnidad, patente, marcaModelo, year, tipoCombus, categoria);
                listaRemises.Add(Movil);

                do
                {
                    Console.WriteLine("Desea Ingresar otro movil? (S/N): ");
                    resp = Console.ReadLine();
                } while (resp != "S" && resp != "N");

            }    
        }

        static void mostrarMoviles(List<Remis> listaRemises)
        {

            foreach (Remis item in listaRemises)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(item.getNroUnidad());
                Console.WriteLine(item.getPatenteUnidad());
                Console.WriteLine(item.getmarcaModelo());
                Console.WriteLine(item.getAnioUnidad());

                switch (item.getTipoCombUnidad())
                {
                    case 1: Console.WriteLine("Nafta");
                        break;
                    case 2: Console.WriteLine("Gas");
                        break;
                    case 3: Console.WriteLine("GasOil");
                        break;
                }
                switch (item.getCategoriaUnidad())
                {
                    case 'A':
                        Console.WriteLine("Urbano");
                        break;
                    case 'B':
                        Console.WriteLine("SemiUrbano");
                        break;
                    case 'C':
                        Console.WriteLine("Larga distancia");
                        break;
                }
                Console.WriteLine("------------------");
            }
        }

        static void cotizarViajes(List<Remis> listaRemises)
        {
            string name, dSalida, dDestino;
            string movilAsignado;
            int kms, costo;

            // INGRESO DATOS

            // NAME SUBNAME USER
            do
            {
                Console.WriteLine("Ingrese el nombre y apellido del cliente: ");
                name = Console.ReadLine();
            } while (name.Length < 1 || name.Length > 20);

            // DIRECCION SALIDA
            Console.WriteLine("Ingrese direccion de salida: ");
            dSalida = Console.ReadLine();

            // DIRECCION DESTINO
            Console.WriteLine("Ingrese direccion de destino: ");
            dDestino = Console.ReadLine();

            // INGRESO DE KMS RECORRIDOS
            Console.WriteLine("Ingrese la cantidad de kms. recoridos: ");
            kms = int.Parse(Console.ReadLine());

            // MOVIL ASIGNADO
            if (kms <= 10)
            {
                movilAsignado = "Urbano";
            } else if (kms <= 60) {
                movilAsignado = "SemiUrbano";
            }
            else
            {
                movilAsignado = "Larga distancia";
            }

            // COSTO POR KMS
            if(kms <= 10)
            {
                costo = (kms * 80);
            }else if(kms > 10 && kms <= 20)
            {
                costo = (kms * 70);
            }else if (kms > 20 && kms <= 30)
            {
                costo = (kms * 60);
            }else if (kms > 30 && kms <= 60)
            {
                costo = (kms * 50);
            }
            else
            {
                costo = (kms * 40);
            }

            mostrarCotizacion(name, dSalida, dDestino, kms, movilAsignado, costo);
        }

        static void mostrarCotizacion(string name, string salida, string destino, int km, string movil, int costo)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Nombre del cliente: {0}", name);
            Console.WriteLine("Direccion de salida: {0}", salida);
            Console.WriteLine("Direccion del destino: {0}", destino);
            Console.WriteLine("Cantidad de kms: {0}", km);
            Console.WriteLine("Movil asignado: {0}", movil);
            Console.WriteLine("Costo del viaje: ${0}", costo);
            Console.WriteLine("------------------");
        }
    }

    internal class Remis
    {
        int nroUnidad;
        string patenteUnidad;
        string marcaModelo;
        int anioUnidad;
        int tipoCombUnidad;
        char categoriaUnidad;

        public Remis(int nu, string pat, string mm, int anio, int tcomb, char cat)
        {
            nroUnidad = nu;
            patenteUnidad = pat;
            marcaModelo = mm;
            anioUnidad = anio;
            tipoCombUnidad = tcomb;
            categoriaUnidad = cat;
        }

        public int getNroUnidad()
        {
            return nroUnidad;
        }

        public string getPatenteUnidad()
        {
            return patenteUnidad;
        }

        public string getmarcaModelo()
        {
            return marcaModelo;
        }

        public int getAnioUnidad()
        {
            return anioUnidad;
        }

        public int getTipoCombUnidad()
        {
            return tipoCombUnidad;
        }

        public char getCategoriaUnidad()
        {
            return categoriaUnidad;
        }

    }
}
