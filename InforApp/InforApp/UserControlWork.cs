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
        private static UserControlWork _instance;

        public static UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlWork();
                }
                return _instance;
            }
        }

        public UserControlWork()
        {
            InitializeComponent();
        }
    }
}
