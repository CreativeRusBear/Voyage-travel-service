using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class ClientsWithSales : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt, dtForAddClients;
        SqlDataAdapter adapter;
        BindingSource bs, bsForAddClients;
        int ID = 0, countOfClients=0;

        public ClientsWithSales()
        {
            InitializeComponent();
        }

        public ClientsWithSales(int ID, int countOfClients)
        {
            InitializeComponent();
            this.ID = ID;
            this.countOfClients = countOfClients;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
           // LoadDataFromClients();
            //MessageBox.Show($"{this.ID} {this.countOfClients}");
        }

        /*void LoadDataFromClients()
        {
            adapter = new SqlDataAdapter("SELECT tClients.ID_Client,  CONCAT(sName,' ',sSurname) as FIO from tClients LEFT JOIN tGroupsClients ON  tClients.ID_Client=tGroupsClients.ID_Client WHERE tGroupsClients.ID_Client IS NULL", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbAllClients.DataSource = bs;
            cbAllClients.ValueMember = "ID_Client";
            cbAllClients.DisplayMember = "FIO";
        }*/

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
