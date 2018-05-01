using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Menus
{
    public partial class SideBar : Form
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {

        }

        private void lblOpenCloseSideBar_Click(object sender, EventArgs e)
        {
            AuternarSideBar();
        }

        private void AuternarSideBar()
        {
            if (pnlSideBar.Width == 250)
            {
                pnlSideBar.Width = 50;
                lblOpenCloseSideBar.Text = "";
            }
            else
            {
                pnlSideBar.Width = 250;
                lblOpenCloseSideBar.Text = "";
            }
        }

        private void pnlDashBoard_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlDashBoard_MouseLeave(object sender, EventArgs e)
        {
            pnlDashBoard.BackColor = Color.Empty;
        }

        private void pnlDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            pnlDashBoard.BackColor = Color.Orange;
        }
    }
}
