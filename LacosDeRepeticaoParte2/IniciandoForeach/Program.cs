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
            ForeachComSplitListCarros();
        }

        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar
        /// sobre um array de caracters, ou seja um texto ou palavra etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto");
            var conteudoDoTexto = Console.ReadLine();
            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome: ");
            var conteudoDoTexto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;
e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            Console.WriteLine("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();
            var conteudoTextoSplit = conteudoDoTexto.Split(';');
            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo busca nome em uma lista de cadastro
        /// </summary>
        private static void ForeachComSplitList ()
        {
            var conteudo = "nome:Allan,idade:26;nome:Giomar,idade:75;nome:Jose,idade:14";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Usuários cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um nome no sistema: ");
            var nomeBusca = Console.ReadLine();
            foreach (var item in listaDeInformacoes)
            {
                var listaDeSplit = item.Split(',');
                var nome = listaDeSplit[0].Split(':')[1];
                var idade = listaDeSplit[1].Split(':')[1];
                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Metodo le um modelo de carro informado e retorna o ano e marca
        /// </summary>
        private static void ForeachComSplitListCarros()
        {
            var conteudo = @"carro:Fusca,marca:Volkswagen,ano:1968;carro:Uno,marca:Fiat,ano:2018;carro:A4,marca:Audi,ano:2019;carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Carros cadastrados no sistema:");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("\nInforme um nome no sistema: ");
            var modeloBusca = Console.ReadLine();
            foreach (var item in listaDeInformacoes)
            {
                var listaDeSplit = item.Split(',');
                var modelo = listaDeSplit[0].Split(':')[1];
                var marca = listaDeSplit[1].Split(':')[1];
                var ano = listaDeSplit[2].Split(':')[1];
                if (modelo == modeloBusca)
                {
                    Console.WriteLine($"O {modelo} é da marca {marca} e do ano de {ano}.");
                }
            }
            Console.ReadKey();
        }
    }
}
