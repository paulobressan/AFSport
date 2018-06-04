namespace AFSport.WindowsForms.Formularios.Caixas
{
    partial class FrmFormCaixa
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
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
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
            this.BtnCancelar.Location = new System.Drawing.Point(123, 6);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Location = new System.Drawing.Point(11, 6);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 325);
            this.pnlBtns.Size = new System.Drawing.Size(242, 89);
            // 
            // pblHead
            // 
            this.pblHead.Size = new System.Drawing.Size(242, 50);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(189, 11);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(88, 32);
            this.lblTitulo.Text = "Caixa";
            // 
            // lblIcone
            // 
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.Size = new System.Drawing.Size(242, 10);
            // 
            // pnlbar2
            // 
            this.pnlbar2.Size = new System.Drawing.Size(242, 10);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.txtData);
            this.pblMain.Controls.Add(this.txtValorInicial);
            this.pblMain.Controls.Add(this.lblValor);
            this.pblMain.Controls.Add(this.lblData);
            this.pblMain.Size = new System.Drawing.Size(242, 255);
            this.pblMain.Controls.SetChildIndex(this.lblData, 0);
            this.pblMain.Controls.SetChildIndex(this.lblValor, 0);
            this.pblMain.Controls.SetChildIndex(this.txtValorInicial, 0);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.txtData, 0);
            // 
            // pnlId
            // 
            this.pnlId.Size = new System.Drawing.Size(226, 78);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(13, 166);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(71, 26);
            this.txtData.TabIndex = 11;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(12, 116);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(74, 26);
            this.txtValorInicial.TabIndex = 10;
            this.txtValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(10, 141);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 20);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 20);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor Inicial";
            // 
            // FrmFormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 414);
            this.Name = "FrmFormCaixa";
            this.Text = "FrmFormCaixa";
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

        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
    }
}