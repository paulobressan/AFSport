namespace AFSport.WindowsForms.Formularios.Pedidos
{
    partial class FrmFinalizadora
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
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.TxtValorPagar = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.pblHead.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbar2
            // 
            this.pnlbar2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar2.Location = new System.Drawing.Point(0, 60);
            this.pnlbar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar2.Name = "pnlbar2";
            this.pnlbar2.Size = new System.Drawing.Size(246, 10);
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
            this.pblHead.Size = new System.Drawing.Size(246, 50);
            this.pblHead.TabIndex = 8;
            // 
            // LblSair
            // 
            this.LblSair.AutoSize = true;
            this.LblSair.BackColor = System.Drawing.Color.White;
            this.LblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSair.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSair.ForeColor = System.Drawing.Color.Red;
            this.LblSair.Location = new System.Drawing.Point(193, 11);
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
            this.lblTitulo.Size = new System.Drawing.Size(74, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pagt";
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIcone.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIcone.Location = new System.Drawing.Point(11, 11);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(44, 28);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(246, 10);
            this.pnlbar.TabIndex = 7;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtns.Controls.Add(this.BtnSalvar);
            this.pnlBtns.Controls.Add(this.BtnCancelar);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtns.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBtns.Location = new System.Drawing.Point(0, 272);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlBtns.Size = new System.Drawing.Size(246, 89);
            this.pnlBtns.TabIndex = 16;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.White;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSalvar.Location = new System.Drawing.Point(15, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(112, 75);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
            this.BtnCancelar.Location = new System.Drawing.Point(127, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 75);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pnlGeral
            // 
            this.pnlGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeral.Controls.Add(this.txtValor);
            this.pnlGeral.Controls.Add(this.lblValor);
            this.pnlGeral.Controls.Add(this.txtTroco);
            this.pnlGeral.Controls.Add(this.lblTroco);
            this.pnlGeral.Controls.Add(this.TxtValorPagar);
            this.pnlGeral.Controls.Add(this.lblValorPago);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 70);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(246, 202);
            this.pnlGeral.TabIndex = 17;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(15, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(218, 35);
            this.txtValor.TabIndex = 21;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 18);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor";
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(15, 155);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(218, 35);
            this.txtTroco.TabIndex = 19;
            this.txtTroco.Text = "0";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(12, 134);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(47, 18);
            this.lblTroco.TabIndex = 18;
            this.lblTroco.Text = "Troco";
            // 
            // TxtValorPagar
            // 
            this.TxtValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorPagar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorPagar.Location = new System.Drawing.Point(15, 94);
            this.TxtValorPagar.Name = "TxtValorPagar";
            this.TxtValorPagar.Size = new System.Drawing.Size(218, 35);
            this.TxtValorPagar.TabIndex = 17;
            this.TxtValorPagar.Text = "0";
            this.TxtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorPagar.TextChanged += new System.EventHandler(this.TxtValorPagar_TextChanged);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(12, 73);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(84, 18);
            this.lblValorPago.TabIndex = 16;
            this.lblValorPago.Text = "Valor pago";
            // 
            // FrmFinalizadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 361);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.pnlbar2);
            this.Controls.Add(this.pblHead);
            this.Controls.Add(this.pnlbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFinalizadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFinalizador";
            this.Load += new System.EventHandler(this.FrmFinalizadora_Load);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlbar2;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Label LblSair;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblIcone;
        protected System.Windows.Forms.Panel pnlbar;
        protected System.Windows.Forms.Panel pnlBtns;
        protected System.Windows.Forms.Button BtnSalvar;
        protected System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox TxtValorPagar;
        private System.Windows.Forms.Label lblValorPago;
    }
}