using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Categoria;

namespace AFSport.Web.Api.DTO.Produto
{
    public class ProdutoSalvarDTO
    {
        [Required(ErrorMessage = "Id do produto obrigatório")]
        public int IdProduto { get; set; } 

        [Required(ErrorMessage = "Nome obrigatório"), MaxLength(100, ErrorMessage = "Tamanho maximo 100 caracteres")]
        public string Nome { get; set; }

        [MaxLength(255, ErrorMessage = "Tamanho maximo 255 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor de compra obrigatório")]
        public decimal ValorCompra { get; set; }

       [Required(ErrorMessage = "Valor de venda obrigatório")]
        public decimal ValorVenda { get; set; }

        [Required(ErrorMessage = "id da categoria obrigatório")]
        public int? IdCategoria { get; set; }

        [Required(ErrorMessage = "situação do produto(ativo/inativo) obrigatório")]
        public bool IsAtivo { get; set; }
    }
}
