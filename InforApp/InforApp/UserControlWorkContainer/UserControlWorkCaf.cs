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
    public partial class UserControlWorkCaf : UserControl
    {
        private static UserControlWorkCaf _instance;

        public static UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlWorkCaf();
                }
                return _instance;
            }
        }
        public UserControlWorkCaf()
        {
            InitializeComponent();
        }
    }
}
