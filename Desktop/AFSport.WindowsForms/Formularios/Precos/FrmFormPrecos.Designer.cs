namespace AFSport.WindowsForms.Formularios.Precos
{
    partial class FrmFormPrecos
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
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
            this.BtnCancelar.Location = new System.Drawing.Point(118, 6);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalvar.Location = new System.Drawing.Point(6, 6);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Location = new System.Drawing.Point(0, 327);
            this.pnlBtns.Size = new System.Drawing.Size(237, 89);
            // 
            // pblHead
            // 
            this.pblHead.Size = new System.Drawing.Size(237, 50);
            // 
            // lblSair
            // 
            this.lblSair.Location = new System.Drawing.Point(191, 13);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(91, 32);
            this.lblTitulo.Text = "Preço";
            // 
            // lblIcone
            // 
            this.lblIcone.Size = new System.Drawing.Size(29, 28);
            this.lblIcone.Text = "";
            // 
            // pnlbar
            // 
            this.pnlbar.Size = new System.Drawing.Size(237, 10);
            // 
            // pnlbar2
            // 
            this.pnlbar2.Size = new System.Drawing.Size(237, 10);
            // 
            // pblMain
            // 
            this.pblMain.Controls.Add(this.cmbProdutos);
            this.pblMain.Controls.Add(this.lblProduto);
            this.pblMain.Controls.Add(this.txtDataFinal);
            this.pblMain.Controls.Add(this.txtDataInicio);
            this.pblMain.Controls.Add(this.lblDataFinal);
            this.pblMain.Controls.Add(this.lblDataInicio);
            this.pblMain.Controls.Add(this.txtValor);
            this.pblMain.Controls.Add(this.lblValor);
            this.pblMain.Size = new System.Drawing.Size(237, 257);
            this.pblMain.Controls.SetChildIndex(this.pnlId, 0);
            this.pblMain.Controls.SetChildIndex(this.lblValor, 0);
            this.pblMain.Controls.SetChildIndex(this.txtValor, 0);
            this.pblMain.Controls.SetChildIndex(this.lblDataInicio, 0);
            this.pblMain.Controls.SetChildIndex(this.lblDataFinal, 0);
            this.pblMain.Controls.SetChildIndex(this.txtDataInicio, 0);
            this.pblMain.Controls.SetChildIndex(this.txtDataFinal, 0);
            this.pblMain.Controls.SetChildIndex(this.lblProduto, 0);
            this.pblMain.Controls.SetChildIndex(this.cmbProdutos, 0);
            // 
            // pnlId
            // 
            this.pnlId.Size = new System.Drawing.Size(221, 78);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(3, 91);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 20);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(7, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(74, 26);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(3, 143);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(70, 20);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Data Início";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(110, 143);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(67, 20);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Data Final";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(7, 166);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(101, 26);
            this.txtDataInicio.TabIndex = 5;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(114, 166);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(110, 26);
            this.txtDataFinal.TabIndex = 6;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(3, 195);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(56, 20);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(10, 218);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(214, 28);
            this.cmbProdutos.TabIndex = 8;
            // 
            // FrmFormPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 416);
            this.Name = "FrmFormPrecos";
            this.Text = "FrmFormulario";
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

        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
    }
}