namespace AFSport.WindowsForms.Formularios.Menus
{
    partial class SideBar
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.pnlSideBarIconeDashBoard = new System.Windows.Forms.Panel();
            this.lblIconeDashBoard = new System.Windows.Forms.Label();
            this.pnlSideBarTop = new System.Windows.Forms.Panel();
            this.lblOpenCloseSideBar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            this.pnlSideBarIconeDashBoard.SuspendLayout();
            this.pnlSideBarTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.pnlDashBoard);
            this.pnlSideBar.Controls.Add(this.pnlSideBarTop);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSideBar.Size = new System.Drawing.Size(250, 431);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDashBoard.Controls.Add(this.lblDashBoard);
            this.pnlDashBoard.Controls.Add(this.pnlSideBarIconeDashBoard);
            this.pnlDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashBoard.Location = new System.Drawing.Point(5, 44);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(238, 37);
            this.pnlDashBoard.TabIndex = 1;
            this.pnlDashBoard.MouseLeave += new System.EventHandler(this.pnlDashBoard_MouseLeave);
            this.pnlDashBoard.MouseHover += new System.EventHandler(this.pnlDashBoard_MouseHover);
            this.pnlDashBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDashBoard_MouseMove);
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Location = new System.Drawing.Point(58, 6);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(86, 18);
            this.lblDashBoard.TabIndex = 1;
            this.lblDashBoard.Text = "Dashboard";
            // 
            // pnlSideBarIconeDashBoard
            // 
            this.pnlSideBarIconeDashBoard.Controls.Add(this.lblIconeDashBoard);
            this.pnlSideBarIconeDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBarIconeDashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBarIconeDashBoard.Name = "pnlSideBarIconeDashBoard";
            this.pnlSideBarIconeDashBoard.Size = new System.Drawing.Size(52, 37);
            this.pnlSideBarIconeDashBoard.TabIndex = 0;
            // 
            // lblIconeDashBoard
            // 
            this.lblIconeDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblIconeDashBoard.AutoSize = true;
            this.lblIconeDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIconeDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconeDashBoard.Location = new System.Drawing.Point(2, 0);
            this.lblIconeDashBoard.Name = "lblIconeDashBoard";
            this.lblIconeDashBoard.Size = new System.Drawing.Size(25, 31);
            this.lblIconeDashBoard.TabIndex = 0;
            this.lblIconeDashBoard.Text = "";
            // 
            // pnlSideBarTop
            // 
            this.pnlSideBarTop.Controls.Add(this.lblOpenCloseSideBar);
            this.pnlSideBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBarTop.Location = new System.Drawing.Point(5, 5);
            this.pnlSideBarTop.Name = "pnlSideBarTop";
            this.pnlSideBarTop.Size = new System.Drawing.Size(238, 39);
            this.pnlSideBarTop.TabIndex = 0;
            // 
            // lblOpenCloseSideBar
            // 
            this.lblOpenCloseSideBar.AutoSize = true;
            this.lblOpenCloseSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpenCloseSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpenCloseSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOpenCloseSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpenCloseSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCloseSideBar.ForeColor = System.Drawing.Color.Black;
            this.lblOpenCloseSideBar.Location = new System.Drawing.Point(209, 0);
            this.lblOpenCloseSideBar.Name = "lblOpenCloseSideBar";
            this.lblOpenCloseSideBar.Size = new System.Drawing.Size(29, 31);
            this.lblOpenCloseSideBar.TabIndex = 0;
            this.lblOpenCloseSideBar.Text = "";
            this.lblOpenCloseSideBar.Click += new System.EventHandler(this.lblOpenCloseSideBar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(352, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 431);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SideBar";
            this.Text = "SideBar";
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlDashBoard.ResumeLayout(false);
            this.pnlDashBoard.PerformLayout();
            this.pnlSideBarIconeDashBoard.ResumeLayout(false);
            this.pnlSideBarIconeDashBoard.PerformLayout();
            this.pnlSideBarTop.ResumeLayout(false);
            this.pnlSideBarTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSideBarTop;
        private System.Windows.Forms.Label lblOpenCloseSideBar;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Panel pnlSideBarIconeDashBoard;
        private System.Windows.Forms.Label lblIconeDashBoard;
        private System.Windows.Forms.Panel panel1;
    }
}