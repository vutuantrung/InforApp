using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforApp
{
    public partial class UserControlWork : UserControl
    {
        public UserControlWork()
        {
            InitializeComponent();

            userControlWorkBank1.BringToFront();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            userControlWorkBank1.BringToFront();
        }

        private void btnCaf_Click(object sender, EventArgs e)
        {
            userControlWorkCaf1.BringToFront();
        }

        private void btnAmeli_Click(object sender, EventArgs e)
        {
            userControlWorkAmeli1.BringToFront();
        }
    }
}
