using AFSport.Service.Model;
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
        //private readonly ICategoriaService _categoriaService;
        public FrmCategorias()
        {
            InitializeComponent();
            //_categoriaService = new CategoriaService();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
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
            base.FrmCadastroBase_Load(sender, e);
            //gridPesq.DataSource = ListarTodasCategorias();
        }

        //private List<Categoria> ListarTodasCategorias()
        //{

            //return _categoriaService.RetornarTodasCategorias().ToList();
        //}
    }
}
