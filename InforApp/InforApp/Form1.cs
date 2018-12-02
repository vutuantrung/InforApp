using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnProfile.BackColor = Color.Purple;
            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            if (!pnlUserControl.Controls.Contains(UserControlContact.Instance))
            {
                pnlUserControl.Controls.Add(UserControlContact.Instance);
                UserControlContact.Instance.Dock = DockStyle.Fill;
            }

            if (!pnlUserControl.Controls.Contains(UserControlProfile.Instance))
            {
                pnlUserControl.Controls.Add(UserControlProfile.Instance);
                UserControlProfile.Instance.Dock = DockStyle.Fill;
            }

            if (!pnlUserControl.Controls.Contains(UserControlNote.Instance))
            {
                pnlUserControl.Controls.Add(UserControlNote.Instance);
                UserControlNote.Instance.Dock = DockStyle.Fill;
            }

            if (!pnlUserControl.Controls.Contains(UserControlStudy.Instance))
            {
                pnlUserControl.Controls.Add(UserControlStudy.Instance);
                UserControlStudy.Instance.Dock = DockStyle.Fill;
            }

            if (!pnlUserControl.Controls.Contains(UserControlWork.Instance))
            {
                pnlUserControl.Controls.Add(UserControlWork.Instance);
                UserControlWork.Instance.Dock = DockStyle.Fill;
            }

            UserControlProfile.Instance.Dock = DockStyle.Fill;
        }

        private const int cGrip = 16;
        private const int cCapion = 32;

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Purple;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            UserControlProfile.Instance.BringToFront();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            btnNote.BackColor = SystemColors.MenuHighlight;

            btnProfile.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            UserControlNote.Instance.BringToFront();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.DarkCyan;

            btnNote.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            UserControlWork.Instance.BringToFront();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            btnStudy.BackColor = Color.Olive;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            UserControlStudy.Instance.BringToFront();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.DarkSlateGray;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;

            UserControlContact.Instance.BringToFront();
        }

        private void btnMaxiWindow_Click(object sender, EventArgs e)
        {
            if(WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiniWin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
