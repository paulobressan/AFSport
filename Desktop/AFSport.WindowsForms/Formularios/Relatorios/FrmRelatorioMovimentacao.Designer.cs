namespace AFSport.WindowsForms.Formularios.Relatorios
{
    partial class FrmRelatorioMovimentacao
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
            this.pnlbar2 = new System.Windows.Forms.Panel();
            this.pblHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIcone = new System.Windows.Forms.Label();
            this.pnlbar = new System.Windows.Forms.Panel();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlOperacao = new System.Windows.Forms.Panel();
            this.pnlValores = new System.Windows.Forms.Panel();
            this.lblValorLiquidoTxt = new System.Windows.Forms.Label();
            this.lblValorLiquido = new System.Windows.Forms.Label();
            this.lblValorBrutoTxt = new System.Windows.Forms.Label();
            this.lblValorBruto = new System.Windows.Forms.Label();
            this.BtnPesq = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.IdItemPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pblHead.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlOperacao.SuspendLayout();
            this.pnlValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbar2
            // 
            this.pnlbar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar2.Location = new System.Drawing.Point(0, 70);
            this.pnlbar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar2.Name = "pnlbar2";
            this.pnlbar2.Size = new System.Drawing.Size(1182, 10);
            this.pnlbar2.TabIndex = 19;
            // 
            // pblHead
            // 
            this.pblHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblHead.Controls.Add(this.lblTitulo);
            this.pblHead.Controls.Add(this.lblIcone);
            this.pblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblHead.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblHead.Location = new System.Drawing.Point(0, 10);
            this.pblHead.Name = "pblHead";
            this.pblHead.Size = new System.Drawing.Size(1182, 60);
            this.pblHead.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(68, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Relatório de Lucros";
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcone.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcone.Location = new System.Drawing.Point(11, 11);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(51, 35);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(1182, 10);
            this.pnlbar.TabIndex = 17;
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.pnlGrid);
            this.pnlGeral.Controls.Add(this.pnlOperacao);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 80);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Padding = new System.Windows.Forms.Padding(5);
            this.pnlGeral.Size = new System.Drawing.Size(1182, 673);
            this.pnlGeral.TabIndex = 20;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.GridItens);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(5, 93);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1172, 575);
            this.pnlGrid.TabIndex = 1;
            // 
            // pnlOperacao
            // 
            this.pnlOperacao.Controls.Add(this.pnlValores);
            this.pnlOperacao.Controls.Add(this.BtnPesq);
            this.pnlOperacao.Controls.Add(this.txtData);
            this.pnlOperacao.Controls.Add(this.lblData);
            this.pnlOperacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperacao.Location = new System.Drawing.Point(5, 5);
            this.pnlOperacao.Name = "pnlOperacao";
            this.pnlOperacao.Size = new System.Drawing.Size(1172, 88);
            this.pnlOperacao.TabIndex = 0;
            // 
            // pnlValores
            // 
            this.pnlValores.Controls.Add(this.lblValorLiquidoTxt);
            this.pnlValores.Controls.Add(this.lblValorLiquido);
            this.pnlValores.Controls.Add(this.lblValorBrutoTxt);
            this.pnlValores.Controls.Add(this.lblValorBruto);
            this.pnlValores.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlValores.Location = new System.Drawing.Point(324, 0);
            this.pnlValores.Name = "pnlValores";
            this.pnlValores.Padding = new System.Windows.Forms.Padding(10);
            this.pnlValores.Size = new System.Drawing.Size(848, 88);
            this.pnlValores.TabIndex = 3;
            // 
            // lblValorLiquidoTxt
            // 
            this.lblValorLiquidoTxt.AutoSize = true;
            this.lblValorLiquidoTxt.Location = new System.Drawing.Point(457, 30);
            this.lblValorLiquidoTxt.Name = "lblValorLiquidoTxt";
            this.lblValorLiquidoTxt.Size = new System.Drawing.Size(129, 23);
            this.lblValorLiquidoTxt.TabIndex = 7;
            this.lblValorLiquidoTxt.Text = "[ValorLiquido]";
            // 
            // lblValorLiquido
            // 
            this.lblValorLiquido.AutoSize = true;
            this.lblValorLiquido.Location = new System.Drawing.Point(310, 30);
            this.lblValorLiquido.Name = "lblValorLiquido";
            this.lblValorLiquido.Size = new System.Drawing.Size(141, 23);
            this.lblValorLiquido.TabIndex = 6;
            this.lblValorLiquido.Text = "Valor Liquido : ";
            // 
            // lblValorBrutoTxt
            // 
            this.lblValorBrutoTxt.AutoSize = true;
            this.lblValorBrutoTxt.Location = new System.Drawing.Point(145, 30);
            this.lblValorBrutoTxt.Name = "lblValorBrutoTxt";
            this.lblValorBrutoTxt.Size = new System.Drawing.Size(114, 23);
            this.lblValorBrutoTxt.TabIndex = 5;
            this.lblValorBrutoTxt.Text = "[ValorBruto]";
            // 
            // lblValorBruto
            // 
            this.lblValorBruto.AutoSize = true;
            this.lblValorBruto.Location = new System.Drawing.Point(13, 30);
            this.lblValorBruto.Name = "lblValorBruto";
            this.lblValorBruto.Size = new System.Drawing.Size(126, 23);
            this.lblValorBruto.TabIndex = 4;
            this.lblValorBruto.Text = "Valor Bruto : ";
            // 
            // BtnPesq
            // 
            this.BtnPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesq.FlatAppearance.BorderSize = 0;
            this.BtnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesq.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesq.Location = new System.Drawing.Point(171, 43);
            this.BtnPesq.Name = "BtnPesq";
            this.BtnPesq.Size = new System.Drawing.Size(33, 30);
            this.BtnPesq.TabIndex = 2;
            this.BtnPesq.Text = "";
            this.BtnPesq.UseVisualStyleBackColor = true;
            this.BtnPesq.Click += new System.EventHandler(this.BtnPesq_Click);
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(13, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(152, 30);
            this.txtData.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(9, 17);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(135, 23);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data do Caixa";
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
            this.GridItens.Location = new System.Drawing.Point(0, 0);
            this.GridItens.Margin = new System.Windows.Forms.Padding(4);
            this.GridItens.MultiSelect = false;
            this.GridItens.Name = "GridItens";
            this.GridItens.ReadOnly = true;
            this.GridItens.RowHeadersVisible = false;
            this.GridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItens.Size = new System.Drawing.Size(1172, 394);
            this.GridItens.TabIndex = 2;
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
            // FrmRelatorioMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.pnlbar2);
            this.Controls.Add(this.pblHead);
            this.Controls.Add(this.pnlbar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRelatorioMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Lucros";
            this.Load += new System.EventHandler(this.FrmRelatorioMovimentacao_Load);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlGeral.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlOperacao.ResumeLayout(false);
            this.pnlOperacao.PerformLayout();
            this.pnlValores.ResumeLayout(false);
            this.pnlValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlbar2;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblIcone;
        protected System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlOperacao;
        private System.Windows.Forms.Panel pnlValores;
        private System.Windows.Forms.Label lblValorLiquidoTxt;
        private System.Windows.Forms.Label lblValorLiquido;
        private System.Windows.Forms.Label lblValorBrutoTxt;
        private System.Windows.Forms.Label lblValorBruto;
        private System.Windows.Forms.Button BtnPesq;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView GridItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItemPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPedido;
    }
}