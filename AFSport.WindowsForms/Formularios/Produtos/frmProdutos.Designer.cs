namespace AFSport.WindowsForms.Formularios.Produtos
{
    partial class FrmProdutos
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
            this.components = new System.ComponentModel.Container();
            this.GridPesq = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGerarEstoque = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNavBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNovo.Location = new System.Drawing.Point(985, 6);
            // 
            // btnAlterar
            // 
            this.BtnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnAlterar.Location = new System.Drawing.Point(1097, 6);
            // 
            // btnDeletar
            // 
            this.BtnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDeletar.Location = new System.Drawing.Point(1209, 6);
            // 
            // pnlmargin
            // 
            this.pnlmargin.Size = new System.Drawing.Size(1329, 14);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.BtnGerarEstoque);
            this.pnlNavBar.Size = new System.Drawing.Size(1329, 89);
            this.pnlNavBar.Controls.SetChildIndex(this.BtnDeletar, 0);
            this.pnlNavBar.Controls.SetChildIndex(this.BtnAlterar, 0);
            this.pnlNavBar.Controls.SetChildIndex(this.BtnNovo, 0);
            this.pnlNavBar.Controls.SetChildIndex(this.lblTitulo, 0);
            this.pnlNavBar.Controls.SetChildIndex(this.label1, 0);
            this.pnlNavBar.Controls.SetChildIndex(this.BtnGerarEstoque, 0);
            // 
            // pnlmargin2
            // 
            this.pnlmargin2.Size = new System.Drawing.Size(1329, 14);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.GridPesq);
            this.pnlBody.Size = new System.Drawing.Size(1329, 505);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(51, 36);
            this.lblTitulo.Text = "";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.Text = "Produtos";
            // 
            // GridPesq
            // 
            this.GridPesq.AllowUserToAddRows = false;
            this.GridPesq.AllowUserToDeleteRows = false;
            this.GridPesq.AllowUserToResizeColumns = false;
            this.GridPesq.AllowUserToResizeRows = false;
            this.GridPesq.BackgroundColor = System.Drawing.Color.White;
            this.GridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.nome,
            this.descricao,
            this.categoria,
            this.valorCompra,
            this.valorVenda,
            this.isAtivo,
            this.idCategoria});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(6, 6);
            this.GridPesq.Margin = new System.Windows.Forms.Padding(4);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.RowHeadersVisible = false;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(1315, 491);
            this.GridPesq.TabIndex = 0;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "IdProduto";
            this.idProduto.HeaderText = "Código";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 50;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // valorCompra
            // 
            this.valorCompra.DataPropertyName = "ValorCompra";
            this.valorCompra.HeaderText = "Valor de Compra";
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.ReadOnly = true;
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "ValorVenda";
            this.valorVenda.HeaderText = "Valor de Venda";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // isAtivo
            // 
            this.isAtivo.DataPropertyName = "IsAtivo";
            this.isAtivo.HeaderText = "Ativo";
            this.isAtivo.Name = "isAtivo";
            this.isAtivo.ReadOnly = true;
            this.isAtivo.Width = 50;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // BtnGerarEstoque
            // 
            this.BtnGerarEstoque.BackColor = System.Drawing.Color.Transparent;
            this.BtnGerarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGerarEstoque.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnGerarEstoque.FlatAppearance.BorderSize = 0;
            this.BtnGerarEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnGerarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarEstoque.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.BtnGerarEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGerarEstoque.Location = new System.Drawing.Point(873, 6);
            this.BtnGerarEstoque.Name = "BtnGerarEstoque";
            this.BtnGerarEstoque.Size = new System.Drawing.Size(112, 75);
            this.BtnGerarEstoque.TabIndex = 8;
            this.BtnGerarEstoque.Text = "";
            this.ToolTip.SetToolTip(this.BtnGerarEstoque, "Gerar Estoque");
            this.BtnGerarEstoque.UseVisualStyleBackColor = false;
            this.BtnGerarEstoque.Click += new System.EventHandler(this.BtnGerarEstoque_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 622);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdutos";
            this.Text = "frmProdutos";
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.Button BtnGerarEstoque;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}