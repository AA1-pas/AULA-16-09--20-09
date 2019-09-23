using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para mostrar data carregada numa lista
        /// </summary>
        private static void ListaData()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20).AddDays(99));

            //minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MM/dd")));
            //minhaLista.ForEach(minhaData => Console.WriteLine(minhaData));
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToLongDateString()));

        }

        /// <summary>
        /// Metodo para mostrar informações carregadas numa lista
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");
            minhaLista.Add("MOTOROLA");

            minhaLista.ForEach(i => Console.WriteLine(i));

        }

        /// <summary>
        /// Metodo inclui numeros em uma lista e imprime lista
        /// </summary>
        private static void ListaInteiros()
        {
            List<int> minhaLista = new List<int>();
            var resposta = "s";
                while (resposta.ToLower() == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Deseja incluir um número? Sim(S) Não(N)");
                    resposta = Console.ReadKey().KeyChar.ToString();
                    Console.Clear();
                    Console.WriteLine("Digite o número:");
                    if (resposta.ToLower() == "s")
                    minhaLista.Add(int.Parse(Console.ReadLine()));
                }
            Console.Clear();
            Console.WriteLine("Os números digitados foram: \n");
            minhaLista.ForEach(item => Console.WriteLine(item));

        }

        /// <summary>
        /// Metodo para leitura, gravacao e impressão de numeros decimais em uma lista
        /// </summary>
        private static void ListaDeDecimais ()
        {
            var minhaLista = new List<double>();
            var resposta = "s";
            while (resposta.ToLower() == "s")
            {
                Console.Clear();
                Console.WriteLine("Deseja incluir um número? Sim(S) Não(N)");
                resposta = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
                Console.WriteLine("Digite o número:");
                if (resposta.ToLower() == "s")
                    minhaLista.Add(Double.Parse(Console.ReadLine()));
            }
            Console.Clear();
            Console.WriteLine("Os números digitados foram: \n");
            minhaLista.ForEach(meudecimal => Console.WriteLine(meudecimal.ToString("C") +"  "+ FormatarNUmeroDecimalEmDolar(meudecimal)));
        }

        /// <summary>
        /// matodo para formatar um numero em uma moeda
        /// </summary>
        /// <param name="meuValor">numero a ser formatado</param>
        /// <returns></returns>
        private static string FormatarNUmeroDecimalEmDolar(double meuValor)
        {
            return (meuValor / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
