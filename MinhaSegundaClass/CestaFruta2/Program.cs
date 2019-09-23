using CestaFruta2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da Fruta e a quantidade");
            var minhaCestaDeFrutas = new List<MinhasFrutas>()
            {
                new MinhasFrutas()
                {
                    Frutas = Console.ReadLine(),
                    QtdFrutas = int.Parse(Console.ReadLine())
                }

            };

            minhaCestaDeFrutas.ForEach(i =>
            Console.WriteLine($"A cesta de frutas têm {i.QtdFrutas} de {i.Frutas}."));
            Console.ReadKey();
        }
    }
}
