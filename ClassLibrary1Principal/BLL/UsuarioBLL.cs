using DAL;
using Models;
namespace BLL
{
    public class UsuarioBLL
    {
        private object usuarioDAL;

        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3)
            {
                throw new Exception("O nome de usuário deve ter mais de três caracteres");

                
                if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                    throw new Exception("O nome de usuário deve ter mais de três caracteres.");

                if (_usuario.NomeUsuario.Contains(""))
                    throw new Exception("O nome de usuário não pode conter espaço");

                if (_usuario.Senha == "1234567")
                    throw new Exception("Não é permitido um número sequencial.");

                if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                    throw new Exception("A senha deve ter entre 7 e 11 caracteres.");

                UsuarioDAL usuarioDAL = new UsuarioDAL();
                usuarioDAL.Inserir(_usuario);
            }
        }
        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario usuario)
        {

        }
        public void Exlcuir(int _id)
        {

        }

    }
}