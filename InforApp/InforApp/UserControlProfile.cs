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
    public partial class UserControlProfile : UserControl
    {
        private static UserControlProfile _instance;

        public static UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UserControlProfile();
                }
                return _instance;
            }
        }

        public UserControlProfile()
        {
            InitializeComponent();
        }
    }
}
