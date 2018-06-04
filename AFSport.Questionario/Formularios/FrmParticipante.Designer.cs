namespace AFSport.Questionario.Formularios
{
    partial class FrmParticipante
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
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(172, 32);
            this.lblTitulo.Text = "Participante";
            // 
            // btnVoltar
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
            this.pnlGeral.Controls.Add(this.txtTelefone);
            this.pnlGeral.Controls.Add(this.lblTelefone);
            this.pnlGeral.Controls.Add(this.txtNome);
            this.pnlGeral.Controls.Add(this.lblNome);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(12, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefone.Location = new System.Drawing.Point(14, 81);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 102);
            this.txtTelefone.Mask = "(99)99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(122, 26);
            this.txtTelefone.TabIndex = 3;
            // 
            // FrmParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmParticipante";
            this.Text = "FrmParticipante";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}