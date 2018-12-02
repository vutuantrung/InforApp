using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforApp.UserControlWorkContainer
{
    public partial class UserControlWorkBank : UserControl
    {
        private static UserControlWorkBank _instance;

        public static UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlWorkBank();
                }
                return _instance;
            }
        }

        public UserControlWorkBank()
        {
            InitializeComponent();
        }
    }
}
