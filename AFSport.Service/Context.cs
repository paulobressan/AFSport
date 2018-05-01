using AFSport.DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO
{
    public class Context : DbContext
    {
        public Context() : base ("conexao")
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        public DbSet<Operacao> Operacao { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Preco> Preco { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
