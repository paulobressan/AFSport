using AFSport.Service.Model;
using AFSport.Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Relatorios
{
    public partial class FrmRelatorioMovimentacao : Form
    {
        public FrmRelatorioMovimentacao()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private async Task CarregarGrid()
        {
            GridItens.DataSource = await SelecionarItensPorData(Convert.ToDateTime(txtData.Text));
        }

        private async Task<List<ItemPedido>> SelecionarItensPorData(DateTime data)
        {
            using (ItemPedidoRepository repository = new ItemPedidoRepository())
            {
                decimal valorLiquido = 0, valorBruto = 0;
                var result = await repository.SelecionarTodosPorData(data);
                result.ForEach(item =>
                {
                    valorLiquido = valorLiquido + (item.Produto.ValorVenda - item.Produto.ValorCompra);
                    valorBruto = valorBruto + item.Produto.ValorVenda;
                });
                lblValorBrutoTxt.Text = valorBruto.ToString();
                lblValorLiquidoTxt.Text = valorLiquido.ToString();
                return result;
            }
                
        }

        private async void BtnPesq_Click(object sender, EventArgs e)
        {
            await CarregarGrid();
        }

        private void FrmRelatorioMovimentacao_Load(object sender, EventArgs e)
        {
            GridItens.AutoGenerateColumns = false;
        }
    }
}
