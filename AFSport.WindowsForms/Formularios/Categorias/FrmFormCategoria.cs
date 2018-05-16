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
    public partial class FrmFormCategoria : FrmFormularioBase
    {
        private readonly Categoria _categoria;
        public FrmFormCategoria(Categoria categoria)
        {
            InitializeComponent();
            _categoria = categoria;
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Length > 0)
                Salvar();
            else
                MessageBox.Show("Campo nome obrigatório","Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnSalvar_Click(sender, e);
        }
        protected override void MontarFormulario()
        {
            base.MontarFormulario();
            LblId.Text = _categoria.Id.ToString();
            TxtDescricao.Text = _categoria.Descricao;
            TxtNome.Text = _categoria.Nome;
        }

        protected override async void Salvar()
        {
            using (CategoriaDAO dao = new CategoriaDAO())
            {
               await dao.Salvar(new Categoria(
                    TxtNome.Text,
                    TxtDescricao.Text)
                {
                    Id = _categoria.Id
                });
                DialogResult = DialogResult.OK;
            }
        }
    }
}
