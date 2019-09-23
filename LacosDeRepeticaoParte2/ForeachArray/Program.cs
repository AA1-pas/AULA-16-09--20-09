using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados();
        }

        /// <summary>
        /// Metodo que tem os dados gerais chama metodo de formatacao e verificação de idade
        /// </summary>
        private static void Dados()
        {
            string bancoDados = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            DesmembraInformacao(bancoDados);
        }

        /// <summary>
        /// Metodo para verificar quem tem mais de 18 anos
        /// </summary>
        /// <param name="bancoDados">Recebe os dados de nome e idade</param>
        private static void DesmembraInformacao(string bancoDados)
        {
            string[] lista = bancoDados.Split(';');
            Console.WriteLine("Os seguintes membros possuem mais de 18 anos: ");
            foreach (var item in lista)
            {
                if ( int.Parse(item.Split(',')[1].Split(':')[1]) >= 18)
                    Console.WriteLine($"{item.Split(',')[0].Split(':')[1]}");
            }
            Console.ReadKey();
        }
    }
}


