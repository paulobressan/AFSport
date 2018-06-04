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

namespace AFSport.WindowsForms.Formularios.Operacoes
{
    public partial class FrmOperacoes : FrmCadastroBase
    {
        Operacao operacao;
        public FrmOperacoes()
        {
            InitializeComponent();
        }

        protected override async void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            await CarregarGrid();
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            using(FrmFormOperacao frm = new FrmFormOperacao(new Operacao()))
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
            if (operacao != null)
                using (FrmFormOperacao frm = new FrmFormOperacao(operacao))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else 
                MessageBox.Show("Seleciona uma operação para altera-la.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodasOperacoes();
        }

        private async Task<List<Operacao>> SelecionarTodasOperacoes()
        {
            using (OperacaoRepository repository = new OperacaoRepository())
                return await repository.SelecionarTodos(false);
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                operacao = (Operacao)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
