using AFSport.Questionario.Formularios.Base;
using AFSport.Questionario.Models;
using AFSport.Questionario.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.Questionario.Formularios
{
    public partial class FrmSorteio : FrmQuestionarioBase
    {
        public FrmSorteio()
        {
            InitializeComponent();
        }

        protected override async void BtnProximo_Click(object sender, EventArgs e)
        {
            Limpar();
            await Sortear();
            base.BtnProximo_Click(sender, e);
        }

        private void Limpar()
        {
            lblNomeResultado.Text = "";
            lblTelefoneResultado.Text = "";
        }

        private async Task Sortear()
        {
            Random sorteio = new Random();
            var participantes = await SelecionarParticipantes();
            var min = participantes.FirstOrDefault().IdParticipante;
            var max = participantes.LastOrDefault().IdParticipante;
            var numero = sorteio.Next(min, max);
            var participanteSorteado = participantes.Find(p => p.IdParticipante == numero);
            lblNomeResultado.Text = participanteSorteado.Nome;
            lblTelefoneResultado.Text = participanteSorteado.Telefone;
            pnlResultado.Visible = true;
        }

        private async Task<List<Participante>> SelecionarParticipantes()
        {
            using (ParticipanteRepository repository = new ParticipanteRepository())
            {
                return await repository.SelecionarTodos();
            }
        }
    }
}
