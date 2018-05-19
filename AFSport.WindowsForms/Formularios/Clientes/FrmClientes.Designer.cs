namespace AFSport.WindowsForms.Formularios.Clientes
{
    partial class FrmClientes
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
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNavBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovo.Location = new System.Drawing.Point(985, 6);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.Location = new System.Drawing.Point(1097, 6);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletar.Location = new System.Drawing.Point(1209, 6);
            // 
            // pnlmargin
            // 
            this.pnlmargin.Size = new System.Drawing.Size(1329, 14);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Size = new System.Drawing.Size(1329, 89);
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
            this.lblTitulo.Size = new System.Drawing.Size(61, 36);
            this.lblTitulo.Text = "";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.Text = "Clientes";
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
            this.GridPesq.Location = new System.Drawing.Point(6, 6);
            this.GridPesq.MultiSelect = false;
            this.GridPesq.Name = "GridPesq";
            this.GridPesq.ReadOnly = true;
            this.GridPesq.RowHeadersVisible = false;
            this.GridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPesq.Size = new System.Drawing.Size(1315, 491);
            this.GridPesq.TabIndex = 0;
            this.GridPesq.SelectionChanged += new System.EventHandler(this.GridPesq_SelectionChanged);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Código";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 50;
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
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 622);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}