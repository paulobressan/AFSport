namespace AFSport.WindowsForms.Formularios.Movimentacoes
{
    partial class FrmFormMovimentacao
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.pnlBtns.SuspendLayout();
            this.pblHead.SuspendLayout();
            this.pblMain.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(120, 6);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Location = new System.Drawing.Point(8, 6);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 288);
            this.pnlBtns.Size = new System.Drawing.Size(239, 89);
            // 
            // pblHead
            // 
            this.pblHead.Size = new System.Drawing.Size(239, 50);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(186, 11);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(74, 32);
            this.lblTitulo.Text = "Mov.";
            // 
            // lblIcone
            // 
            this.lblIcone.Size = new System.Drawing.Size(40, 28);
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.Size = new System.Drawing.Size(239, 10);
            // 
            // pnlbar2
            // 
            this.pnlbar2.Size = new System.Drawing.Size(239, 10);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.cmbOperacao);
            this.pblMain.Controls.Add(this.lblOperacao);
            this.pblMain.Controls.Add(this.txtValor);
            this.pblMain.Controls.Add(this.lblValor);
            this.pblMain.Size = new System.Drawing.Size(239, 218);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.lblValor, 0);
            this.pblMain.Controls.SetChildIndex(this.txtValor, 0);
            this.pblMain.Controls.SetChildIndex(this.lblOperacao, 0);
            this.pblMain.Controls.SetChildIndex(this.cmbOperacao, 0);
            // 
            // pnlId
            // 
            this.pnlId.Size = new System.Drawing.Size(223, 78);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 91);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 20);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(7, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(64, 26);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(3, 143);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(68, 20);
            this.lblOperacao.TabIndex = 3;
            this.lblOperacao.Text = "Operação";
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Location = new System.Drawing.Point(7, 166);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(223, 28);
            this.cmbOperacao.TabIndex = 4;
            // 
            // FrmFormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 377);
            this.Name = "FrmFormMovimentacao";
            this.Text = "FrmFormMovimentacao";
            this.pnlBtns.ResumeLayout(false);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pblMain.ResumeLayout(false);
            this.pblMain.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}