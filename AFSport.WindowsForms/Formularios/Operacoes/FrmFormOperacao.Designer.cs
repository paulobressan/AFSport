namespace AFSport.WindowsForms.Formularios.Operacoes
{
    partial class FrmFormOperacao
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
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
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 311);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(323, 32);
            this.lblTitulo.Text = "Cadastro de Operações";
            // 
            // lblIcone
            // 
            this.lblIcone.Text = "";
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.chkAtivo);
            this.pblMain.Controls.Add(this.txtDescricao);
            this.pblMain.Controls.Add(this.lblDescricao);
            this.pblMain.Controls.Add(this.txtNome);
            this.pblMain.Controls.Add(this.lblNome);
            this.pblMain.Size = new System.Drawing.Size(600, 241);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.lblNome, 0);
            this.pblMain.Controls.SetChildIndex(this.txtNome, 0);
            this.pblMain.Controls.SetChildIndex(this.lblDescricao, 0);
            this.pblMain.Controls.SetChildIndex(this.txtDescricao, 0);
            this.pblMain.Controls.SetChildIndex(this.chkAtivo, 0);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 120);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 172);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(577, 26);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 149);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 20);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAtivo.Location = new System.Drawing.Point(14, 204);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 24);
            this.chkAtivo.TabIndex = 5;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmFormOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmFormOperacao";
            this.Text = "FrmFormOperacao";
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

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}