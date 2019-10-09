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
            contexDB.Livros.Add(parametroLivro);
            contexDB.SaveChanges();

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Retorna a lista de livors cadastrados</returns>
        public IQueryable<Livro> RetornaListadeLivros()
        {
            return contexDB.Livros.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario ativo cadastrado  em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o livro que será desativado</param>
        public bool RemoverLivroPorId(int identificadorId)
        {
            var livro = contexDB.Livros.FirstOrDefault(x => x.Id == identificadorId && x.Ativo==true);
            if (livro == null)
                return false;
            livro.Ativo = false;
            contexDB.SaveChanges();
            return true;
        }

        /// <summary>
        /// Metodo atualiza o livro conforme objeto Livro recebido
        /// </summary>
        /// <param name="item">Parametro objeto Livro para atualizar</param>
        /// <returns></returns>
        public bool AtualizaLivros(Livro item)
        {
            if (contexDB.Livros.Where(x => x.Id == item.Id && x.Ativo == true) == null)
                return false;
            item.DataAlteracao = DateTime.Now;
            contexDB.SaveChanges();
            return true;
        }
    }
}
