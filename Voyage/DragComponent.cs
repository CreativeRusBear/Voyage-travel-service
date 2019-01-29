using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    class DragComponent : Component
    {
        private Control handleControl;

        public Control SelectControl
        {
            get
            {
                return this.handleControl;
            }
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                DragComponent.ReleaseCapture();
                DragComponent.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
