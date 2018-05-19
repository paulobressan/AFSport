using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
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

        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
