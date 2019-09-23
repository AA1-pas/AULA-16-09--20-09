using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcessandoInformacao
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void MenuSistema()
        {
          
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área\n2 - Mostrar Animação\n3 - Lista Cerveja\n4 - Lista Marca Carro\n5 - Sair do Sistema");
         
            var menuEscolhido = Console.ReadKey().KeyChar;

            switch(menuEscolhido)
            {
                case '1':
                    Console.Clear();
                    CalculaArea();
                    MenuSistema();
                    break;
                case '2':
                    Console.Clear();
                    MinhaAnimacao.DesenhaArvore();
                    MenuSistema();
                    break;
                case '3':
                    MostrarListas.ListaCerveja();
                    MenuSistema();
                    break;
                case '4':
                    MostrarListas.ListaMarcaCarro();
                    MenuSistema();
                    break;
                case '5':
                        Console.Clear();
                        Console.Write("Saindo....");
                        Thread.Sleep(500);
                    return;
                default:
                    break;

            }
       

        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado:");
            var ladoQuadrado = double.Parse(Console.ReadLine());

            var bibiotecaDeCalculos = new CalculosDeArea();
            
            Console.WriteLine($"Minha área é {bibiotecaDeCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}.\n");
            MenuSistema();
        }
    }
}
