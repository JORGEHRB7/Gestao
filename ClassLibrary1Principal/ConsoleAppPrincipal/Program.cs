using BLL;
using Models;
using System.Linq.Expressions;

internal class Program
{

    private static void Main(string[] args)
    {
        try
        {
            string opcao;
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Jorge Humberto Rodrigues Barros";
            usuario.NomeUsuario = "Jorge Humberto";

            Console.WriteLine("O usuário estará ativo (S) ou (N)");
            usuario.Ativo = Console.ReadLine().ToUpper() == "S"; 
            

            usuario.Email = "jorgehumbertorb7@gmail.com";
            usuario.CPF = "065.623.631-01";
            usuario.Senha = "123";

            usuarioBLL.Inserir(usuario);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

