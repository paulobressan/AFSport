using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string logradouro, string bairro, int numero) : base(nome)
        {
            this.Logradouro = logradouro;
            this.Bairro = bairro;
            this.Numero = numero;
        }

        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }
    }
}
