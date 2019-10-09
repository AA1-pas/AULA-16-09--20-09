using LocacaoBiblioteca.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext  : DbContext
    {
   
        //instanciamos "Carregamos para memoria" nosso controlador de livros
        public DbSet<Livro> Livros { get; set; } 

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
