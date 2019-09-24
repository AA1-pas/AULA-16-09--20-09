using LocacaoBiblioteca.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int idContadorUsuario { get; set; } = 1;
        public  int idContadorLivro { get; set; } = 1;

        public LocacaoContext()
        {
            #region Construtor Usuários
            listaUsuarios = new List<Usuario>();

                listaUsuarios.Add(new Usuario()
                {
                    Login = "Admin",
                    Senha = "Admin",
                    Id = idContadorUsuario++,
                });

                listaUsuarios.Add(new Usuario()
                {
                    Login = "Admin",
                    Senha = "123",
                    Id = idContadorUsuario++,
                });
            #endregion

            #region Construtor Livro
            listaLivros = new List<Livro>();

                listaLivros.Add(new Livro()
                {
                    Nome = "Meu Primeiro Livro",
                    Id = idContadorLivro++
                });

                listaLivros.Add(new Livro()
                {
                    Nome = "Meu Segundo Livro",
                    Id = idContadorLivro++
                });

                listaLivros.Add(new Livro()
                {
                    Nome = "Meu Terceiro Livro",
                    Id = idContadorLivro++
                });
            #endregion
        }

        //instanciamos "Carregamos para memoria" nosso controlador de livros
        public List<Livro> listaLivros { get; set; } 

        public List<Usuario> listaUsuarios { get; set; }

    }
}
