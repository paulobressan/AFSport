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
    public partial class FrmParticipante : FrmQuestionarioBase
    {
        Participante participante;
        public FrmParticipante()
        {
            InitializeComponent();
        }

        protected override async void BtnProximo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (ParticipanteRepository repository = new ParticipanteRepository())
            {
                participante = await repository.Salvar(new Participante()
                {
                    IdParticipante = 0,
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text
                });
                Cursor = Cursors.Default;
                using (FrmPerguntas frmPergunta = new FrmPerguntas(participante, 1))
                {
                    frmPergunta.ShowDialog();
                    using (FrmAgradecimento frmAgradecimento = new FrmAgradecimento())
                    {
                        frmAgradecimento.ShowDialog();
                        Close();
                    }
                }
            }
            base.BtnProximo_Click(sender, e);
        }
    }
}
