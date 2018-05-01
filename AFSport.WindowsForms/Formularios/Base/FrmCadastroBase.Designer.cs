namespace AFSport.WindowsForms.Formularios.Base
{
    partial class FrmCadastroBase
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
            this.pnlmargin = new System.Windows.Forms.Panel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pnlmargin2 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmargin
            // 
            this.pnlmargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmargin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmargin.Location = new System.Drawing.Point(0, 0);
            this.pnlmargin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlmargin.Name = "pnlmargin";
            this.pnlmargin.Size = new System.Drawing.Size(1181, 12);
            this.pnlmargin.TabIndex = 0;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavBar.Controls.Add(this.label1);
            this.pnlNavBar.Controls.Add(this.lblTitulo);
            this.pnlNavBar.Controls.Add(this.btnNovo);
            this.pnlNavBar.Controls.Add(this.btnAlterar);
            this.pnlNavBar.Controls.Add(this.btnDeletar);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNavBar.Location = new System.Drawing.Point(0, 12);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlNavBar.Size = new System.Drawing.Size(1181, 80);
            this.pnlNavBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titulo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(874, 5);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 68);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(974, 5);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 68);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(1074, 5);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 68);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // pnlmargin2
            // 
            this.pnlmargin2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmargin2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmargin2.Location = new System.Drawing.Point(0, 92);
            this.pnlmargin2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlmargin2.Name = "pnlmargin2";
            this.pnlmargin2.Size = new System.Drawing.Size(1181, 12);
            this.pnlmargin2.TabIndex = 2;
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBody.Location = new System.Drawing.Point(0, 104);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBody.Size = new System.Drawing.Size(1181, 449);
            this.pnlBody.TabIndex = 3;
            // 
            // FrmCadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlmargin2);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlmargin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastroBase";
            this.Text = "CadastroBase";
            this.Load += new System.EventHandler(this.FrmCadastroBase_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnNovo;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnDeletar;
        protected System.Windows.Forms.Panel pnlmargin;
        protected System.Windows.Forms.Panel pnlNavBar;
        protected System.Windows.Forms.Panel pnlmargin2;
        protected System.Windows.Forms.Panel pnlBody;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label label1;
    }
}