namespace AFSport.Web.Core.Model
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            this.IsAtivo = true;
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.IsAtivo = true;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
