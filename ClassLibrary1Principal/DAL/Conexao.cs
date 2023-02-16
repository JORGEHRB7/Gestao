namespace DAL
{
    public class Conexao
    {
        public static string StringDeConexao { get; internal set; }

        public string stringDeConexao
        {
            get
            {
                return @"User ID=SA; Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019A;Password=Senailab02";
            }
        }
    }
}
