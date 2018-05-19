using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Pedido
    {
        public Pedido()
        {
            this.IsAtivo = true;
        }

        public Pedido(Cliente cliente, Usuario usuario)
        {
            this.Data = DateTime.Now;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public bool IsAtivo { get; set; }
    }
}
