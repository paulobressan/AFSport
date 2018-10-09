namespace AFSport.Web.Core.Model
{
    public class Cidade
    {
        public Cidade()
        {
            
        }

        public Cidade(string nome, int idEstado)
        {
            this.Nome = nome;
            this.IdEstado = idEstado;
            this.IsAtivo = true;
        }

        public int IdCidade { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return $"{this.Nome}-{this.Estado.Sigla}";
        }
    }
}
