using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Cadastrar usuário");
        Console.WriteLine("2 - Excluir usuário");
        Console.WriteLine("3 - Buscar todos os usuários");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarUsuario();
                break;
            case 2:
                ExcluirUsuario();
                break;
            case 3:
                BuscarTodosOsUsuarios();
                break;
            default:
                break;
        }
    }
    private static void BuscarTodosOsUsuarios()
    {
        try
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();

            foreach (Usuario item in usuarios)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Nome de usuário: " + item.NomeUsuario);
                Console.WriteLine("E-mail: " + item.Email);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void CadastrarUsuario()
    {
        try
        {
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.Nome = "Erisvaldo Carvalho Silva";
            usuario.NomeUsuario = "erisvaldo";

            Console.WriteLine("O usuário estará ativo (S) ou (N)");
            usuario.Ativo = true;//Console.ReadLine().ToUpper() == "S";

            usuario.Email = "contato@erisvaldocarvalho.com.br";
            usuario.CPF = "458.158.442-88";
            usuario.Senha = "12asdfdfe3";

            usuarioBLL.Inserir(usuario);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void ExcluirUsuario()
    {
        Console.WriteLine("Excluir usuário");
    }
}