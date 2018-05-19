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

namespace AFSport.WindowsForms.Formularios.Estados
{
    public partial class FrmEstados : FrmCadastroBase
    {
        Estado estado;
        public FrmEstados()
        {
            InitializeComponent();
        }

        protected override void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            using(FrmFormEstado frm = new FrmFormEstado(new Estado()))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    CarregarGrid();
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(estado != null)
                using (FrmFormEstado frm = new FrmFormEstado(estado))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um estado para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        protected override async void CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosEstados();
        }

        protected override void Remover()
        {
            base.Remover();
        }

        private async Task<List<Estado>> SelecionarTodosEstados()
        {
            using(EstadoRepository repository = new EstadoRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                estado = (Estado)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
