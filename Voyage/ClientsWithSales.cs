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
    public partial class ClientsWithSales : Form
    {
        public ClientsWithSales()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void ClientsWithSales_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.Blend);
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
