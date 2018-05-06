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
        private readonly CategoriaDAO _categoriaDao;
        public FrmCategorias()
        {
            InitializeComponent();
            this._categoriaDao = new CategoriaDAO();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmFormulario form = new FrmFormulario())
            {
                using (FrmModal modal = new FrmModal(form))
                {
                    modal.ShowDialog();
                }

            }

        }

        protected override void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            gridPesq.DataSource = ListarTodasCategorias();
            base.FrmCadastroBase_Load(sender, e);
        }

        private List<Categoria> ListarTodasCategorias()
        {
            return _categoriaDao.SelecionarTodos();
        }
    }
}
