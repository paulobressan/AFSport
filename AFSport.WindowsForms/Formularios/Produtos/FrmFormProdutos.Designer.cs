namespace AFSport.WindowsForms.Formularios.Produtos
{
    partial class FrmFormProdutos
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
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
            this.pnlBtns.Location = new System.Drawing.Point(0, 434);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(547, 11);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(303, 32);
            this.lblTitulo.Text = "Cadastro de Produtos";
            // 
            // lblIcone
            // 
            this.lblIcone.Size = new System.Drawing.Size(40, 28);
            this.lblIcone.Text = "";
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.chkAtivo);
            this.pblMain.Controls.Add(this.cmbCategoria);
            this.pblMain.Controls.Add(this.txtValorVenda);
            this.pblMain.Controls.Add(this.txtValorCompra);
            this.pblMain.Controls.Add(this.txtDescricao);
            this.pblMain.Controls.Add(this.txtNome);
            this.pblMain.Controls.Add(this.lblCategoria);
            this.pblMain.Controls.Add(this.lblValorVenda);
            this.pblMain.Controls.Add(this.lblValorCompra);
            this.pblMain.Controls.Add(this.lblDescricao);
            this.pblMain.Controls.Add(this.lblNome);
            this.pblMain.Size = new System.Drawing.Size(600, 364);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.lblNome, 0);
            this.pblMain.Controls.SetChildIndex(this.lblDescricao, 0);
            this.pblMain.Controls.SetChildIndex(this.lblValorCompra, 0);
            this.pblMain.Controls.SetChildIndex(this.lblValorVenda, 0);
            this.pblMain.Controls.SetChildIndex(this.lblCategoria, 0);
            this.pblMain.Controls.SetChildIndex(this.txtNome, 0);
            this.pblMain.Controls.SetChildIndex(this.txtDescricao, 0);
            this.pblMain.Controls.SetChildIndex(this.txtValorCompra, 0);
            this.pblMain.Controls.SetChildIndex(this.txtValorVenda, 0);
            this.pblMain.Controls.SetChildIndex(this.cmbCategoria, 0);
            this.pblMain.Controls.SetChildIndex(this.chkAtivo, 0);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 91);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 144);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(153, 214);
            this.lblValorVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(83, 20);
            this.lblValorVenda.TabIndex = 4;
            this.lblValorVenda.Text = "Valor Venda";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(12, 214);
            this.lblValorCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(91, 20);
            this.lblValorCompra.TabIndex = 3;
            this.lblValorCompra.Text = "Valor Compra";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 270);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 20);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(16, 113);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(575, 26);
            this.txtNome.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(16, 169);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(575, 40);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCompra.Location = new System.Drawing.Point(16, 239);
            this.txtValorCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(113, 26);
            this.txtValorCompra.TabIndex = 9;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(157, 239);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(113, 26);
            this.txtValorVenda.TabIndex = 10;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(16, 295);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(254, 28);
            this.cmbCategoria.TabIndex = 11;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAtivo.Location = new System.Drawing.Point(15, 333);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 24);
            this.chkAtivo.TabIndex = 12;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmFormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 523);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFormProdutos";
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

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
    }
}