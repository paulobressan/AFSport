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

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarFormulario();
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtNome.Text))
                Salvar();
            else
                MessageBox.Show("Campo nome obrigatório","Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnSalvar_Click(sender, e);
        }
        protected override void MontarFormulario()
        {
            base.MontarFormulario();
            LblId.Text = _categoria.IdCategoria.ToString();
            TxtDescricao.Text = _categoria.Descricao;
            TxtNome.Text = _categoria.Nome;
            chkAtivo.Checked = _categoria.IsAtivo;
        }

        protected override async void Salvar()
        {
            using (CategoriaRepository repository = new CategoriaRepository())
            {
               await repository.Salvar(new Categoria(
                    TxtNome.Text,
                    TxtDescricao.Text)
                {
                    IdCategoria = _categoria.IdCategoria,
                    IsAtivo = chkAtivo.Checked
                });
                DialogResult = DialogResult.OK;
            }
        }
    }
}
