using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
   
    public class MostrarListas
    {
        public static List<string> listaCerveja = new List<string>();
        public static List<string> listaMarcaCarro = new List<string>();
        /// <summary>
        /// Metodo para gerar lista de cerveja
        /// </summary>
        public static void ListaCerveja()
        {
            Console.Clear();
            Console.WriteLine("Digite a cerveja: ");
            listaCerveja.Add(Console.ReadLine());
            Console.WriteLine("\n*** CERVEJA ADICIONADA COM SUCESSO! ***\n");
            AdicionaLista(listaCerveja, 1);
        }

        /// <summary>
        /// Metodo adiciona itens á lista
        /// </summary>
        /// <param name="lista">lista de itens para impressão</param>
        public static void AdicionaLista(List<string> lista, int tipo)
        {
            Console.WriteLine("Deseja adicionar mais um item á lista?   S - Sim  N-Não ");
            if (Console.ReadKey().KeyChar.ToString().ToUpper() == "S")
            {
                if (tipo == 1)
                    ListaCerveja();
                else
                    ListaMarcaCarro();
            };
            ImprimiLista(lista);
        }

        /// <summary>
        /// Metodo para imprimir uma lista
        /// </summary>
        /// <param name="lista">lista para impressão</param>
        public static void ImprimiLista(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("Lista de itens cadastrados:\n");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Metodo para gerar lista de marca de carros
        /// </summary>
        public static void ListaMarcaCarro()
        {
            Console.Clear();
            Console.WriteLine("Digite a marca de carro: ");
            listaMarcaCarro.Add(Console.ReadLine());
            Console.WriteLine("\n*** MARCA ADICIONADA COM SUCESSO! ***\n");
            AdicionaLista(listaMarcaCarro, 2);
        }
    }
}
