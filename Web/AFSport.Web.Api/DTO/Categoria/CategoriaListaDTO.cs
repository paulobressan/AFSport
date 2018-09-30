using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFSport.Web.Api.DTO.Categoria
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
