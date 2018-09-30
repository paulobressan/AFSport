namespace AFSport.WindowsForms.Formularios.Relatorios
{
    partial class FrmRelatorioCaixa
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
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlbar2 = new System.Windows.Forms.Panel();
            this.pblHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIcone = new System.Windows.Forms.Label();
            this.pnlbar = new System.Windows.Forms.Panel();
            this.pnlOperacao = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.GridPesq = new System.Windows.Forms.DataGridView();
            this.idMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.BtnPesq = new System.Windows.Forms.Button();
            this.pnlValores = new System.Windows.Forms.Panel();
            this.lblValorMovimentadoEntrada = new System.Windows.Forms.Label();
            this.lblValorMovimentadoEntradaTxt = new System.Windows.Forms.Label();
            this.lvlValorMovimentadoSaidaTxt = new System.Windows.Forms.Label();
            this.lvlValorMovimentadoSaida = new System.Windows.Forms.Label();
            this.pnlGeral.SuspendLayout();
            this.pblHead.SuspendLayout();
            this.pnlOperacao.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.pnlValores.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlGeral.TabIndex = 14;
            // 
            // pnlbar2
            // 
            this.pnlbar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar2.Location = new System.Drawing.Point(0, 70);
            this.pnlbar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar2.Name = "pnlbar2";
            this.pnlbar2.Size = new System.Drawing.Size(1182, 10);
            this.pnlbar2.TabIndex = 13;
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
            this.pblHead.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(54, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Relatórios de Caixa";
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcone.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcone.Location = new System.Drawing.Point(11, 11);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(47, 35);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(1182, 10);
            this.pnlbar.TabIndex = 11;
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
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.GridPesq);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(5, 93);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1172, 575);
            this.pnlGrid.TabIndex = 1;
            // 
            // GridPesq
            // 
            this.GridPesq.AllowUserToAddRows = false;
            this.GridPesq.AllowUserToDeleteRows = false;
            this.GridPesq.AllowUserToResizeColumns = false;
            this.GridPesq.AllowUserToResizeRows = false;
            this.GridPesq.BackgroundColor = System.Drawing.Color.White;
            this.GridPesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimentacao,
            this.usuario,
            this.Operacao,
            this.valor,
            this.data});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(0, 0);
            this.GridPesq.Margin = new System.Windows.Forms.Padding(4);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.RowHeadersVisible = false;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(1172, 575);
            this.GridPesq.TabIndex = 1;
            // 
            // idMovimentacao
            // 
            this.idMovimentacao.DataPropertyName = "idMovimentacao";
            this.idMovimentacao.HeaderText = "Código";
            this.idMovimentacao.Name = "idMovimentacao";
            this.idMovimentacao.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Operacao
            // 
            this.Operacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operacao.DataPropertyName = "operacao";
            this.Operacao.HeaderText = "Operação";
            this.Operacao.Name = "Operacao";
            this.Operacao.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
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
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(13, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(152, 30);
            this.txtData.TabIndex = 1;
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
            // pnlValores
            // 
            this.pnlValores.Controls.Add(this.lvlValorMovimentadoSaidaTxt);
            this.pnlValores.Controls.Add(this.lvlValorMovimentadoSaida);
            this.pnlValores.Controls.Add(this.lblValorMovimentadoEntradaTxt);
            this.pnlValores.Controls.Add(this.lblValorMovimentadoEntrada);
            this.pnlValores.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlValores.Location = new System.Drawing.Point(324, 0);
            this.pnlValores.Name = "pnlValores";
            this.pnlValores.Padding = new System.Windows.Forms.Padding(10);
            this.pnlValores.Size = new System.Drawing.Size(848, 88);
            this.pnlValores.TabIndex = 3;
            // 
            // lblValorMovimentadoEntrada
            // 
            this.lblValorMovimentadoEntrada.AutoSize = true;
            this.lblValorMovimentadoEntrada.Location = new System.Drawing.Point(13, 30);
            this.lblValorMovimentadoEntrada.Name = "lblValorMovimentadoEntrada";
            this.lblValorMovimentadoEntrada.Size = new System.Drawing.Size(271, 23);
            this.lblValorMovimentadoEntrada.TabIndex = 4;
            this.lblValorMovimentadoEntrada.Text = "Valor Movimentado Entrada : ";
            // 
            // lblValorMovimentadoEntradaTxt
            // 
            this.lblValorMovimentadoEntradaTxt.AutoSize = true;
            this.lblValorMovimentadoEntradaTxt.Location = new System.Drawing.Point(290, 30);
            this.lblValorMovimentadoEntradaTxt.Name = "lblValorMovimentadoEntradaTxt";
            this.lblValorMovimentadoEntradaTxt.Size = new System.Drawing.Size(136, 23);
            this.lblValorMovimentadoEntradaTxt.TabIndex = 5;
            this.lblValorMovimentadoEntradaTxt.Text = "[ValorEntrada]";
            // 
            // lvlValorMovimentadoSaidaTxt
            // 
            this.lvlValorMovimentadoSaidaTxt.AutoSize = true;
            this.lvlValorMovimentadoSaidaTxt.Location = new System.Drawing.Point(692, 30);
            this.lvlValorMovimentadoSaidaTxt.Name = "lvlValorMovimentadoSaidaTxt";
            this.lvlValorMovimentadoSaidaTxt.Size = new System.Drawing.Size(117, 23);
            this.lvlValorMovimentadoSaidaTxt.TabIndex = 7;
            this.lvlValorMovimentadoSaidaTxt.Text = "[ValorSaida]";
            // 
            // lvlValorMovimentadoSaida
            // 
            this.lvlValorMovimentadoSaida.AutoSize = true;
            this.lvlValorMovimentadoSaida.Location = new System.Drawing.Point(432, 30);
            this.lvlValorMovimentadoSaida.Name = "lvlValorMovimentadoSaida";
            this.lvlValorMovimentadoSaida.Size = new System.Drawing.Size(254, 23);
            this.lvlValorMovimentadoSaida.TabIndex = 6;
            this.lvlValorMovimentadoSaida.Text = "Valor Movimentado Saída : ";
            // 
            // FrmRelatorioCaixa
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
            this.Name = "FrmRelatorioCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Caixa";
            this.Load += new System.EventHandler(this.FrmRelatorioCaixa_Load);
            this.pnlGeral.ResumeLayout(false);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlOperacao.ResumeLayout(false);
            this.pnlOperacao.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.pnlValores.ResumeLayout(false);
            this.pnlValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeral;
        protected System.Windows.Forms.Panel pnlbar2;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblIcone;
        protected System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlOperacao;
        private System.Windows.Forms.DataGridView GridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button BtnPesq;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlValores;
        private System.Windows.Forms.Label lblValorMovimentadoEntradaTxt;
        private System.Windows.Forms.Label lblValorMovimentadoEntrada;
        private System.Windows.Forms.Label lvlValorMovimentadoSaidaTxt;
        private System.Windows.Forms.Label lvlValorMovimentadoSaida;
    }
}