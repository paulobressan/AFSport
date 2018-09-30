namespace AFSport.Web.Core.Model
{
    public class Operacao
    {
        public Operacao()
        {
            this.IsAtivo = true;       
        }

        public Operacao(string nome)
        {
            this.Nome = nome;
            this.IsAtivo = true;
        }
        public int IdOperacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
