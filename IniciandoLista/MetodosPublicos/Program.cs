using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Sistema Conversos de Moedas --------");
            Console.WriteLine("Informe o valor a ser convertido em reais (R$): ");
            var valorASerConvertido = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a moeda para converter: EURO - YEN - BTC - DOLAR");
            var alvo = Console.ReadLine().ToUpper();
            ConvertMoeda(valorASerConvertido, alvo);
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo pergunta o valor e o tipo alvo de moeda e faz a conversão
        /// </summary>
        public static void ConversorDeMoedas()
        {
            Console.WriteLine("----- Sistema Conversos de Moedas --------");
            Console.WriteLine("Informe o valor a ser convertido em reais (R$): ");
            var valorASerConvertido = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a moeda para converter: EURO - YEN - BTC - DOLAR");
            var alvo = Console.ReadLine().ToUpper();
            ConvertMoeda(valorASerConvertido, alvo);
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que converte moeda em real para um alvo especifico
        /// para converter digite os alvos:
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Minha moeda em real R$</param>
        /// <param name="moedaAlvo">Moeda alvo para a conversão</param>
        public static void ConvertMoeda (double minhaMoeda, string moedaAlvo)
        {
            switch(moedaAlvo)
            {
                case "EURO": 
                    Console.WriteLine(ValorEuro(minhaMoeda));
                    break;
                case "DOLAR":
                    Console.WriteLine(ValorDolar(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(ValorYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(ValorBtc(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("*** OPÇÃO INVÁLIDA! ***");
                    break;
            }
        }

        /// <summary>
        /// metodo faz conversao e formatacao de real para dolar
        /// </summary>
        /// <param name="valor">numero a ser formatado</param>
        /// <returns></returns>
        private static string ValorDolar(double valor)
        {
            return (valor / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// metodo faz conversao e formatacao de real para dolar
        /// </summary>
        /// <param name="valor">numero a ser formatado</param>
        /// <returns></returns>
        private static string ValorEuro(double valor)
        {
            return (valor / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "EURO ");
        }

        /// <summary>
        /// metodo faz conversao e formatacao de real para yen
        /// </summary>
        /// <param name="valor">numero a ser formatado</param>
        /// <returns></returns>
        private static string ValorYen(double valor)
        {
            return (valor / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP "));
        }

        /// <summary>
        /// metodo faz conversao e formatacao de real para Bitcoin
        /// </summary>
        /// <param name="valor">numero a ser formatado</param>
        /// <returns></returns>
        private static string ValorBtc(double valor)
        {
            return (valor / 41953.46).ToString("C2", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","BTC ");
        }
    }
}
