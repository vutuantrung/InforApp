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
    public partial class UserControlStudy : UserControl
    {
        private static UserControlStudy _instance;

        public static UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlStudy();
                }
                return _instance;
            }
        }

        public UserControlStudy()
        {
            InitializeComponent();
        }
    }
}
