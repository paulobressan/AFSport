using AFSport.WindowsForms.Formularios.Categorias;
using AFSport.WindowsForms.Formularios.Cidades;
using AFSport.WindowsForms.Formularios.Clientes;
using AFSport.WindowsForms.Formularios.Estados;
using AFSport.WindowsForms.Formularios.Estoques;
using AFSport.WindowsForms.Formularios.Produtos;
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
        public FrmPainelInicial()
        {
            InitializeComponent();
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
            RenderForm(new FrmProdutos());
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstoque());
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstados());
        }

        private void BtnCidades_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCidades());
        }
    }
}
