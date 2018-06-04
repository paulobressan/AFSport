namespace AFSport.WindowsForms.Formularios.Pedidos
{
    partial class FrmSelecaoCliente
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
            this.pnlbar2 = new System.Windows.Forms.Panel();
            this.pblHead = new System.Windows.Forms.Panel();
            this.LblSair = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIcone = new System.Windows.Forms.Label();
            this.pnlbar = new System.Windows.Forms.Panel();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.BtnProdutoPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlOperacao = new System.Windows.Forms.Panel();
            this.BtnAdicionarCliente = new System.Windows.Forms.Button();
            this.BtnAdicionarPedido = new System.Windows.Forms.Button();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.GridPesq = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolTipTexto = new System.Windows.Forms.ToolTip(this.components);
            this.pblHead.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.pnlOperacao.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbar2
            // 
            this.pnlbar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar2.Location = new System.Drawing.Point(0, 60);
            this.pnlbar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar2.Name = "pnlbar2";
            this.pnlbar2.Size = new System.Drawing.Size(689, 10);
            this.pnlbar2.TabIndex = 9;
            // 
            // pblHead
            // 
            this.pblHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblHead.Controls.Add(this.LblSair);
            this.pblHead.Controls.Add(this.lblTitulo);
            this.pblHead.Controls.Add(this.lblIcone);
            this.pblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblHead.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblHead.Location = new System.Drawing.Point(0, 10);
            this.pblHead.Name = "pblHead";
            this.pblHead.Size = new System.Drawing.Size(689, 50);
            this.pblHead.TabIndex = 8;
            // 
            // LblSair
            // 
            this.LblSair.AutoSize = true;
            this.LblSair.BackColor = System.Drawing.Color.White;
            this.LblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSair.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSair.ForeColor = System.Drawing.Color.Red;
            this.LblSair.Location = new System.Drawing.Point(636, 9);
            this.LblSair.Name = "LblSair";
            this.LblSair.Size = new System.Drawing.Size(40, 28);
            this.LblSair.TabIndex = 2;
            this.LblSair.Text = "";
            this.LblSair.Click += new System.EventHandler(this.LblSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(54, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Seleção de Clientes";
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcone.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcone.Location = new System.Drawing.Point(11, 11);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(47, 28);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(689, 10);
            this.pnlbar.TabIndex = 7;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.BtnProdutoPesquisar);
            this.pnlPesquisa.Controls.Add(this.TxtPesquisa);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 70);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPesquisa.Size = new System.Drawing.Size(689, 48);
            this.pnlPesquisa.TabIndex = 10;
            // 
            // BtnProdutoPesquisar
            // 
            this.BtnProdutoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProdutoPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProdutoPesquisar.FlatAppearance.BorderSize = 0;
            this.BtnProdutoPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnProdutoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutoPesquisar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutoPesquisar.ForeColor = System.Drawing.Color.Blue;
            this.BtnProdutoPesquisar.Location = new System.Drawing.Point(630, 5);
            this.BtnProdutoPesquisar.Name = "BtnProdutoPesquisar";
            this.BtnProdutoPesquisar.Size = new System.Drawing.Size(54, 38);
            this.BtnProdutoPesquisar.TabIndex = 3;
            this.BtnProdutoPesquisar.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnProdutoPesquisar, "Buscar Clientes");
            this.BtnProdutoPesquisar.UseVisualStyleBackColor = true;
            this.BtnProdutoPesquisar.Click += new System.EventHandler(this.BtnProdutoPesquisar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtPesquisa.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisa.Location = new System.Drawing.Point(5, 5);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(625, 36);
            this.TxtPesquisa.TabIndex = 0;
            this.ToolTipTexto.SetToolTip(this.TxtPesquisa, "Pesquisa por nome ou id");
            this.TxtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPesquisa_KeyDown);
            // 
            // pnlOperacao
            // 
            this.pnlOperacao.Controls.Add(this.BtnAdicionarCliente);
            this.pnlOperacao.Controls.Add(this.BtnAdicionarPedido);
            this.pnlOperacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOperacao.Location = new System.Drawing.Point(0, 467);
            this.pnlOperacao.Name = "pnlOperacao";
            this.pnlOperacao.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOperacao.Size = new System.Drawing.Size(689, 55);
            this.pnlOperacao.TabIndex = 11;
            // 
            // BtnAdicionarCliente
            // 
            this.BtnAdicionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionarCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdicionarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAdicionarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarCliente.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarCliente.ForeColor = System.Drawing.Color.Green;
            this.BtnAdicionarCliente.Location = new System.Drawing.Point(554, 5);
            this.BtnAdicionarCliente.Name = "BtnAdicionarCliente";
            this.BtnAdicionarCliente.Size = new System.Drawing.Size(65, 45);
            this.BtnAdicionarCliente.TabIndex = 2;
            this.BtnAdicionarCliente.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnAdicionarCliente, "Novo Cliente");
            this.BtnAdicionarCliente.UseVisualStyleBackColor = true;
            this.BtnAdicionarCliente.Click += new System.EventHandler(this.BtnAdicionarCliente_Click);
            // 
            // BtnAdicionarPedido
            // 
            this.BtnAdicionarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionarPedido.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdicionarPedido.FlatAppearance.BorderSize = 0;
            this.BtnAdicionarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAdicionarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarPedido.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarPedido.ForeColor = System.Drawing.Color.Blue;
            this.BtnAdicionarPedido.Location = new System.Drawing.Point(619, 5);
            this.BtnAdicionarPedido.Name = "BtnAdicionarPedido";
            this.BtnAdicionarPedido.Size = new System.Drawing.Size(65, 45);
            this.BtnAdicionarPedido.TabIndex = 1;
            this.BtnAdicionarPedido.Text = "";
            this.ToolTipTexto.SetToolTip(this.BtnAdicionarPedido, "Adicionar Cliente ao Pedido");
            this.BtnAdicionarPedido.UseVisualStyleBackColor = true;
            this.BtnAdicionarPedido.Click += new System.EventHandler(this.BtnAdicionarPedido_Click);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.GridPesq);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(0, 118);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Padding = new System.Windows.Forms.Padding(5);
            this.PnlGrid.Size = new System.Drawing.Size(689, 349);
            this.PnlGrid.TabIndex = 12;
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
            this.IdCliente,
            this.nome,
            this.email,
            this.logradouro,
            this.numero,
            this.bairro,
            this.cidade,
            this.isAtivo,
            this.idCidade});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(5, 5);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.RowHeadersVisible = false;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(679, 339);
            this.GridPesq.TabIndex = 1;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Código";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 70;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "Logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            this.logradouro.Width = 200;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "Numero";
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 50;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "Bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "Cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // isAtivo
            // 
            this.isAtivo.DataPropertyName = "IsAtivo";
            this.isAtivo.HeaderText = "Ativo";
            this.isAtivo.Name = "isAtivo";
            this.isAtivo.ReadOnly = true;
            this.isAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isAtivo.Visible = false;
            this.isAtivo.Width = 50;
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "idCidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.ReadOnly = true;
            this.idCidade.Visible = false;
            // 
            // FrmSelecaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 522);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.pnlOperacao);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlbar2);
            this.Controls.Add(this.pblHead);
            this.Controls.Add(this.pnlbar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSelecaoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelecaoCliente";
            this.Load += new System.EventHandler(this.FrmSelecaoCliente_Load);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlOperacao.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlbar2;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Label LblSair;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblIcone;
        protected System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnProdutoPesquisar;
        private System.Windows.Forms.Panel pnlOperacao;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView GridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCidade;
        private System.Windows.Forms.Button BtnAdicionarPedido;
        private System.Windows.Forms.ToolTip ToolTipTexto;
        private System.Windows.Forms.Button BtnAdicionarCliente;
    }
}