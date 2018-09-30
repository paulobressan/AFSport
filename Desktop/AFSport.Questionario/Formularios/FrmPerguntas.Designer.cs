namespace AFSport.Questionario.Formularios
{
    partial class FrmPerguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.ChkListBox = new System.Windows.Forms.CheckedListBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.toolTipPerguntas = new System.Windows.Forms.ToolTip();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 434);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // BtnProximo
            // 
            this.BtnProximo.FlatAppearance.BorderSize = 0;
            this.BtnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.TxtObservacao);
            this.pnlGeral.Controls.Add(this.ChkListBox);
            this.pnlGeral.Controls.Add(this.txtPergunta);
            this.pnlGeral.Size = new System.Drawing.Size(400, 364);
            // 
            // txtPergunta
            // 
            this.txtPergunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPergunta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPergunta.Location = new System.Drawing.Point(10, 10);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(380, 72);
            this.txtPergunta.TabIndex = 0;
            // 
            // ChkListBox
            // 
            this.ChkListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChkListBox.FormattingEnabled = true;
            this.ChkListBox.Location = new System.Drawing.Point(10, 82);
            this.ChkListBox.Name = "ChkListBox";
            this.ChkListBox.Size = new System.Drawing.Size(380, 126);
            this.ChkListBox.TabIndex = 1;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtObservacao.Location = new System.Drawing.Point(10, 214);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(380, 140);
            this.TxtObservacao.TabIndex = 4;
            this.toolTipPerguntas.SetToolTip(this.TxtObservacao, "Observações");
            // 
            // FrmPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 484);
            this.Name = "FrmPerguntas";
            this.Text = "FrmPerguntas";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.CheckedListBox ChkListBox;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.ToolTip toolTipPerguntas;
    }
}