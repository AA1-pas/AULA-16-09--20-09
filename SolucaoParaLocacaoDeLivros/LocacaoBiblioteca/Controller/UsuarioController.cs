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
        //Criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int idContador = 0;

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// Login:Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como parametro</param>
        /// <returns>Retorna verdadeiro quando existir usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        public UsuarioController()
        {
            ListaUsuarios = new List<Usuario>();

            ListaUsuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin",
                Id = idContador++,
            }) ;

        }
        private List<Usuario> ListaUsuarios { get; set; }

        public void AdicionarUsuarios (Usuario parametrosUser)
        {
            parametrosUser.Id = idContador++;
            ListaUsuarios.Add(parametrosUser);

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public List<Usuario> RetornaListadeUsuario ()
        {
            // como Where retorna um Enumereble temos que retornar um List -> com o ToList
            return ListaUsuarios.Where(x => x.Ativo).ToList<Usuario>(); // para falso: !x.Ativo
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario ativo cadastrado  em nossa lista
        /// </summary>
        /// <param name="identificadorId">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId (int identificadorId)
        {
            ListaUsuarios.FirstOrDefault(x => x.Id == identificadorId).Ativo = false;
        }
   

    }
}
