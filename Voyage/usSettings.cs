using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class usSettings : UserControl
    {
        public usSettings()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            changeBtn.BackColor= Color.FromArgb(0, 71, 160);
        }

        private void cbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChangePassword.Checked)
            {
                panelForChange.Visible = true;
            }
            else
            {
                panelForChange.Visible = false;
            }
        }
    }
}
