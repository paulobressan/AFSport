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
    public partial class FrmRelatorioCaixa : Form
    {
        public FrmRelatorioCaixa()
        {
            InitializeComponent();
        }

        private void FrmRelatorioCaixa_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodasMovimentacoesPorDataCaixa(Convert.ToDateTime(txtData.Text));
        }

        private async Task<List<Movimentacao>> SelecionarTodasMovimentacoesPorDataCaixa(DateTime date)
        {
            using (MovimentacaoRepository repository = new MovimentacaoRepository())
            {
                decimal valorEntrada = 0;
                decimal valorSaida = 0;
                var result = await repository.SelecionarMovimentacaoPorCaixa(date);
                result.ForEach(item =>
                {
                    if (item.Operacao.IdOperacao == 1)
                        valorEntrada = valorEntrada + item.Valor;
                    else if (item.Operacao.IdOperacao == 2)
                        valorSaida = valorSaida + item.Valor;
                });
                lblValorMovimentadoEntradaTxt.Text = valorEntrada.ToString();
                lvlValorMovimentadoSaidaTxt.Text = valorSaida.ToString();
                return result;
            }
        }

        private async void BtnPesq_Click(object sender, EventArgs e)
        {
            await CarregarGrid();
        }
    }
}
