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
    public partial class FrmFormCidade : FrmFormularioBase
    {
        Cidade cidade;
        public FrmFormCidade(Cidade cidade)
        {
            InitializeComponent();
            this.cidade = cidade;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            CarregarCmbEstados();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(cmbEstado.SelectedValue == null)
                MessageBox.Show("Seleção de estado obrigatória", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        protected override async void Salvar()
        {
            using (CidadeRepository repository = new CidadeRepository())
            {
                await repository.Salvar(new Cidade(
                    txtNome.Text,
                    (int)cmbEstado.SelectedValue
                    )
                {
                    IdCidade = cidade.IdCidade,
                    IsAtivo = chkAtivo.Checked
                });

                DialogResult = DialogResult.OK;
            }
        }

        protected override void MontarFormulario()
        {
            LblId.Text = cidade.IdCidade.ToString();
            txtNome.Text = cidade.Nome;
            chkAtivo.Checked = cidade.IsAtivo;
            cmbEstado.SelectedValue = cidade?.Estado?.IdEstado ?? 0;
        }

        private async void CarregarCmbEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.DataSource = await SelecionarTodosEstados();
            cmbEstado.DisplayMember = "Nome";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.Refresh();
            MontarFormulario();
        }

        private async Task<List<Estado>> SelecionarTodosEstados()
        {
            using (EstadoRepository repository = new EstadoRepository())
            {
                return await repository.SelecionarTodos(false);
            }
        }
    }
}
