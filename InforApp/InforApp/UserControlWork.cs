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
        int[] _arrPosition = new int[6];
        bool ignoreClick = false;

        private Control _activeControl;
        private Point _previousPosition;

        public UserControlWork()
        {
            InitializeComponent();
            SetCordonnate();

            userControlWorkBank1.BringToFront();

            btnBank.MouseDown += new MouseEventHandler(buttonControl_MouseDown);
            btnBank.MouseMove += new MouseEventHandler(buttonControl_MouseMove);
            btnBank.MouseUp += new MouseEventHandler(buttonControl_MouseUp);

            btnCaf.MouseDown += new MouseEventHandler(buttonControl_MouseDown);
            btnCaf.MouseMove += new MouseEventHandler(buttonControl_MouseMove);
            btnCaf.MouseUp += new MouseEventHandler(buttonControl_MouseUp);

            btnAmeli.MouseDown += new MouseEventHandler(buttonControl_MouseDown);
            btnAmeli.MouseMove += new MouseEventHandler(buttonControl_MouseMove);
            btnAmeli.MouseUp += new MouseEventHandler(buttonControl_MouseUp);
        }

        

        private void btnBank_Click(object sender, EventArgs e)
        {
            if (!ignoreClick)
            {
                userControlWorkBank1.BringToFront();
            }
        }

        private void btnCaf_Click(object sender, EventArgs e)
        {
            if (!ignoreClick)
            {
                userControlWorkCaf1.BringToFront();
            }
        }

        private void btnAmeli_Click(object sender, EventArgs e)
        {
            if (!ignoreClick)
            {
                userControlWorkAmeli1.BringToFront();
            }
        }

        private void SetCordonnate()
        {
            for(int i = 0; i < 5; i++)
            {
                _arrPosition[i] = 10 + i * 115 + i * 5;
            }
        }

        #region Button Movement Control
        private void buttonControl_MouseUp(object sender, MouseEventArgs e)
        {
            ignoreClick = false;
            _activeControl.Location = GetNearestPosition(_activeControl.Location.X, _activeControl.Location.Y);
            _activeControl = null;
            Cursor = Cursors.Default;
        }

        private void buttonControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(_activeControl == null || _activeControl != sender)
            {
                return;
            }
            ignoreClick = true;
            var location = _activeControl.Location;
            location.Offset(e.Location.X - _previousPosition.X, e.Location.Y - _previousPosition.Y);
            _activeControl.Location = location;
        }

        private void buttonControl_MouseDown(object sender, MouseEventArgs e)
        {
            _activeControl = sender as Control;
            _previousPosition = e.Location;
            Cursor = Cursors.Hand;
        }
        #endregion

        private Point GetNearestPosition(int posX, int posY)
        {
            int posXValue = 10;
            int posYValue = 10;

            if (posX > 0)
            {
                int minColumn = Math.Abs(_arrPosition[0] - posX);
                for (int i = 1; i < _arrPosition.Length; i++)
                {
                    if (Math.Abs(_arrPosition[i] - posX) < minColumn)
                    {
                        minColumn = Math.Abs(_arrPosition[i] - posX);
                        posXValue = _arrPosition[i];
                    }
                }
            }

            if (posY > 0)
            {
                int minLine = Math.Abs(_arrPosition[0] - posY);
                for (int i = 1; i < _arrPosition.Length; i++)
                {
                    if (Math.Abs(_arrPosition[i] - posY) < minLine)
                    {
                        minLine = Math.Abs(_arrPosition[i] - posY);
                        posYValue = _arrPosition[i];
                    }
                }
            }

            return new Point(posXValue, posYValue);
        }
    }
}
