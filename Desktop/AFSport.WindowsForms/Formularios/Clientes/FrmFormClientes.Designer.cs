namespace AFSport.WindowsForms.Formularios.Clientes
{
    partial class FrmFormClientes
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
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.CmbEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
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
            this.BtnCancelar.Location = new System.Drawing.Point(555, 6);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Location = new System.Drawing.Point(443, 6);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 441);
            this.pnlBtns.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBtns.Size = new System.Drawing.Size(675, 89);
            // 
            // pblHead
            // 
            this.pblHead.Size = new System.Drawing.Size(675, 50);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(615, 9);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(289, 32);
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // lblIcone
            // 
            this.lblIcone.Size = new System.Drawing.Size(47, 28);
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.Size = new System.Drawing.Size(675, 10);
            // 
            // pnlbar2
            // 
            this.pnlbar2.Size = new System.Drawing.Size(675, 10);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.CmbEstados);
            this.pblMain.Controls.Add(this.lblEstado);
            this.pblMain.Controls.Add(this.cmbCidade);
            this.pblMain.Controls.Add(this.lblCidade);
            this.pblMain.Controls.Add(this.txtBairro);
            this.pblMain.Controls.Add(this.txtNumero);
            this.pblMain.Controls.Add(this.txtLogradouro);
            this.pblMain.Controls.Add(this.txtEmail);
            this.pblMain.Controls.Add(this.txtNome);
            this.pblMain.Controls.Add(this.lblBairro);
            this.pblMain.Controls.Add(this.lblNumero);
            this.pblMain.Controls.Add(this.lblEmail);
            this.pblMain.Controls.Add(this.lblLogradouro);
            this.pblMain.Controls.Add(this.lblNome);
            this.pblMain.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pblMain.Size = new System.Drawing.Size(675, 371);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.lblNome, 0);
            this.pblMain.Controls.SetChildIndex(this.lblLogradouro, 0);
            this.pblMain.Controls.SetChildIndex(this.lblEmail, 0);
            this.pblMain.Controls.SetChildIndex(this.lblNumero, 0);
            this.pblMain.Controls.SetChildIndex(this.lblBairro, 0);
            this.pblMain.Controls.SetChildIndex(this.txtNome, 0);
            this.pblMain.Controls.SetChildIndex(this.txtEmail, 0);
            this.pblMain.Controls.SetChildIndex(this.txtLogradouro, 0);
            this.pblMain.Controls.SetChildIndex(this.txtNumero, 0);
            this.pblMain.Controls.SetChildIndex(this.txtBairro, 0);
            this.pblMain.Controls.SetChildIndex(this.lblCidade, 0);
            this.pblMain.Controls.SetChildIndex(this.cmbCidade, 0);
            this.pblMain.Controls.SetChildIndex(this.lblEstado, 0);
            this.pblMain.Controls.SetChildIndex(this.CmbEstados, 0);
            // 
            // pnlId
            // 
            this.pnlId.Location = new System.Drawing.Point(8, 8);
            this.pnlId.Size = new System.Drawing.Size(657, 78);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(11, 195);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(11, 247);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(94, 247);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(16, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(651, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(16, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(651, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Location = new System.Drawing.Point(16, 218);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(651, 26);
            this.txtLogradouro.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(16, 270);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 26);
            this.txtNumero.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(99, 270);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(289, 26);
            this.txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(94, 299);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(99, 322);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(289, 28);
            this.cmbCidade.TabIndex = 12;
            // 
            // CmbEstados
            // 
            this.CmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbEstados.FormattingEnabled = true;
            this.CmbEstados.Location = new System.Drawing.Point(16, 322);
            this.CmbEstados.Name = "CmbEstados";
            this.CmbEstados.Size = new System.Drawing.Size(51, 28);
            this.CmbEstados.TabIndex = 14;
            this.CmbEstados.SelectionChangeCommitted += new System.EventHandler(this.CmbEstados_SelectionChangeCommitted);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(14, 299);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // FrmFormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(675, 530);
            this.Name = "FrmFormClientes";
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

        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox CmbEstados;
        private System.Windows.Forms.Label lblEstado;
    }
}