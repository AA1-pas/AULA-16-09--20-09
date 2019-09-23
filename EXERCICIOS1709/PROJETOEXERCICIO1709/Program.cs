using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROJETOEXERCICIO1709
{
    public class Program
    {
        public static List<string> listaCerveja = new List<string>();
        public static List<string> listaMarcaCarro = new List<string>();
        static void Main(string[] args)
        {
            MenuPrincipalProjetos();
        }

        /// <summary>
        /// Metodo de menu principal de escolha dos metodos
        /// </summary>
        public static void MenuPrincipalProjetos()
        {
            Console.Clear();
            Console.Write(@"Qual método você deseja executar?
1-Árvore  
2-Área Quadrado 
3-Lista Cerveja 
4-Lista Marca Carro 
0-Sair

OPÇÃO: ");
            switch(Console.ReadKey().KeyChar.ToString())
            {
                case "1":
                    Console.Clear();
                    DesenhaArvore();
                    break;
                case "2":
                    Console.Clear();
                    AreaQuadrado();
                    break;
                case "3":
                    Console.Clear();
                    ListaCerveja();
                    break;
                case "4":
                    Console.Clear();
                    ListaMarcaCarro();
                    break;
                case "0":
                    break;
                default:
                    Console.Clear();
                    RetornaMenu("*** OPÇÃO INVÁLIDA! ***\n\n");
                    break;

            }
            
        }
 
        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos espacos deve imprimir</param>
        private static void EspacoArvore(double espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write(" ");
            }
        }

        /// <summary>
        /// metodo contem os dados e desenha a arvore
        /// </summary>
        private static void DesenhaArvore()
        {
            List<int> formatoArvore = new List<int>
            { 5,9,8,14,12,16,13,17,14,15,12,13,10,10,4,4,4,4,4,4,4,4,5,6,8,13,40};
            int k = 0;
            var cont = 0;

            for (int j = 20; j <= 25; j++)
            {
                if (j < 25)
                {
                    foreach (var i in formatoArvore)
                    {
                        EspacoArvore(40 - i);
                        if (cont >= 19 && cont <= 20)
                            DesenhandoALinhaArvore(2 * (i - k));
                        else
                            DesenhandoALinhaArvore(2 * i);
                        Console.Write("\n");
                        cont++;
                    }
                    Thread.Sleep(250);
                    k++;
                    cont = 0;
                    Console.Clear();
                }
                else
                {
                    foreach (var i in formatoArvore)
                    {
                        EspacoArvore(40 - i);
                        if (cont >20)
                            DesenhandoALinhaArvore(2 * i);
                        Console.Write("\n");
                        cont++;
                    }
                }
            }
            RetornaMenu("");
        }

        /// <summary>
        /// Retorna mesagem de erro se tiver e volta ao menu principal ao apertar qualquer tecla
        /// </summary>
        /// <param name="menssagemErro">menssagem de advertencia ao usuário</param>
        private static void RetornaMenu(string menssagemErro)
        {
            Console.WriteLine("\n" + menssagemErro + "Tecle qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
            MenuPrincipalProjetos();
        }
        
        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos caracteres deve imprimir</param>
        private static void DesenhandoALinhaArvore(int espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write("#");
            }
        }

        /// <summary>
        /// Metodo calcula área quadrado
        /// </summary>
        private static void AreaQuadrado()
        {
            Console.WriteLine("Digite a medida do lado do quadrado (cm).");
            double ladoQuadrado = double.Parse((Console.ReadLine()));
            Console.WriteLine("\n"+$"A área do quadrado é de {ladoQuadrado* ladoQuadrado} cm²."+"\n");
            RetornaMenu("");
        }

        /// <summary>
        /// Metodo para gerar lista de cerveja
        /// </summary>
        private static void ListaCerveja()
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
        private static void AdicionaLista(List<string> lista, int tipo)
        {
            Console.WriteLine("Deseja adicionar mais um item á lista?   S - Sim  ");
            if (Console.ReadKey().KeyChar.ToString().ToUpper() == "S")
            {
                if(tipo == 1)
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
        private static void ImprimiLista(List<string> lista)
        {
            Console.Clear();
            Console.WriteLine("Lista de itens cadastrados:\n");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            RetornaMenu("");
        }

        /// <summary>
        /// Metodo para gerar lista de marca de carros
        /// </summary>
        private static void ListaMarcaCarro()
        {
            Console.Clear();
            Console.WriteLine("Digite a marca de carro: ");
            listaMarcaCarro.Add(Console.ReadLine());
            Console.WriteLine("\n*** MARCA ADICIONADA COM SUCESSO! ***\n");
            AdicionaLista(listaMarcaCarro, 2);
        }
    }
}
