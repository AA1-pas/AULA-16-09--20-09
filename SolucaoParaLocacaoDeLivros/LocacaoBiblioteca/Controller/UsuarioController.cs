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
            
            return RetornaListadeUsuario().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        public void AdicionarUsuarios (Usuario parametrosUser)
        {
            parametrosUser.Id = contexDB.idContadorUsuario++;
            contexDB.listaUsuarios.Add(parametrosUser);

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public List<Usuario> RetornaListadeUsuario ()
        {
            // como Where retorna um Enumereble temos que retornar um List -> com o ToList
            return contexDB.listaUsuarios.Where(x => x.Ativo).ToList<Usuario>(); // para falso: !x.Ativo
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario ativo cadastrado  em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId (int identificadorId)
        {
           var idLogin = contexDB.listaUsuarios.FirstOrDefault(x => x.Id == identificadorId);
            if (idLogin != null)
                idLogin.Ativo = false;
        }
   

    }
}
