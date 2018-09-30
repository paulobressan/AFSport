namespace AFSport.Questionario.Formularios
{
    partial class FrmAgradecimento
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctBoxParabens = new System.Windows.Forms.PictureBox();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxParabens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(231, 32);
            this.lblTitulo.Text = "Agradecimentos";
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 293);
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
            this.pnlGeral.Controls.Add(this.pctBoxParabens);
            this.pnlGeral.Controls.Add(this.label1);
            this.pnlGeral.Controls.Add(this.txtMensagem);
            this.pnlGeral.Size = new System.Drawing.Size(400, 223);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMensagem.Location = new System.Drawing.Point(10, 10);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(380, 63);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "Obrigado por deixar a sua opnião.\r\nEla é muito importante no desenvolvimento do s" +
    "oftware.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Você esta participando do Sorteio!";
            // 
            // pctBoxParabens
            // 
            this.pctBoxParabens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBoxParabens.Image = global::AFSport.Questionario.Properties.Resources.parabens;
            this.pctBoxParabens.Location = new System.Drawing.Point(72, 79);
            this.pctBoxParabens.Name = "pctBoxParabens";
            this.pctBoxParabens.Size = new System.Drawing.Size(240, 98);
            this.pctBoxParabens.TabIndex = 2;
            this.pctBoxParabens.TabStop = false;
            // 
            // FrmAgradecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 343);
            this.Name = "FrmAgradecimento";
            this.Text = "FrmAgradecimento";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxParabens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.PictureBox pctBoxParabens;
    }
}