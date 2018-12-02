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
    public partial class UserControlWorkAmeli : UserControl
    {
        private static UserControlWorkAmeli _instance;

        public static UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlWorkAmeli();
                }
                return _instance;
            }
        }

        public UserControlWorkAmeli()
        {
            InitializeComponent();
        }
    }
}
