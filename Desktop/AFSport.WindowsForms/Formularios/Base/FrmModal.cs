using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Base
{
    public partial class FrmModal : Form
    {
        Form form;
        public FrmModal(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void FrmModal_Load(object sender, EventArgs e)
        {
            form.ShowDialog();
            Close();
        }
    }
}
