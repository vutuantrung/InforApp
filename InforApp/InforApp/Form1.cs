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

            userControlProfile1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Purple;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            userControlProfile1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnNote.BackColor = SystemColors.MenuHighlight;

            btnProfile.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            userControlNote1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.DarkCyan;

            btnNote.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            userControlWork1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnStudy.BackColor = Color.Olive;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            userControlStudy1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.DarkSlateGray;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;

            userControlContact1.BringToFront();
        }
    }
}
