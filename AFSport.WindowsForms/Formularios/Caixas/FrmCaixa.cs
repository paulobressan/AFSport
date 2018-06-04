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

namespace AFSport.WindowsForms.Formularios.Caixas
{
    public partial class FrmCaixa : FrmCadastroBase
    {
        Usuario Usuario;
        Caixa caixa;
        public FrmCaixa(Usuario usuario)
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
            if (!await VerificarCaixaDiarioAberto())
                using (FrmFormCaixa frm = new FrmFormCaixa(new Caixa(), Usuario))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Não é possivel cadastrar um novo caixa. O caixa diario já foi aberto.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnNovo_Click(sender, e);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (caixa != null)
                using (FrmFormCaixa frm = new FrmFormCaixa(caixa, Usuario))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um caixa para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosCaixas();
        }

        private async Task<List<Caixa>> SelecionarTodosCaixas()
        {
            using (CaixaRepository repository = new CaixaRepository())
                return await repository.SelecionarTodos(true);
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                caixa = (Caixa)GridPesq.SelectedRows[0].DataBoundItem;
        }

        private async Task<Caixa> SelecionarCaixaDiario()
        {
            using (CaixaRepository repository = new CaixaRepository())
                return await repository.SelecionarPorData(DateTime.Now.Date);
        }

        private async Task<bool> VerificarCaixaDiarioAberto()
        {
            var caixa = await SelecionarCaixaDiario();
            if (caixa == null)
                return false;
            return true;
        }
    }
}
