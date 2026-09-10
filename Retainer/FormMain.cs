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

        private void comboBox_head_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_respiratory_tract_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_heart_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_circulatory_system_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_intestines_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_eyes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_oral_cavity_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_kidneys_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_liver_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_stomach_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void btnFixing_Click(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.changes;
        }

        private void comboBox_head_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_respiratory_tract_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_heart_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_circulatory_system_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_intestines_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_eyes_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_oral_cavity_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_kidneys_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_liver_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }

        private void comboBox_stomach_TextUpdate(object sender, EventArgs e)
        {
            pictureBox_fixing.Image = Properties.Resources.change;
        }
    }
}
