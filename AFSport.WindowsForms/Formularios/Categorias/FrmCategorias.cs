using AFSport.DAO.Model;
using AFSport.Service.DAO;
using AFSport.WindowsForms.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Categorias
{
    public partial class FrmCategorias : FrmCadastroBase
    {
        private Categoria Categoria;
        private List<Categoria> ListaCategoria;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmFormulario form = new FrmFormulario(new Categoria()))
            {
                using (FrmModal modal = new FrmModal(form))
                {
                    modal.ShowDialog();
                }
            }
        }

        protected override void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.DataSource = ListarTodasCategorias();
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(Categoria != null)
            {
                using (FrmFormulario form = new FrmFormulario(Categoria))
                {
                    using (FrmModal modal = new FrmModal(form))
                    {
                        modal.ShowDialog();
                    }
                }
            }
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        private List<Categoria> ListarTodasCategorias()
        {
            using(CategoriaDAO dao = new CategoriaDAO())
            {
                return dao.SelecionarTodos();
            } 
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
            {
                this.Categoria = new Categoria();
                this.Categoria = (Categoria) GridPesq.SelectedRows[0].DataBoundItem;
            }
        }

        private List<Categoria> Filtrar(string valor)
        {
            ListaCategoria
        }
    }
}
