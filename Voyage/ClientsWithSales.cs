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
        int ID = 0, countOfClients=0, abroadDoc=0;

        public ClientsWithSales()
        {
            InitializeComponent();
        }

        public ClientsWithSales(int ID, int countOfClients, int abroadDoc)
        {
            InitializeComponent();
            this.ID = ID;
            this.countOfClients = countOfClients;
            this.abroadDoc = abroadDoc;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            LoadDataFromClients();
        }

        void LoadDataFromClients()
        {
            if (this.abroadDoc==1)
            {
                adapter = new SqlDataAdapter("Select tClients.ID_Client, concat (sName,' ', sSurname) as " +
                    "FIO from tClients LEFT JOIN tGroupsClients ON (tClients.ID_Client=tGroupsClients.ID_Client " +
                    "and tGroupsClients.ID_Group="+this.ID+ ") where (tClients.AbroadDoc=1 and " +
                    "tGroupsClients.ID_Client IS NULL)", connection);
            }
            else
            {
                adapter = new SqlDataAdapter("Select tClients.ID_Client, concat (sName,' ', sSurname) as " +
                    "FIO from tClients LEFT JOIN tGroupsClients ON (tClients.ID_Client=tGroupsClients.ID_Client " +
                    "and tGroupsClients.ID_Group=" + this.ID + ") where (tGroupsClients.ID_Client IS NULL)", connection);
            }
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbAllClients.DataSource = bs;
            cbAllClients.ValueMember = "ID_Client";
            cbAllClients.DisplayMember = "FIO";
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
