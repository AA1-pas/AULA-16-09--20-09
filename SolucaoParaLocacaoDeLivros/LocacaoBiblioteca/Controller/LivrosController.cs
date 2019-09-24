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
        private  LocacaoContext contexDB = new LocacaoContext();


        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "intanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do ivro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contexDB.idContadorLivro;
            parametroLivro.DataCriacao = DateTime.Now;
            contexDB.listaLivros.Add(parametroLivro);

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Retorna a lista de livors cadastrados</returns>
        public List<Livro> RetornaListadeLivros()
        {
            return contexDB.listaLivros.FindAll(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario ativo cadastrado  em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o livro que será desativado</param>
        public void RemoverLivroPorId(int identificadorId)
        {
            var livro = contexDB.listaLivros.FirstOrDefault(x => x.Id == identificadorId);
            if (livro != null)
                livro.Ativo = false;
        }
    }
}
