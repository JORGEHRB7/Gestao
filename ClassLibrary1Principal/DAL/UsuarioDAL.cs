using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {

        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();


            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"IN";


            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
        }
        
        public Usuario Buscar(string _nomeusuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario usuario)
        {

        }
        public void Excluir (int _id)
        {

        }
    }
}