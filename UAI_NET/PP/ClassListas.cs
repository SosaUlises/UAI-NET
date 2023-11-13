using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    public static class ClassListas
    {

        // 1eras Lists
        public static List<string> listAlimento = new List<string>();
        public static List<int> listValorCalorico = new List<int>();

        // 2das Lists Ya con valores definidos
        public static List<string> ListActFisicas = new List<string> {"Futbol", "Hockey", "Caminata"};
        public static List<int> listGastoCalorico = new List<int> {30,20,50};

        // List resumen
        public static List<int> ResultadoConsumido = new List<int>();
        public static List<int> ResultadoQuemado = new List<int>();

        public static void AgregarAlimento(string alimento)
        {
            listAlimento.Add(alimento);
        }
        public static void AgregarValorCalorico(int valorCalorico)
        {
            listValorCalorico.Add(valorCalorico);
        }

        public static void AgregarActFisica( string actFisica)
        {
            ListActFisicas.Add(actFisica);
        }

        public static void AgregarGastoCalorico(int gastoCalorico)
        {
            listGastoCalorico.Add(gastoCalorico);
        }
    }
}
