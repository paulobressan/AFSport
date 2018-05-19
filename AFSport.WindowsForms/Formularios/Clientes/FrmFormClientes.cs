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

namespace AFSport.WindowsForms.Formularios.Clientes
{
    public partial class FrmFormClientes : FrmFormularioBase
    {
        Cliente cliente;
        bool montarFormulario = true;
        public FrmFormClientes(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
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
            else if (String.IsNullOrEmpty(txtLogradouro.Text))
                MessageBox.Show("Campo Logradouro obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtBairro.Text))
                MessageBox.Show("Campo Bairro obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtNumero.Text))
                MessageBox.Show("Campo Numero obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbCidade.SelectedValue == null)
                MessageBox.Show("Seleção de cidade obrigatória", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        protected override async void Salvar()
        {
            using (ClienteRepository repository = new ClienteRepository())
            {
                await repository.Salvar(new Cliente(
                    txtNome.Text,
                    txtLogradouro.Text,
                    txtBairro.Text,
                    Convert.ToInt16(txtNumero.Text),
                    (int)cmbCidade.SelectedValue
                    )
                {
                    IdCliente = cliente.IdCliente,
                    Email = txtEmail.Text
                });
                DialogResult = DialogResult.OK;
            }
        }

        protected override void MontarFormulario()
        {
            LblId.Text = cliente.IdCliente.ToString();
            txtNome.Text = cliente.Nome;
            txtLogradouro.Text = cliente.Logradouro;
            txtEmail.Text = cliente.Email;
            txtBairro.Text = cliente.Bairro;
            txtNumero.Text = cliente.Numero.ToString();
            CmbEstados.SelectedValue = cliente?.Cidade?.Estado?.IdEstado ?? 0;
            cmbCidade.SelectedValue = cliente?.Cidade?.IdCidade ?? 0;
        }

        private async void CarregarCmbCidades()
        {
            cmbCidade.DataSource = await SelecionarTodasCidadesPorEstado();
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "IdCidade";
            cmbCidade.Refresh();
            if (montarFormulario) MontarFormulario();
        }

        private async void CarregarCmbEstados()
        {
            CmbEstados.DataSource = await SelecionarTodosEstados();
            CmbEstados.DisplayMember = "Sigla";
            CmbEstados.ValueMember = "IdEstado";
            CmbEstados.Refresh();
            CarregarCmbCidades();
        }

        private async Task<List<Cidade>> SelecionarTodasCidadesPorEstado()
        {
            using (CidadeRepository repository = new CidadeRepository())
                return await repository.SelecionarTodosPorEstado((int)CmbEstados.SelectedValue);
        }
        private async Task<List<Estado>> SelecionarTodosEstados()
        {
            using (EstadoRepository repository = new EstadoRepository())
                return await repository.SelecionarTodos(false);
        }

        private void CmbEstados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            montarFormulario = false;
            CarregarCmbCidades();
        }
    }
}
