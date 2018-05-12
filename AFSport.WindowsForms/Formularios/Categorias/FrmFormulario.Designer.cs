namespace AFSport.WindowsForms.Formularios.Categorias
{
    partial class FrmFormulario
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pblMain.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // pblHead
            // 
            this.pblHead.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // panel2
            // 
            this.pnlBtns.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.TxtDescricao);
            this.pblMain.Controls.Add(this.TxtNome);
            this.pblMain.Controls.Add(this.LblDescricao);
            this.pblMain.Controls.Add(this.LblNome);
            this.pblMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.LblNome, 0);
            this.pblMain.Controls.SetChildIndex(this.LblDescricao, 0);
            this.pblMain.Controls.SetChildIndex(this.TxtNome, 0);
            this.pblMain.Controls.SetChildIndex(this.TxtDescricao, 0);
            // 
            // label1
            // 
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblTitulo.Size = new System.Drawing.Size(217, 32);
            this.lblTitulo.Text = "Nova Categoria";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(41, 68);
            this.LblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 18);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(13, 106);
            this.LblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(80, 18);
            this.LblDescricao.TabIndex = 2;
            this.LblDescricao.Text = "Descrição";
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Location = new System.Drawing.Point(91, 66);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(482, 26);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescricao.Location = new System.Drawing.Point(91, 103);
            this.TxtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(482, 53);
            this.TxtDescricao.TabIndex = 5;
            // 
            // FrmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFormulario";
            this.Text = "FrmFormulario";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pblMain.ResumeLayout(false);
            this.pblMain.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblNome;
    }
}