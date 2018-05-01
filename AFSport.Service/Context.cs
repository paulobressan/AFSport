using AFSport.Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service
{
    public class Context : DbContext
    {
        public Context() : base ("conexao")
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
