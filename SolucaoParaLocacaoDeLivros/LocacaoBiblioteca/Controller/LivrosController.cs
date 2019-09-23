using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        //Criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int idContador = 0;
        public LivrosController()
        {
            ListaLivros = new List<Livro>();

            ListaLivros.Add(new Livro()
            {
                Nome = "Meu Primeiro Livro",
                Id = idContador++
            });

            ListaLivros.Add(new Livro()
            {
                Nome = "Meu Segundo Livro",
                Id = idContador++
            }) ;

        }
        private List<Livro> ListaLivros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "intanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do ivro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = idContador++;
            ListaLivros.Add(parametroLivro);
        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Retorna a lista de livors cadastrados</returns>
        public List<Livro> RetornaListadeLivros()
        {
            return ListaLivros;
        }
    }
}
