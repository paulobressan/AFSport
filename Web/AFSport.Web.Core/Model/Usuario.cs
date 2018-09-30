namespace AFSport.Web.Core.Model
{
    public class Usuario : Pessoa
    {
        public Usuario()
        {
            this.IsAtivo = true;
        }

        public Usuario(string nome, string login, string senha) : base (nome)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
