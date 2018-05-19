namespace AFSport.WindowsForms.Formularios.Categorias
{
    partial class FrmCategorias
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
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlNavBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(853, 8);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Size = new System.Drawing.Size(112, 71);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.Location = new System.Drawing.Point(965, 8);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Size = new System.Drawing.Size(112, 71);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletar.Location = new System.Drawing.Point(1077, 8);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletar.Size = new System.Drawing.Size(112, 71);
            // 
            // pnlmargin
            // 
            this.pnlmargin.Margin = new System.Windows.Forms.Padding(6);
            this.pnlmargin.Size = new System.Drawing.Size(1200, 14);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(6);
            this.pnlNavBar.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlNavBar.Size = new System.Drawing.Size(1200, 89);
            // 
            // pnlmargin2
            // 
            this.pnlmargin2.Margin = new System.Windows.Forms.Padding(6);
            this.pnlmargin2.Size = new System.Drawing.Size(1200, 14);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.GridPesq);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(6);
            this.pnlBody.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlBody.Size = new System.Drawing.Size(1200, 506);
            // 
            // lblTitulo
            // 
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Size = new System.Drawing.Size(52, 36);
            this.lblTitulo.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.Text = "Categorias de Produtos";
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
            this.idCategoria,
            this.Nome,
            this.descricao,
            this.IsAtivo});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(9, 8);
            this.GridPesq.Margin = new System.Windows.Forms.Padding(4);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(1180, 488);
            this.GridPesq.TabIndex = 0;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "Código";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // IsAtivo
            // 
            this.IsAtivo.DataPropertyName = "IsAtivo";
            this.IsAtivo.HeaderText = "Ativo";
            this.IsAtivo.Name = "IsAtivo";
            this.IsAtivo.ReadOnly = true;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAtivo;
    }
}