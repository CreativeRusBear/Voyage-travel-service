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
    public partial class DataRouteGroupForSale : Form
    {
        int idRoute, count;
        public DataRouteGroupForSale()
        {
            InitializeComponent();
        }
        public DataRouteGroupForSale(int idRoute, int count)
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor= Color.FromArgb(0, 71, 160);
            this.idRoute = idRoute;
            this.count = count;
            LoadDataFromTable();
        }
        void LoadDataFromTable()
        {

        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DataRouteGroupForSale_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.Blend);
        }
    }
}
