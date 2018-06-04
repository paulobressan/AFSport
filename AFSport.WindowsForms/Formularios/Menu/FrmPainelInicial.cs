using AFSport.Service.Model;
using AFSport.WindowsForms.Formularios.Caixas;
using AFSport.WindowsForms.Formularios.Categorias;
using AFSport.WindowsForms.Formularios.Cidades;
using AFSport.WindowsForms.Formularios.Clientes;
using AFSport.WindowsForms.Formularios.Estados;
using AFSport.WindowsForms.Formularios.Estoques;
using AFSport.WindowsForms.Formularios.Movimentacoes;
using AFSport.WindowsForms.Formularios.Operacoes;
using AFSport.WindowsForms.Formularios.Pedidos;
using AFSport.WindowsForms.Formularios.Precos;
using AFSport.WindowsForms.Formularios.Produtos;
using AFSport.WindowsForms.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Menu
{
    public partial class FrmPainelInicial : Form
    {
        Form form;
        Usuario usuario;
        public FrmPainelInicial(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void RenderForm(Form formRender)
        {
            Cursor = Cursors.WaitCursor;
            if (form != null) form.Close();
            form = formRender;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlGeral.Controls.Add(form);
            form.Show();
            Cursor = Cursors.Default;
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmClientes());
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCategorias());
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmProdutos(usuario));
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstoque(usuario));
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstados());
        }

        private void BtnCidades_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCidades());
        }

        private void BtnPrecos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPrecos());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmUsuarios());
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCaixa(usuario));
        }

        private void BtnMovimentacao_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmMovimentacoes(usuario));
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPedidos(usuario));
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Construção.");
        }

        private void BtnOperacao_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmOperacoes());
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/paulobressan/AFSport");
        }
    }
}
