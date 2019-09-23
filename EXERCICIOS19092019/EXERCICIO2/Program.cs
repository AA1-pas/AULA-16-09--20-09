using EXERCICIO2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    class Program
    {
        static List<Pessoa> pessoaLista = new List<Pessoa>();
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        /// <summary>
        /// Metodo do Menu Principal 
        /// </summary>
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("**** SISTEMA DE CADASTRO DE PESSOA ****");
            Console.WriteLine("-------------- BEM VINDO --------------");
            Console.WriteLine("***************************************\n");
            Console.WriteLine("Digite uma opção abaixo.\n1-Cadastro Pessoa\n2-Listagem de Cadastro\n3-Sair\n\nOpção: ");
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

        /// <summary>
        /// Metodo le a informação digitada e retorna essa informacao
        /// </summary>
        /// <param name="tipo">qual informação que vai ser informada</param>
        /// <returns></returns>
        public static string Cadastro(string tipo)
        {
            Console.WriteLine($"Informe o campo {tipo} ");
            var informacao = Console.ReadLine().ToUpper();
            if (tipo == "CPF: Somente números" && informacao.Length != 11 )
            {
                Console.WriteLine("\n*** CPF INVÁLIDO! INSIRRA UM VALOR VÁLIDO. ***");
                Cadastro(tipo);
            }
            else if (tipo == "RG: Somente números" && informacao.Length != 8)
            {
                Console.WriteLine("\n*** RG INVÁLIDO! INSIRRA UM VALOR VÁLIDO. ***\n");
                Cadastro(tipo);
            }

            return informacao;
        }

        /// <summary>
        /// metodo inserre na lista as informações
        /// </summary>
        public static void InserreNaLista()
        {
            Console.Clear();
            Console.WriteLine("*** CADASTRO DE PESSOA ***\n");
            {
                pessoaLista.Add(new Pessoa()
                {
                    Nome = Cadastro("nome:"),
                    Idade = int.Parse(Cadastro("idade:")),
                    Sexo = Cadastro("sexo: Feminino (F) Masculino (M)"),
                    Altura = double.Parse(Cadastro("altura (cm):")),
                    CPF = FormatCnpjCpf.FormatCPF(Cadastro("CPF: [11 números] Digitar somente números")),
                    RG = FormatCnpjCpf.FormatRG(Cadastro("RG: [8 números] Digitar somente números")),
                });
                Console.WriteLine("*** REGISTRO CADASTRADO COM SUCESSO ***\n\nDeseja fazer um novo cadastro? Sim (S) Não(N)");
            }

        }

        /// <summary>
        /// Metodo imprimi as informacoes da lista de cadastros
        /// </summary>
        public static void ImprimiLista()
        {
            Console.Clear();
            Console.WriteLine("*** LISTA DE CADASTROS ***\n");
            pessoaLista.ForEach(i => Console.WriteLine
            ($"Nome: {i.Nome}\nIdade: {i.Idade}\nSexo: {i.Sexo}\nAltura: {i.Altura}\nCPF: {i.CPF}\nRG: {i.RG}\n------------------\n"));
            Console.WriteLine("\n\nPressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }
    }
}
