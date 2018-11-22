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

            _userControlProfile.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Purple;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            _userControlProfile.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnNote.BackColor = SystemColors.MenuHighlight;

            btnProfile.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            _userControlNote.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.DarkCyan;

            btnNote.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            _userControlWork.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnStudy.BackColor = Color.Olive;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnContact.BackColor = Color.Transparent;

            _userControlStudy.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.DarkSlateGray;

            btnNote.BackColor = Color.Transparent;
            btnWork.BackColor = Color.Transparent;
            btnStudy.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;

            _userControlContact.BringToFront();
        }
    }
}
