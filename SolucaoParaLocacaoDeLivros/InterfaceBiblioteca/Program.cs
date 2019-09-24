using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        private static LivrosController livrosController = new LivrosController();
        private static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            while (!RealizaLoginSistema())
            {
                Console.WriteLine("*** LOGIN E SENHA INVÁLIDOS ***\n");
                RetornaMenuTecla();
            }
            MostrarMenuSistema();
        }

        /// <summary>
        /// MOstra no console o menu disponível do sistema
        /// </summary>
        private static void MostrarMenuSistema()
        {

            int opcao = int.MinValue;
            while (opcao != 9)
            {
                Console.Clear();
                CabecalhoPrograma();
                Console.WriteLine("=================== MENU SISTEMA ====================\n");
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Cadastrar Usuários");
                Console.WriteLine("5 - Remover Usuários");
                Console.WriteLine("6 - Remover Livros");
                Console.WriteLine("8 - Voltar ao login");
                Console.WriteLine("9 - Sair");
                Console.Write("\nOpção: ");
                //Aqui vamos pegar numero digitado
                //Executar proxima funcao
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao);
                switch (opcao)
                {
                    case 1:
                        CabecalhoPrograma();
                        MostrarUsuarios();
                        RetornaMenuTecla();
                        break;
                    case 2:
                        CabecalhoPrograma();
                        MostrarLivros();
                        RetornaMenuTecla();
                        break;
                    case 3:
                        CabecalhoPrograma();
                        AdicionarLivro();
                        RetornaMenuTecla();
                        break;
                    case 4:
                        CabecalhoPrograma();
                        AdicionarUsuario();
                        RetornaMenuTecla();
                        break;
                    case 5:
                        CabecalhoPrograma();
                        RemoverUsuarioPeloId();
                        RetornaMenuTecla();
                        break;
                    case 6:
                        CabecalhoPrograma();
                        RemoverLivroId();
                        RetornaMenuTecla();
                        break;

                    case 8:
                        CabecalhoPrograma();
                        while (!RealizaLoginSistema())
                        {
                            Console.WriteLine("*** LOGIN E SENHA INVÁLIDOS ***\n");
                            RetornaMenuTecla();
                        }
                       
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Metodo que realiza os procedimentos completo de login dentro do sistema
        /// como solicitação de login e senha pelo console assim como a respectiva 
        /// validação que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>
        /// Retorna verdadeiro quando o login e senha informados 
        /// estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {

            CabecalhoPrograma();
            Console.WriteLine("=============== AUTENTICAÇÃO SISTEMA ================\n");
            Console.WriteLine("Informe seu login e senha para acessar o sistema:\n");

            Console.Write("Login: ");
            var loginDoUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            var senhaDoUsuario = Console.ReadLine();
            
            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
        }

        /// <summary>
        /// Metodo instancia o objeto Livro e mosta 1 registro
        /// </summary>
        private static void MostrarLivros()
        {

            MostraCabecAcao("LISTA DE LIVROS CADASTRADOS");
            livrosController.RetornaListadeLivros().ForEach(i => Console.WriteLine($"Nome: {i.Nome} \n" +
                $"Id: {i.Id}\nData Criação: {i.DataCriacao}\n----------------------------------\n"));
           
        }

        /// <summary>
        /// Metodo instancia o objeto Usuarios e mosta registros
        /// </summary>
        private static void MostrarUsuarios()
        {
            MostraCabecAcao("LISTA DE USUARIOS CADASTRADOS");
            usuarioController. RetornaListadeUsuario().ForEach(i => Console.WriteLine($"Id: {i.Id} \n" +
                $"Nome: {i.Login}\n----------------------------------\n"));
        }

        /// <summary>
        /// Metodo gera o cabeçalho do programa
        /// </summary>
        private static void CabecalhoPrograma()
        {
            Console.Clear();
            Console.WriteLine(".....................................................\n");
            Console.WriteLine("********* SISTEMA DE LOCAÇÃO DE LIVROS V1.0 *********");
            Console.WriteLine(".....................................................\n");
        }

        //// Metodo para retornar lista
        //private static List<Livro> CadastraLivros()
        /*{
        //    List<Livro> livro = new List<Livro>();
        //
        //    livro.Add(new Livro()
        //    {
        //        Nome = "A bela e a Fera",
        //        Id = 1589
        //    });
        //    return livro;
        //}

        //private static void MostraLivros(List<Livro> listaImprimir)
        //{
        //    listaImprimir.ForEach(i => Console.WriteLine($"Nome {i.Nome} \nId {i.Id}\n--------------------\n"));
        }*/

        /// <summary>
        /// Metodo para adicionar um novo livro
        /// </summary>
        public static void AdicionarLivro()
        {
            string nomeDoLivro = string.Empty;
            MostraCabecAcao("CADASTRO DE LIVROS");
            
            while(nomeDoLivro == "")
            {
                Console.WriteLine("Digite um nome válido de um livro a ser cadastrado:");
                nomeDoLivro = Console.ReadLine();
                if (nomeDoLivro == "")
                    Console.WriteLine("*** NOME DE LIVRO INVÁLIDO ***\n");

            }
           
            livrosController.AdicionarLivro(new Livro()
            {
                Nome = nomeDoLivro,
        });
            Console.WriteLine("*** LIVRO CADASTRADO COM SUCESSO ***\n");
        }

        /// <summary>
        /// Metodo para adicionar um novo usuário
        /// </summary>
        public static void AdicionarUsuario()
        {
            string loginDoUsuario = string.Empty;
            string senhaDoUSuario = string.Empty;
       
            CabecalhoPrograma();
            MostraCabecAcao("CADASTRO DE USUÁRIOS");
            while (loginDoUsuario == "")
            {
                Console.WriteLine("Digite um login válido para cadastrar:");
                loginDoUsuario = Console.ReadLine();
                if (loginDoUsuario == "")
                    Console.WriteLine("*** USUÁRIO INVÁLIDO ***\n");
            } 
            while (senhaDoUSuario == "")
            {
                Console.WriteLine("Digite uma senha válida para cadastrar:");
                senhaDoUSuario = Console.ReadLine();
                if(senhaDoUSuario == "")
                    Console.WriteLine("*** SENHA INVÁLIDA ***\n");
            }
            usuarioController.AdicionarUsuarios(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUSuario

        });
            Console.WriteLine("*** USUÁRIO CADASTRADO COM SUCESSO ***\n");

        }

        /// <summary>
        /// Metodo remove (inativa) o usuario através de um id informado pelo usuário
        /// </summary>
        public static void RemoverUsuarioPeloId ()
        {
            MostraCabecAcao("REMOVE CADASTRO USUÁRIO"); 
            MostrarUsuarios();
            Console.WriteLine("Informe o ID do usuário que deseja desativar:");
            int.TryParse(Console.ReadLine(), out int usuarioId);
            usuarioController.RemoverUsuarioPorId(usuarioId);   
            Console.WriteLine("*** USUÁRIO REMOVIDO COM SUCESSO ***\n");
        }

        /// <summary>
        /// Metodo para finalizar operação e aguardar usuario pressionar uma tecla para finalizar
        /// </summary>
        public static void RetornaMenuTecla()
        {
            Console.WriteLine("Pressione qualquer tecla para retornar.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo remove (inativa) o livro através de um id informado pelo usuário
        /// </summary>
        public static void RemoverLivroId()
        {
            MostraCabecAcao("REMOVE CADASTRO LIVROS");
            MostrarLivros();
            Console.WriteLine("Informe o ID do livro que deseja remover:");
            int.TryParse(Console.ReadLine(),out int livroId) ;
            livrosController.RemoverLivroPorId(livroId);
            Console.WriteLine("*** LIVRO REMOVIDO COM SUCESSO ***\n");
        }
        /// <summary>
        /// Mostra no cabeçalho a ação que está sendo executada
        /// </summary>
        /// <param name="nomeAcao">Parametro que informa qual a ação atual</param>
        public static void MostraCabecAcao(string nomeAcao)
        {
            Console.WriteLine("=============={0,18}==============\n", nomeAcao);
        }
    }
}
