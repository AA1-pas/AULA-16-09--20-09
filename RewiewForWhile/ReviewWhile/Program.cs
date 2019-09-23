using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto: ");
            var conteudoDoTexto = Console.ReadLine();
            var i = 0;
            while (i <conteudoDoTexto.Length)
            {
                Console.WriteLine(conteudoDoTexto[i]);
                i++;
            }
            Console.ReadKey();
        }
    }
}
