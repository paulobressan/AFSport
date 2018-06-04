using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Movimentacoes
{
    public partial class FrmMovimentacoes : FrmCadastroBase
    {
        Movimentacao movimentacao;
        Usuario Usuario;
        public FrmMovimentacoes(Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
        }

        protected override async void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            await CarregarGrid();
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmFormMovimentacao frm = new FrmFormMovimentacao(new Movimentacao(), Usuario))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    await CarregarGrid();
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (movimentacao != null)
                using (FrmFormMovimentacao frm = new FrmFormMovimentacao(movimentacao, Usuario))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona uma movimentação para altera-la.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {        
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodasMovimentacoes();
        }

        private async Task<List<Movimentacao>> SelecionarTodasMovimentacoes()
        {
            using (MovimentacaoRepository repository = new MovimentacaoRepository())
                return await repository.SelecionarTodos(true);
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                movimentacao = (Movimentacao)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
