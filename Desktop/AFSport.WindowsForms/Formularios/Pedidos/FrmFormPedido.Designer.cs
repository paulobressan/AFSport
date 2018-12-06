namespace AFSport.WindowsForms.Formularios.Pedidos
{
    partial class FrmFormPedido
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
            this.pnlItens = new System.Windows.Forms.Panel();
            this.pnlValorTotal = new System.Windows.Forms.Panel();
            this.lblPreco = new System.Windows.Forms.Label();
            this.pnlOperacoesItens = new System.Windows.Forms.Panel();
            this.BtnRemoverItem = new System.Windows.Forms.Button();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.IdItemPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTituloItens = new System.Windows.Forms.Panel();
            this.lblTituloItens = new System.Windows.Forms.Label();
            this.lblIcoTituloItens = new System.Windows.Forms.Label();
            this.pnlSelecoes = new System.Windows.Forms.Panel();
            this.pnlSelecaoProdutos = new System.Windows.Forms.Panel();
            this.pnlProdutosSelecao = new System.Windows.Forms.Panel();
            this.pnlProdutosOperacoes = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProdutoPesquisa = new System.Windows.Forms.Panel();
            this.BtnProdutoPesquisar = new System.Windows.Forms.Button();
            this.TxtProdutoPesquisa = new System.Windows.Forms.TextBox();
            this.pnlProdutoTitulo = new System.Windows.Forms.Panel();
            this.lblProdutoTitulo = new System.Windows.Forms.Label();
            this.lblIconProdutoTitulo = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblClienteEnderecoTexto = new System.Windows.Forms.Label();
            this.lblClienteEndereco = new System.Windows.Forms.Label();
            this.lblClienteNomeTexto = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.BtnSelecaoCliente = new System.Windows.Forms.Button();
            this.pnlClienteTitulo = new System.Windows.Forms.Panel();
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.lblIconClienteTitulo = new System.Windows.Forms.Label();
            this.ToolTipTexto = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBtns.SuspendLayout();
            this.pblHead.SuspendLayout();
            this.pblMain.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlItens.SuspendLayout();
            this.pnlValorTotal.SuspendLayout();
            this.pnlOperacoesItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.pnlTituloItens.SuspendLayout();
            this.pnlSelecoes.SuspendLayout();
            this.pnlSelecaoProdutos.SuspendLayout();
            this.pnlProdutosSelecao.SuspendLayout();
            this.pnlProdutosOperacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.pnlProdutoPesquisa.SuspendLayout();
            this.pnlProdutoTitulo.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlClienteTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(904, 6);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Size = new System.Drawing.Size(101, 75);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Location = new System.Drawing.Point(803, 6);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalvar.Size = new System.Drawing.Size(101, 75);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 661);
            this.pnlBtns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBtns.Size = new System.Drawing.Size(1012, 89);
            // 
            // pblHead
            // 
            this.pblHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pblHead.Size = new System.Drawing.Size(1012, 50);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(941, 0);
            this.lblSair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(274, 32);
            this.lblTitulo.Text = "Cadastro de Pedido";
            // 
            // lblIcone
            // 
            this.lblIcone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcone.Size = new System.Drawing.Size(44, 28);
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.Size = new System.Drawing.Size(1012, 10);
            // 
            // pnlbar2
            // 
            this.pnlbar2.Size = new System.Drawing.Size(1012, 10);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.pnlSelecoes);
            this.pblMain.Controls.Add(this.pnlItens);
            this.pblMain.Padding = new System.Windows.Forms.Padding(8);
            this.pblMain.Size = new System.Drawing.Size(1012, 591);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.pnlItens, 0);
            this.pblMain.Controls.SetChildIndex(this.pnlSelecoes, 0);
            // 
            // pnlId
            // 
            this.pnlId.Location = new System.Drawing.Point(8, 8);
            this.pnlId.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlId.Size = new System.Drawing.Size(994, 78);
            // 
            // LblId
            // 
            this.LblId.Location = new System.Drawing.Point(11, 10);
            // 
            // pnlItens
            // 
            this.pnlItens.Controls.Add(this.pnlValorTotal);
            this.pnlItens.Controls.Add(this.pnlOperacoesItens);
            this.pnlItens.Controls.Add(this.GridItens);
            this.pnlItens.Controls.Add(this.pnlTituloItens);
            this.pnlItens.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlItens.Location = new System.Drawing.Point(8, 86);
            this.pnlItens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Padding = new System.Windows.Forms.Padding(5);
            this.pnlItens.Size = new System.Drawing.Size(450, 495);
            this.pnlItens.TabIndex = 1;
            // 
            // pnlValorTotal
            // 
            this.pnlValorTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlValorTotal.Controls.Add(this.lblPreco);
            this.pnlValorTotal.Location = new System.Drawing.Point(5, 438);
            this.pnlValorTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlValorTotal.Name = "pnlValorTotal";
            this.pnlValorTotal.Size = new System.Drawing.Size(439, 44);
            this.pnlValorTotal.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(179, 6);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(68, 32);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "0,00";
            // 
            // pnlOperacoesItens
            // 
            this.pnlOperacoesItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOperacoesItens.Controls.Add(this.BtnRemoverItem);
            this.pnlOperacoesItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperacoesItens.Location = new System.Drawing.Point(5, 376);
            this.pnlOperacoesItens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlOperacoesItens.Name = "pnlOperacoesItens";
            this.pnlOperacoesItens.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlOperacoesItens.Size = new System.Drawing.Size(440, 56);
            this.pnlOperacoesItens.TabIndex = 2;
            // 
            // BtnRemoverItem
            // 
            this.BtnRemoverItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoverItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRemoverItem.FlatAppearance.BorderSize = 0;
            this.BtnRemoverItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverItem.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.BtnRemoverItem.ForeColor = System.Drawing.Color.Red;
            this.BtnRemoverItem.Location = new System.Drawing.Point(375, 8);
            this.BtnRemoverItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRemoverItem.Name = "BtnRemoverItem";
            this.BtnRemoverItem.Size = new System.Drawing.Size(54, 38);
            this.BtnRemoverItem.TabIndex = 0;
            this.BtnRemoverItem.Text = "";
            this.BtnRemoverItem.UseVisualStyleBackColor = true;
            this.BtnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.AllowUserToResizeColumns = false;
            this.GridItens.AllowUserToResizeRows = false;
            this.GridItens.BackgroundColor = System.Drawing.Color.White;
            this.GridItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdItemPedido,
            this.Produto,
            this.quantidade,
            this.itemPedido});
            this.GridItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridItens.Location = new System.Drawing.Point(5, 48);
            this.GridItens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridItens.MultiSelect = false;
            this.GridItens.Name = "GridItens";
            this.GridItens.ReadOnly = true;
            this.GridItens.RowHeadersVisible = false;
            this.GridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItens.Size = new System.Drawing.Size(440, 328);
            this.GridItens.TabIndex = 1;
            this.GridItens.SelectionChanged += new System.EventHandler(this.GridItens_SelectionChanged);
            // 
            // IdItemPedido
            // 
            this.IdItemPedido.DataPropertyName = "IdItemPedido";
            this.IdItemPedido.HeaderText = "IdItemPedido";
            this.IdItemPedido.Name = "IdItemPedido";
            this.IdItemPedido.ReadOnly = true;
            this.IdItemPedido.Visible = false;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Qtd.";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 50;
            // 
            // itemPedido
            // 
            this.itemPedido.DataPropertyName = "Pedido";
            this.itemPedido.HeaderText = "Pedido";
            this.itemPedido.Name = "itemPedido";
            this.itemPedido.ReadOnly = true;
            this.itemPedido.Visible = false;
            // 
            // pnlTituloItens
            // 
            this.pnlTituloItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTituloItens.Controls.Add(this.lblTituloItens);
            this.pnlTituloItens.Controls.Add(this.lblIcoTituloItens);
            this.pnlTituloItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloItens.Location = new System.Drawing.Point(5, 5);
            this.pnlTituloItens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTituloItens.Name = "pnlTituloItens";
            this.pnlTituloItens.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTituloItens.Size = new System.Drawing.Size(440, 43);
            this.pnlTituloItens.TabIndex = 0;
            // 
            // lblTituloItens
            // 
            this.lblTituloItens.AutoSize = true;
            this.lblTituloItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloItens.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloItens.Location = new System.Drawing.Point(64, 9);
            this.lblTituloItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloItens.Name = "lblTituloItens";
            this.lblTituloItens.Size = new System.Drawing.Size(234, 24);
            this.lblTituloItens.TabIndex = 1;
            this.lblTituloItens.Text = "Produtos Adicionados";
            // 
            // lblIcoTituloItens
            // 
            this.lblIcoTituloItens.AutoSize = true;
            this.lblIcoTituloItens.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIcoTituloItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcoTituloItens.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.lblIcoTituloItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcoTituloItens.Location = new System.Drawing.Point(5, 5);
            this.lblIcoTituloItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcoTituloItens.Name = "lblIcoTituloItens";
            this.lblIcoTituloItens.Size = new System.Drawing.Size(38, 28);
            this.lblIcoTituloItens.TabIndex = 0;
            this.lblIcoTituloItens.Text = "";
            // 
            // pnlSelecoes
            // 
            this.pnlSelecoes.Controls.Add(this.pnlSelecaoProdutos);
            this.pnlSelecoes.Controls.Add(this.pnlCliente);
            this.pnlSelecoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelecoes.Location = new System.Drawing.Point(458, 86);
            this.pnlSelecoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSelecoes.Name = "pnlSelecoes";
            this.pnlSelecoes.Size = new System.Drawing.Size(544, 495);
            this.pnlSelecoes.TabIndex = 2;
            // 
            // pnlSelecaoProdutos
            // 
            this.pnlSelecaoProdutos.Controls.Add(this.pnlProdutosSelecao);
            this.pnlSelecaoProdutos.Controls.Add(this.pnlProdutoPesquisa);
            this.pnlSelecaoProdutos.Controls.Add(this.pnlProdutoTitulo);
            this.pnlSelecaoProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelecaoProdutos.Location = new System.Drawing.Point(0, 119);
            this.pnlSelecaoProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSelecaoProdutos.Name = "pnlSelecaoProdutos";
            this.pnlSelecaoProdutos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSelecaoProdutos.Size = new System.Drawing.Size(544, 376);
            this.pnlSelecaoProdutos.TabIndex = 1;
            // 
            // pnlProdutosSelecao
            // 
            this.pnlProdutosSelecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdutosSelecao.Controls.Add(this.pnlProdutosOperacoes);
            this.pnlProdutosSelecao.Controls.Add(this.GridProdutos);
            this.pnlProdutosSelecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProdutosSelecao.Location = new System.Drawing.Point(5, 91);
            this.pnlProdutosSelecao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlProdutosSelecao.Name = "pnlProdutosSelecao";
            this.pnlProdutosSelecao.Padding = new System.Windows.Forms.Padding(5);
            this.pnlProdutosSelecao.Size = new System.Drawing.Size(534, 280);
            this.pnlProdutosSelecao.TabIndex = 3;
            // 
            // pnlProdutosOperacoes
            // 
            this.pnlProdutosOperacoes.Controls.Add(this.txtQuantidade);
            this.pnlProdutosOperacoes.Controls.Add(this.BtnAdicionar);
            this.pnlProdutosOperacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdutosOperacoes.Location = new System.Drawing.Point(5, 208);
            this.pnlProdutosOperacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlProdutosOperacoes.Name = "pnlProdutosOperacoes";
            this.pnlProdutosOperacoes.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlProdutosOperacoes.Size = new System.Drawing.Size(522, 57);
            this.pnlProdutosOperacoes.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(9, 8);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidade.MaxLength = 3;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 31);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdicionar.FlatAppearance.BorderSize = 0;
            this.BtnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.BtnAdicionar.ForeColor = System.Drawing.Color.Green;
            this.BtnAdicionar.Location = new System.Drawing.Point(459, 8);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(54, 41);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnAdicionar, "F3 - Adicionar Produto.");
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            this.BtnAdicionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnAdicionar_KeyDown);
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.AllowUserToResizeColumns = false;
            this.GridProdutos.AllowUserToResizeRows = false;
            this.GridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.nome,
            this.descricao,
            this.categoria,
            this.valorCompra,
            this.valorVenda,
            this.isAtivo,
            this.idCategoria});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridProdutos.Location = new System.Drawing.Point(5, 5);
            this.GridProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.RowHeadersVisible = false;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(522, 203);
            this.GridProdutos.TabIndex = 5;
            this.GridProdutos.SelectionChanged += new System.EventHandler(this.GridProdutos_SelectionChanged);
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "IdProduto";
            this.idProduto.HeaderText = "Código";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
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
            this.descricao.Visible = false;
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
            this.valorCompra.Visible = false;
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "ValorVenda";
            this.valorVenda.HeaderText = "Valor";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // isAtivo
            // 
            this.isAtivo.DataPropertyName = "IsAtivo";
            this.isAtivo.HeaderText = "Ativo";
            this.isAtivo.Name = "isAtivo";
            this.isAtivo.ReadOnly = true;
            this.isAtivo.Visible = false;
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
            // pnlProdutoPesquisa
            // 
            this.pnlProdutoPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdutoPesquisa.Controls.Add(this.BtnProdutoPesquisar);
            this.pnlProdutoPesquisa.Controls.Add(this.TxtProdutoPesquisa);
            this.pnlProdutoPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdutoPesquisa.Location = new System.Drawing.Point(5, 48);
            this.pnlProdutoPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlProdutoPesquisa.Name = "pnlProdutoPesquisa";
            this.pnlProdutoPesquisa.Padding = new System.Windows.Forms.Padding(5);
            this.pnlProdutoPesquisa.Size = new System.Drawing.Size(534, 43);
            this.pnlProdutoPesquisa.TabIndex = 2;
            // 
            // BtnProdutoPesquisar
            // 
            this.BtnProdutoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProdutoPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProdutoPesquisar.FlatAppearance.BorderSize = 0;
            this.BtnProdutoPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnProdutoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutoPesquisar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.BtnProdutoPesquisar.ForeColor = System.Drawing.Color.Blue;
            this.BtnProdutoPesquisar.Location = new System.Drawing.Point(475, 5);
            this.BtnProdutoPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnProdutoPesquisar.Name = "BtnProdutoPesquisar";
            this.BtnProdutoPesquisar.Size = new System.Drawing.Size(52, 31);
            this.BtnProdutoPesquisar.TabIndex = 2;
            this.BtnProdutoPesquisar.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnProdutoPesquisar, "Buscar produtos.");
            this.BtnProdutoPesquisar.UseVisualStyleBackColor = true;
            this.BtnProdutoPesquisar.Click += new System.EventHandler(this.BtnProdutoPesquisar_Click);
            // 
            // TxtProdutoPesquisa
            // 
            this.TxtProdutoPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtProdutoPesquisa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdutoPesquisa.Location = new System.Drawing.Point(5, 5);
            this.TxtProdutoPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProdutoPesquisa.Name = "TxtProdutoPesquisa";
            this.TxtProdutoPesquisa.Size = new System.Drawing.Size(470, 32);
            this.TxtProdutoPesquisa.TabIndex = 0;
            this.TxtProdutoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProdutoPesquisa_KeyDown);
            // 
            // pnlProdutoTitulo
            // 
            this.pnlProdutoTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdutoTitulo.Controls.Add(this.lblProdutoTitulo);
            this.pnlProdutoTitulo.Controls.Add(this.lblIconProdutoTitulo);
            this.pnlProdutoTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdutoTitulo.Location = new System.Drawing.Point(5, 5);
            this.pnlProdutoTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlProdutoTitulo.Name = "pnlProdutoTitulo";
            this.pnlProdutoTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlProdutoTitulo.Size = new System.Drawing.Size(534, 43);
            this.pnlProdutoTitulo.TabIndex = 1;
            // 
            // lblProdutoTitulo
            // 
            this.lblProdutoTitulo.AutoSize = true;
            this.lblProdutoTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdutoTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProdutoTitulo.Location = new System.Drawing.Point(74, 10);
            this.lblProdutoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoTitulo.Name = "lblProdutoTitulo";
            this.lblProdutoTitulo.Size = new System.Drawing.Size(220, 24);
            this.lblProdutoTitulo.TabIndex = 3;
            this.lblProdutoTitulo.Text = "Seleção de Produtos";
            // 
            // lblIconProdutoTitulo
            // 
            this.lblIconProdutoTitulo.AutoSize = true;
            this.lblIconProdutoTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIconProdutoTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIconProdutoTitulo.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.lblIconProdutoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIconProdutoTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblIconProdutoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconProdutoTitulo.Name = "lblIconProdutoTitulo";
            this.lblIconProdutoTitulo.Size = new System.Drawing.Size(36, 28);
            this.lblIconProdutoTitulo.TabIndex = 2;
            this.lblIconProdutoTitulo.Text = "";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.White;
            this.pnlCliente.Controls.Add(this.lblClienteEnderecoTexto);
            this.pnlCliente.Controls.Add(this.lblClienteEndereco);
            this.pnlCliente.Controls.Add(this.lblClienteNomeTexto);
            this.pnlCliente.Controls.Add(this.lblClienteNome);
            this.pnlCliente.Controls.Add(this.BtnSelecaoCliente);
            this.pnlCliente.Controls.Add(this.pnlClienteTitulo);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCliente.Size = new System.Drawing.Size(544, 119);
            this.pnlCliente.TabIndex = 0;
            // 
            // lblClienteEnderecoTexto
            // 
            this.lblClienteEnderecoTexto.AutoSize = true;
            this.lblClienteEnderecoTexto.Location = new System.Drawing.Point(211, 84);
            this.lblClienteEnderecoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteEnderecoTexto.Name = "lblClienteEnderecoTexto";
            this.lblClienteEnderecoTexto.Size = new System.Drawing.Size(14, 20);
            this.lblClienteEnderecoTexto.TabIndex = 5;
            this.lblClienteEnderecoTexto.Text = "-";
            // 
            // lblClienteEndereco
            // 
            this.lblClienteEndereco.AutoSize = true;
            this.lblClienteEndereco.Location = new System.Drawing.Point(118, 84);
            this.lblClienteEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteEndereco.Name = "lblClienteEndereco";
            this.lblClienteEndereco.Size = new System.Drawing.Size(86, 20);
            this.lblClienteEndereco.TabIndex = 4;
            this.lblClienteEndereco.Text = "Endereço :";
            // 
            // lblClienteNomeTexto
            // 
            this.lblClienteNomeTexto.AutoSize = true;
            this.lblClienteNomeTexto.Location = new System.Drawing.Point(211, 64);
            this.lblClienteNomeTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteNomeTexto.Name = "lblClienteNomeTexto";
            this.lblClienteNomeTexto.Size = new System.Drawing.Size(14, 20);
            this.lblClienteNomeTexto.TabIndex = 3;
            this.lblClienteNomeTexto.Text = "-";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Location = new System.Drawing.Point(144, 64);
            this.lblClienteNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(59, 20);
            this.lblClienteNome.TabIndex = 2;
            this.lblClienteNome.Text = "Nome :";
            // 
            // BtnSelecaoCliente
            // 
            this.BtnSelecaoCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelecaoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelecaoCliente.FlatAppearance.BorderSize = 0;
            this.BtnSelecaoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSelecaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecaoCliente.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.BtnSelecaoCliente.ForeColor = System.Drawing.Color.Blue;
            this.BtnSelecaoCliente.Location = new System.Drawing.Point(5, 54);
            this.BtnSelecaoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSelecaoCliente.Name = "BtnSelecaoCliente";
            this.BtnSelecaoCliente.Size = new System.Drawing.Size(106, 59);
            this.BtnSelecaoCliente.TabIndex = 1;
            this.BtnSelecaoCliente.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnSelecaoCliente, "Selecionar ou cadastrar Clientes.");
            this.BtnSelecaoCliente.UseVisualStyleBackColor = false;
            this.BtnSelecaoCliente.Click += new System.EventHandler(this.BtnSelecaoCliente_Click);
            // 
            // pnlClienteTitulo
            // 
            this.pnlClienteTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClienteTitulo.Controls.Add(this.lblClienteTitulo);
            this.pnlClienteTitulo.Controls.Add(this.lblIconClienteTitulo);
            this.pnlClienteTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClienteTitulo.Location = new System.Drawing.Point(5, 5);
            this.pnlClienteTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlClienteTitulo.Name = "pnlClienteTitulo";
            this.pnlClienteTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlClienteTitulo.Size = new System.Drawing.Size(534, 43);
            this.pnlClienteTitulo.TabIndex = 0;
            // 
            // lblClienteTitulo
            // 
            this.lblClienteTitulo.AutoSize = true;
            this.lblClienteTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClienteTitulo.Location = new System.Drawing.Point(74, 9);
            this.lblClienteTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Size = new System.Drawing.Size(196, 24);
            this.lblClienteTitulo.TabIndex = 3;
            this.lblClienteTitulo.Text = "Seleção de Cliente";
            // 
            // lblIconClienteTitulo
            // 
            this.lblIconClienteTitulo.AutoSize = true;
            this.lblIconClienteTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIconClienteTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIconClienteTitulo.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F);
            this.lblIconClienteTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIconClienteTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblIconClienteTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconClienteTitulo.Name = "lblIconClienteTitulo";
            this.lblIconClienteTitulo.Size = new System.Drawing.Size(46, 28);
            this.lblIconClienteTitulo.TabIndex = 2;
            this.lblIconClienteTitulo.Text = "";
            // 
            // FrmFormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 750);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmFormPedido";
            this.Text = "FrmFormPedido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFormPedido_KeyDown);
            this.pnlBtns.ResumeLayout(false);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pblMain.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlItens.ResumeLayout(false);
            this.pnlValorTotal.ResumeLayout(false);
            this.pnlValorTotal.PerformLayout();
            this.pnlOperacoesItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.pnlTituloItens.ResumeLayout(false);
            this.pnlTituloItens.PerformLayout();
            this.pnlSelecoes.ResumeLayout(false);
            this.pnlSelecaoProdutos.ResumeLayout(false);
            this.pnlProdutosSelecao.ResumeLayout(false);
            this.pnlProdutosOperacoes.ResumeLayout(false);
            this.pnlProdutosOperacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.pnlProdutoPesquisa.ResumeLayout(false);
            this.pnlProdutoPesquisa.PerformLayout();
            this.pnlProdutoTitulo.ResumeLayout(false);
            this.pnlProdutoTitulo.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlClienteTitulo.ResumeLayout(false);
            this.pnlClienteTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlItens;
        private System.Windows.Forms.Panel pnlTituloItens;
        private System.Windows.Forms.Label lblIcoTituloItens;
        private System.Windows.Forms.Panel pnlOperacoesItens;
        private System.Windows.Forms.Button BtnRemoverItem;
        private System.Windows.Forms.DataGridView GridItens;
        private System.Windows.Forms.Label lblTituloItens;
        private System.Windows.Forms.Panel pnlValorTotal;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Panel pnlSelecoes;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlClienteTitulo;
        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Label lblIconClienteTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItemPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPedido;
        private System.Windows.Forms.Panel pnlSelecaoProdutos;
        private System.Windows.Forms.Panel pnlProdutoPesquisa;
        private System.Windows.Forms.Button BtnProdutoPesquisar;
        private System.Windows.Forms.TextBox TxtProdutoPesquisa;
        private System.Windows.Forms.Panel pnlProdutoTitulo;
        private System.Windows.Forms.Label lblProdutoTitulo;
        private System.Windows.Forms.Label lblIconProdutoTitulo;
        private System.Windows.Forms.Label lblClienteEnderecoTexto;
        private System.Windows.Forms.Label lblClienteEndereco;
        private System.Windows.Forms.Label lblClienteNomeTexto;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.Button BtnSelecaoCliente;
        private System.Windows.Forms.Panel pnlProdutosSelecao;
        private System.Windows.Forms.Panel pnlProdutosOperacoes;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.ToolTip ToolTipTexto;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}