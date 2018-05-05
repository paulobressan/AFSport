using AFSport.DAO.Model;
using AFSport.Service.DAO;
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

namespace AFSport.WindowsForms.Formularios.Categorias
{
    public partial class FrmFormulario : FrmFormularioBase
    {
        Categoria Categoria;
     
        public FrmFormulario(Categoria categoria)
        {
            InitializeComponent();
            this.Categoria = categoria;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            PreencherFormulario(this.Categoria);
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Replace(" ", "") != "")
                Salvar();
            else
                MessageBox.Show("Nome obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnSalvar_Click(sender, e);
        }

        private void Salvar()
        {
            using(CategoriaDAO dao = new CategoriaDAO())
            {
                var categoria = new Categoria(
                    txtNome.Text,
                    txtDescricao.Text)
                {
                    Id = Convert.ToInt16(lblId.Text)
                };
                var obj = dao.Salvar(categoria);
            }
        }

        private void PreencherFormulario(Categoria categoria)
        {
            lblId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            txtDescricao.Text = categoria.Descricao;
        }
    }
}
