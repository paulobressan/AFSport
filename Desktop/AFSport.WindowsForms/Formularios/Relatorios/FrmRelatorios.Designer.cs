namespace AFSport.WindowsForms.Formularios.Relatorios
{
    partial class FrmRelatorios
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
            this.components = new System.ComponentModel.Container();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.pnlSeparador1 = new System.Windows.Forms.Panel();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.ToolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.pnlGeral.SuspendLayout();
            this.pnlLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.pnlLayout);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGeral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(237, 645);
            this.pnlGeral.TabIndex = 1;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlLayout.Controls.Add(this.panel2);
            this.pnlLayout.Location = new System.Drawing.Point(15, 96);
            this.pnlLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.pnlLayout.Size = new System.Drawing.Size(201, 306);
            this.pnlLayout.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCaixa);
            this.panel2.Controls.Add(this.pnlSeparador1);
            this.panel2.Controls.Add(this.BtnRelatorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel2.Size = new System.Drawing.Size(172, 278);
            this.panel2.TabIndex = 1;
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaixa.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaixa.ForeColor = System.Drawing.Color.White;
            this.BtnCaixa.Location = new System.Drawing.Point(7, 146);
            this.BtnCaixa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(158, 125);
            this.BtnCaixa.TabIndex = 2;
            this.BtnCaixa.Text = "";
            this.ToolTipText.SetToolTip(this.BtnCaixa, "Relatório de Caixa");
            this.BtnCaixa.UseVisualStyleBackColor = false;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // pnlSeparador1
            // 
            this.pnlSeparador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador1.Location = new System.Drawing.Point(7, 132);
            this.pnlSeparador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSeparador1.Name = "pnlSeparador1";
            this.pnlSeparador1.Size = new System.Drawing.Size(158, 14);
            this.pnlSeparador1.TabIndex = 1;
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorio.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorio.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.Location = new System.Drawing.Point(7, 7);
            this.BtnRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(158, 125);
            this.BtnRelatorio.TabIndex = 0;
            this.BtnRelatorio.Text = "";
            this.ToolTipText.SetToolTip(this.BtnRelatorio, "Relatório de Movimentação");
            this.BtnRelatorio.UseVisualStyleBackColor = false;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 645);
            this.Controls.Add(this.pnlGeral);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorios";
            this.pnlGeral.ResumeLayout(false);
            this.pnlLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.Panel pnlSeparador1;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.ToolTip ToolTipText;
    }
}