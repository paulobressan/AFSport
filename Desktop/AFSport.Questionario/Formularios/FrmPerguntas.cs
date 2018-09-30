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
    public partial class FrmPerguntas : FrmQuestionarioBase
    {
        Participante participante;
        int sequencia;
        Pergunta pergunta;
        public FrmPerguntas(Participante participante, int sequencia)
        {
            InitializeComponent();
            this.participante = participante;
            this.sequencia = sequencia;
        }

        protected override async void FrmQuestionarioBase_Load(object sender, EventArgs e)
        {
            await SelecionarPergunta(sequencia);
            await MontarListaRespostaChk();
            base.FrmQuestionarioBase_Load(sender, e);
        }

        protected override async void BtnProximo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (RespostaRepository repository = new RespostaRepository())
            {
                var respostaSelecionada = (TipoResposta)ChkListBox.SelectedItem;
                var resposta = await repository.Salvar(new Resposta(
                    participante.IdParticipante,
                    respostaSelecionada?.IdTipoResposta ?? null,
                    pergunta.IdPergunta)
                {
                    IdResposta = 0,
                    Observacao = TxtObservacao.Text

                });
                Cursor = Cursors.Default;
                if (await SelecionarPergunta(sequencia + 1) != null)
                    using (FrmPerguntas frmPergunta = new FrmPerguntas(participante, ++sequencia))
                    {
                        frmPergunta.ShowDialog();
                        Close();
                    }
                else
                    Close();
            }
            base.BtnProximo_Click(sender, e);
        }

        private async Task MontarListaRespostaChk()
        {
            foreach (var resposta in await RetornarRespostas())
            {
                ChkListBox.Items.Add(resposta);
            }
        }

        private async Task<List<TipoResposta>> RetornarRespostas()
        {
            using (TipoRespostaRepository repository = new TipoRespostaRepository())
            {
                return await repository.SelecionarPorPergunta(pergunta.IdPergunta);
            }
        }

        private async Task<Pergunta> SelecionarPergunta(int sequencia)
        {
            using (PerguntaRepository repository = new PerguntaRepository())
            {
                pergunta = await repository.SelecionarPorSequencia(sequencia);
                txtPergunta.Text = pergunta?.Descricao ?? "";
                return pergunta;
            }
        }
    }
}
