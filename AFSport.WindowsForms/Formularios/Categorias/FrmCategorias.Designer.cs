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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnNovo.Location = new System.Drawing.Point(569, 4);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(644, 4);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(719, 4);
            // 
            // pnlmargin
            // 
            this.pnlmargin.Size = new System.Drawing.Size(800, 10);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Size = new System.Drawing.Size(800, 65);
            // 
            // pnlmargin2
            // 
            this.pnlmargin2.Size = new System.Drawing.Size(800, 10);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.GridPesq);
            this.pnlBody.Size = new System.Drawing.Size(800, 365);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(56, 36);
            this.lblTitulo.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.Text = "Categorias de produtos";
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
            this.id,
            this.Nome,
            this.descricao,
            this.IsAtivo});
            this.GridPesq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPesq.Location = new System.Drawing.Point(4, 4);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(790, 355);
            this.GridPesq.TabIndex = 0;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAtivo;
    }
}