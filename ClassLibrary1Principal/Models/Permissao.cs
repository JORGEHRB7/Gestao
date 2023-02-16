namespace Models
{
    public class Permissão
    {
        public string Descricao { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }
    }
}
