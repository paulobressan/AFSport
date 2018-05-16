namespace AFSport.WindowsForms.Formularios.Categorias
{
    partial class FrmFormCategoria
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
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // pblHead
            // 
            this.pblHead.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(217, 32);
            this.lblTitulo.Text = "Nova Categoria";
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
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(34, 102);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(45, 20);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(10, 158);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(69, 20);
            this.LblDescricao.TabIndex = 2;
            this.LblDescricao.Text = "Descrição";
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Location = new System.Drawing.Point(85, 100);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(642, 26);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescricao.Location = new System.Drawing.Point(85, 156);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(642, 80);
            this.TxtDescricao.TabIndex = 5;
            // 
            // FrmFormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 632);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmFormCategoria";
            this.Text = "FrmFormulario";
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

        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblNome;
    }
}