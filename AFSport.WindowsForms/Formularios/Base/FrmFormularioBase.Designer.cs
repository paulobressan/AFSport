namespace AFSport.WindowsForms.Formularios.Base
{
    partial class FrmFormularioBase
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
            this.pblHead = new System.Windows.Forms.Panel();
            this.lblSair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pblMain = new System.Windows.Forms.Panel();
            this.pnlId = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.pblHead.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pblMain.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblHead
            // 
            this.pblHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblHead.Controls.Add(this.lblSair);
            this.pblHead.Controls.Add(this.label1);
            this.pblHead.Controls.Add(this.lblTitulo);
            this.pblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblHead.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblHead.Location = new System.Drawing.Point(0, 0);
            this.pblHead.Margin = new System.Windows.Forms.Padding(2);
            this.pblHead.Name = "pblHead";
            this.pblHead.Size = new System.Drawing.Size(584, 45);
            this.pblHead.TabIndex = 0;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.SystemColors.Control;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.Red;
            this.lblSair.Location = new System.Drawing.Point(536, 7);
            this.lblSair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(40, 28);
            this.lblSair.TabIndex = 2;
            this.lblSair.Text = "";
            this.lblSair.Click += new System.EventHandler(this.LblSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(8, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(584, 65);
            this.panel2.TabIndex = 1;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(428, 4);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 55);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(503, 4);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 55);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pblMain
            // 
            this.pblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblMain.Controls.Add(this.pnlId);
            this.pblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblMain.Location = new System.Drawing.Point(0, 45);
            this.pblMain.Margin = new System.Windows.Forms.Padding(2);
            this.pblMain.Name = "pblMain";
            this.pblMain.Padding = new System.Windows.Forms.Padding(4);
            this.pblMain.Size = new System.Drawing.Size(584, 301);
            this.pblMain.TabIndex = 2;
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.LblId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(4, 4);
            this.pnlId.Name = "pnlId";
            this.pnlId.Padding = new System.Windows.Forms.Padding(5);
            this.pnlId.Size = new System.Drawing.Size(574, 57);
            this.pnlId.TabIndex = 0;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblId.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.Red;
            this.LblId.Location = new System.Drawing.Point(510, 5);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(59, 46);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID";
            // 
            // FrmFormularioBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pblMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pblHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFormularioBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioBase";
            this.Load += new System.EventHandler(this.FrmFormularioBase_Load);
            this.pblHead.ResumeLayout(false);
            this.pblHead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pblMain.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button BtnSalvar;
        protected System.Windows.Forms.Button BtnCancelar;
        protected System.Windows.Forms.Panel pblHead;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel pblMain;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblSair;
        protected System.Windows.Forms.Panel pnlId;
        protected System.Windows.Forms.Label LblId;
    }
}