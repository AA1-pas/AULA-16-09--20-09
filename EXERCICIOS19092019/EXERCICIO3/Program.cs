using EXERCICIO3.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    class Program
    {
        static List<Carro> carrosLista = new List<Carro>();
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("**** SISTEMA DE CADASTRO DE CARROS ****");
            Console.WriteLine("-------------- BEM VINDO --------------");
            Console.WriteLine("***************************************\n");
            Console.WriteLine("Digite uma opção abaixo.\n1-Cadastro Carro\n2-Listagem de Cadastro\n3-Sair\n\nOpção: ");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    do
                        InserreNaLista();
                    while (Console.ReadKey().KeyChar.ToString().ToUpper() == "S");
                    MenuPrincipal();
                    break;
                case '2':
                    ImprimiLista();
                    MenuPrincipal();
                    break;

            };
        }

        public static void InserreNaLista()
        {
            Console.Clear();
            Console.WriteLine("*** CADASTRO DE PESSOA ***\n");
            {
                carrosLista.Add(new Carro()
                {
                    
                    Modelo = Cadastro("modelo:"),
                    Marca = (Cadastro("marca:")),
                    Ano = int.Parse(Cadastro("ano:")),
                    Valor = (Double.Parse(Cadastro("valor:")).ToString("C2")),
                    Placa = Cadastro("placa:")
                });
                Console.WriteLine("*** REGISTRO CADASTRADO COM SUCESSO ***\n\nDeseja fazer um novo cadastro? Sim (S) Não(N)");
            }
        }

        public static bool ValidaPlaca(string placa)
        {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{4}$");
            Regex regex2 = new Regex(@"^[A-Z]{3}\d{1}[A-Z]{1}\d{2}$");

            if (regex.IsMatch(placa) || regex2.IsMatch(placa))
                return true;
            else
                return false;
        }

         public static string Cadastro(string tipo)
        {
            var sai = 0;
            string informacao = string.Empty;
            do
            {
                Console.WriteLine($"Informe  {tipo} ");
                informacao = Console.ReadLine().ToUpper();
                if (tipo == "placa:" && ValidaPlaca(informacao) != true)
                {
                    Console.WriteLine("*** PLACA DIGITADA NÃO CONFERE COM NENHUM PADRÃO! DIGITE UMA PLACA VÁLIDA. ***");
                }
                else
                    sai = 1;
            } while (sai != 1);
                return informacao;
        }

        public static void ImprimiLista()
        {
            Console.Clear();
            Console.WriteLine("*** LISTA DE CADASTROS ***\n");
            carrosLista.ForEach(i => Console.WriteLine
            ($"Modelo: {i.Modelo}\nMarca: {i.Marca}\nAno: {i.Ano}\nValor: {i.Valor}\nPlaca: {i.Placa}\n------------------\n"));
            Console.WriteLine("\n\nPressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }

    }
}

 
