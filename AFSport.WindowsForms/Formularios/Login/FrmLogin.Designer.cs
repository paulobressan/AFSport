namespace AFSport.WindowsForms.Formularios.Login
{
    partial class FrmLogin
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
            this.LblSair = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIcone = new System.Windows.Forms.Label();
            this.pnlbar = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlBarBtn = new System.Windows.Forms.Panel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pblHead.SuspendLayout();
            this.pnlBarBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbar2
            // 
            this.pnlbar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar2.Location = new System.Drawing.Point(0, 60);
            this.pnlbar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar2.Name = "pnlbar2";
            this.pnlbar2.Size = new System.Drawing.Size(377, 10);
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
            this.pblHead.Size = new System.Drawing.Size(377, 50);
            this.pblHead.TabIndex = 8;
            // 
            // LblSair
            // 
            this.LblSair.AutoSize = true;
            this.LblSair.BackColor = System.Drawing.Color.White;
            this.LblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSair.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSair.ForeColor = System.Drawing.Color.Red;
            this.LblSair.Location = new System.Drawing.Point(324, 12);
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
            this.lblTitulo.Size = new System.Drawing.Size(250, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Acesse sua Conta";
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcone.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcone.Location = new System.Drawing.Point(11, 11);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(40, 28);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(377, 10);
            this.pnlbar.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogin.Location = new System.Drawing.Point(12, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 33);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(12, 175);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 33);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(65, 102);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(300, 39);
            this.txtLogin.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(65, 169);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(300, 39);
            this.txtSenha.TabIndex = 13;
            // 
            // pnlBarBtn
            // 
            this.pnlBarBtn.Controls.Add(this.BtnCancelar);
            this.pnlBarBtn.Controls.Add(this.BtnEntrar);
            this.pnlBarBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarBtn.Location = new System.Drawing.Point(0, 241);
            this.pnlBarBtn.Name = "pnlBarBtn";
            this.pnlBarBtn.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBarBtn.Size = new System.Drawing.Size(377, 59);
            this.pnlBarBtn.TabIndex = 14;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.White;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnEntrar.Location = new System.Drawing.Point(302, 5);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(70, 49);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(232, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(70, 49);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 300);
            this.Controls.Add(this.pnlBarBtn);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlbar2);
            this.Controls.Add(this.pblHead);
            this.Controls.Add(this.pnlbar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBarBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlbar2;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Label LblSair;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblIcone;
        protected System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlBarBtn;
        protected System.Windows.Forms.Button BtnCancelar;
        protected System.Windows.Forms.Button BtnEntrar;
    }
}