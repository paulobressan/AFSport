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

namespace AFSport.WindowsForms.Formularios.Cidades
{
    public partial class FrmCidades : FrmCadastroBase
    {
        Cidade cidade;
        public FrmCidades()
        {
            InitializeComponent();
        }

        protected override void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            using (EstadoRepository repository = new EstadoRepository())
            {
                if(await repository.TotalRegistros() > 0)
                    using (FrmFormCidade frm = new FrmFormCidade(new Cidade()))
                    {
                        using (FrmModal frmModal = new FrmModal(frm))
                            frmModal.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            CarregarGrid();
                    }
                else
                    MessageBox.Show("Por favor, antes de cadastrar uma cidade, cadastre um estado para suas cidades.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (cidade != null)
                using (FrmFormCidade frm = new FrmFormCidade(cidade))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona uma cidade para altera-la.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        protected override async void CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodasCidades();
        }

        protected override void Remover()
        {
            base.Remover();
        }

        private async Task<List<Cidade>> SelecionarTodasCidades()
        {
            using (CidadeRepository repository = new CidadeRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                cidade = (Cidade)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
