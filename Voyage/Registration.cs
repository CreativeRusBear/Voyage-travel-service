using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class Registration : Form
    {
        Form tAuth;
        public Registration()
        {
            InitializeComponent();
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            this.ForeColor = Color.FromArgb(0, 71, 160);
            signInBtn.BackColor = Color.FromArgb(0, 71, 160);
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
