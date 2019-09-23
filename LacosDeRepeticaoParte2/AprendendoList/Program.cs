using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
        static List<string> minhaLIstaPulgmatica = new List<String>()
            {
            };

        static void Main(string[] args)
        {
            AddListaInformacoes();
            ImprimiListForeach();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo adiciona nomes a lista
        /// </summary>
        private static void AddListaInformacoes()   
        {
            Console.Clear();
            Console.WriteLine("Digite o nome: ");
            minhaLIstaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Nome:{minhaLIstaPulgmatica.Last()} foi adicionado a lista\n");
            Console.WriteLine("Deseja informar mais valores? Sim(S) Não(N)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AddListaInformacoes();
           // if (Console.ReadKey().KeyChar.ToString().ToUpper() == "S")
           //   AddListaInformacoes();
        }

        /// <summary>
        /// Metodo imprime lista de nomes através do for
        /// </summary>
        private static void ImprimiListFor()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista: ");
            var itens = minhaLIstaPulgmatica.Count;
            for (int i = 0; i < itens; i++)
                Console.WriteLine(minhaLIstaPulgmatica[i]);
        }

        /// <summary>
        /// Metodo imprime lista de nomes através do foreach
        /// </summary>
        private static void ImprimiListForeach()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista: ");
            foreach (var item in minhaLIstaPulgmatica)
                Console.WriteLine(item);
        }

        /// <summary>
        /// Metodo imprime lista de nomes através do while
        /// </summary>
        private static void ImprimiListWhile()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista: ");
            int j = 0;
            var itens = minhaLIstaPulgmatica.Count;
            while (j < itens)
            {
                Console.WriteLine("\n" + minhaLIstaPulgmatica[j]);
                j++;
            }
  
        }
    }
}
