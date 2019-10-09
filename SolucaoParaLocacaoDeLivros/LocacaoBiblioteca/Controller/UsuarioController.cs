using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Clase que contem os metodos de validação de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        private LocacaoContext contexDB = new LocacaoContext();
        public bool LoginSistema(Usuario usuarios)
        {
            
            return RetornaListadeUsuario().ToList<Usuario>().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        public void AdicionarUsuarios (Usuario parametrosUser)
        {
            contexDB.Usuarios.Add(parametrosUser);
            contexDB.SaveChanges();

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public IQueryable<Usuario> RetornaListadeUsuario ()
        {
            // como Where retorna um Enumereble temos que retornar um List -> com o ToList
            return contexDB.Usuarios.Where(x => x.Ativo); // para falso: !x.Ativo
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario ativo cadastrado  em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o usuario que será desativado</param>
        public bool RemoverUsuarioPorId (int identificadorId)
        {
           var idLogin = contexDB.Usuarios.FirstOrDefault(x => x.Id == identificadorId && x.Ativo == true);
            if (idLogin == null)
                return false;
            idLogin.Ativo = false;
            contexDB.SaveChanges();
            return true;
        }
   

    }
}
