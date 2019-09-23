using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcessandoDllDoAmiguinho
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.Write("Digite uma opção do menu:\n\n1-Desenho de uma Árvore\n2-Cálculo Área\n3-Lista de carro\n4-Lista de cerveja\n5-Sair\n\nOpção:");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    MinhaBiblioteca.AnimacoesEmFrame.Part1(); //está static
                    break;
                case '2':
                    var biblioteca = new MinhaBiblioteca.CalculosDeArea(); // não está static
                    Console.WriteLine("\n\nDigite o valor do lado do quadrado (cm): ");
                    Console.WriteLine($"A Área é de {biblioteca.CalculaAreaDoQuadrado(int.Parse(Console.ReadLine()))} cm².");
                    break;
                case '3':
                    Console.WriteLine("\n\nLista de Carros:");
                    MinhaBiblioteca.ListarCarro.ListaCarro();
                    break;
                case '4':
                    Console.WriteLine("\n\nLista de Cerveja:");
                    MinhaBiblioteca.CervejasLista.CervejaLista();
                    break;
                case '5':
                    break;
            }
            Console.WriteLine("\nDeseja continuar? S-Sim N-Não");
            if(Console.ReadKey().KeyChar.ToString().ToUpper() == "S")
                MenuPrincipal();
        }
    }
}
