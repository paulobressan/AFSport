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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
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
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 377);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(289, 32);
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.cmbCidade);
            this.pblMain.Controls.Add(this.lblCidade);
            this.pblMain.Controls.Add(this.textBox5);
            this.pblMain.Controls.Add(this.txtNumero);
            this.pblMain.Controls.Add(this.txtLogradouro);
            this.pblMain.Controls.Add(this.txtEmail);
            this.pblMain.Controls.Add(this.txtNome);
            this.pblMain.Controls.Add(this.lblBairro);
            this.pblMain.Controls.Add(this.lblNumero);
            this.pblMain.Controls.Add(this.lblEmail);
            this.pblMain.Controls.Add(this.lblLogradouro);
            this.pblMain.Controls.Add(this.lblNome);
            this.pblMain.Size = new System.Drawing.Size(779, 307);
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
            this.pblMain.Controls.SetChildIndex(this.textBox5, 0);
            this.pblMain.Controls.SetChildIndex(this.lblCidade, 0);
            this.pblMain.Controls.SetChildIndex(this.cmbCidade, 0);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 96);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(10, 160);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(78, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(32, 192);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 20);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(44, 224);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 20);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(94, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(94, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(675, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Location = new System.Drawing.Point(94, 158);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(675, 26);
            this.txtLogradouro.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(94, 190);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(46, 26);
            this.txtNumero.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(94, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 26);
            this.textBox5.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(36, 257);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(94, 254);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(250, 28);
            this.cmbCidade.TabIndex = 12;
            // 
            // FrmFormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(779, 466);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label lblCidade;
    }
}