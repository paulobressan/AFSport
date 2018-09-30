using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Relatorios
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            FrmRelatorioCaixa frm = new FrmRelatorioCaixa();
            frm.Show();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorioMovimentacao frm = new FrmRelatorioMovimentacao();
            frm.Show();
        }
    }
}
