namespace AFSport.Questionario.Formularios
{
    partial class FrmSorteio
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
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblTelefoneResultado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeResultado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(111, 32);
            this.lblTitulo.Text = "Sortear";
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
            this.pnlGeral.Controls.Add(this.label1);
            this.pnlGeral.Controls.Add(this.pnlResultado);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.lblTelefoneResultado);
            this.pnlResultado.Controls.Add(this.lblTelefone);
            this.pnlResultado.Controls.Add(this.lblNomeResultado);
            this.pnlResultado.Controls.Add(this.lblNome);
            this.pnlResultado.Location = new System.Drawing.Point(13, 47);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(374, 85);
            this.pnlResultado.TabIndex = 0;
            this.pnlResultado.Visible = false;
            // 
            // lblTelefoneResultado
            // 
            this.lblTelefoneResultado.AutoSize = true;
            this.lblTelefoneResultado.Location = new System.Drawing.Point(89, 45);
            this.lblTelefoneResultado.Name = "lblTelefoneResultado";
            this.lblTelefoneResultado.Size = new System.Drawing.Size(78, 18);
            this.lblTelefoneResultado.TabIndex = 7;
            this.lblTelefoneResultado.Text = "Resultado";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(17, 45);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 18);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNomeResultado
            // 
            this.lblNomeResultado.AutoSize = true;
            this.lblNomeResultado.Location = new System.Drawing.Point(89, 16);
            this.lblNomeResultado.Name = "lblNomeResultado";
            this.lblNomeResultado.Size = new System.Drawing.Size(50, 18);
            this.lblNomeResultado.TabIndex = 5;
            this.lblNomeResultado.Text = "Nome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boa Sorte!";
            // 
            // FrmSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmSorteio";
            this.Text = "FrmSorteio";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblTelefoneResultado;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeResultado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
    }
}