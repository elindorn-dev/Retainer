using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // 
        bool menuActive = true;
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (menuActive)
            {
                SideMenu.Width -= 10;
                if (SideMenu.Width < 58)
                {
                    menuActive = false;
                    timerMain.Stop();
                }
            }
            else
            {
                SideMenu.Width += 10;
                if (SideMenu.Width > 199)
                {
                    menuActive = true;
                    timerMain.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMain.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
