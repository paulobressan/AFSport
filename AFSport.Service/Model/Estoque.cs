using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Estoque
    {
        public Estoque()
        {

        }

        public Estoque(int quantidade, int idProduto, int idUsuario)
        {
            this.Quantidade = quantidade;
            this.IdProduto = idProduto;
            this.IdUsuario = idUsuario;
        }

        public int IdEstoque { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public void Incrementa(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void Decrementa(int quantidade)
        {
            this.Quantidade -= quantidade;
        }
    }
}
