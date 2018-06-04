using AFSport.Service.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Pedidos
{
    public partial class FrmFinalizadora : Form
    {
        public Movimentacao movimentacao;
        Pedido pedido;
        Usuario usuario;
        public FrmFinalizadora(Pedido pedido, Usuario usuario)
        {
            InitializeComponent();
            this.pedido = pedido;
            this.usuario = usuario;
        }

        private void FrmFinalizadora_Load(object sender, EventArgs e)
        {
            MontarFormulario();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(TxtValorPagar.Text) < pedido.CalcularPedido())
                MessageBox.Show("Valor a pagar não corresponde ao valor do pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                movimentacao = this.GerarMovimentacao();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma em cancelar a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }          
        }

        private void MontarFormulario()
        {
            txtValor.Text = pedido.CalcularPedido().ToString();
        }

        private Movimentacao GerarMovimentacao()
        {
            return new Movimentacao(pedido.CalcularPedido(), usuario.IdUsuario, 1);
        }

        private void TxtValorPagar_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(TxtValorPagar.Text))
                txtTroco.Text = pedido.CalcularTroco(Convert.ToDecimal(TxtValorPagar.Text)).ToString();
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
