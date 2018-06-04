namespace AFSport.WindowsForms.Formularios.Precos
{
    partial class FrmPrecos
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
            this.GridPesq = new System.Windows.Forms.DataGridView();
            this.idPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlNavBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.GridPesq);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(37, 36);
            this.lblTitulo.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.Text = "Preços";
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
            this.idPreco,
            this.dataInicio,
            this.dataFinal,
            this.valor,
            this.produto,
            this.isAtivo});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(6, 6);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.RowHeadersVisible = false;
            this.GridPesq.Size = new System.Drawing.Size(770, 430);
            this.GridPesq.TabIndex = 0;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // idPreco
            // 
            this.idPreco.DataPropertyName = "idPreco";
            this.idPreco.HeaderText = "Código";
            this.idPreco.Name = "idPreco";
            this.idPreco.ReadOnly = true;
            this.idPreco.Width = 70;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "dataInicio";
            this.dataInicio.HeaderText = "Data Início";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            // 
            // dataFinal
            // 
            this.dataFinal.DataPropertyName = "dataFinal";
            this.dataFinal.HeaderText = "Data Final";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 50;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // isAtivo
            // 
            this.isAtivo.DataPropertyName = "isAtivo";
            this.isAtivo.HeaderText = "Ativo";
            this.isAtivo.Name = "isAtivo";
            this.isAtivo.ReadOnly = true;
            this.isAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isAtivo.Width = 50;
            // 
            // FrmPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPrecos";
            this.Text = "FrmPrecos";
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAtivo;
    }
}