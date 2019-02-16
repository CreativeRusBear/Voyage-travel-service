using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Voyage
{
    public partial class usReturn : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt,dtForClients;
        SqlDataAdapter adapter, adapterForClients;
        BindingSource bs, bsForClients;
        public usReturn()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
           // cbCauses.SelectedIndex = 0;
            LoadDataFromTables();
        }

        private void cbRoutes_DropDownClosed(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
            LoadDataAboutClients(id);
         }

        private void cbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
            LoadDataAboutClients(id);
        }

        void LoadDataFromTables()
        {
            adapter = new SqlDataAdapter("SELECT tRoutes.ID_Route, tRoutes.sCountry,tGroups.ID_Group, tRoutes.sNameOfRoute, tRoutes.Sale, " +
                   "tGroups.ID_Group, tGroups.sCount, tGroups.sName FROM tGroups INNER JOIN " +
                   "tGroupsRoutes ON tGroups.ID_Group =tGroupsRoutes.ID_Group " +
                   "inner join tRoutes ON tGroupsRoutes.ID_Route = tRoutes.ID_Route", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbRoutes.DataSource = bs;
            cbRoutes.ValueMember = "ID_Route";
            cbRoutes.DisplayMember = "sNameOfRoute";
            int id = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
            LoadDataAboutClients(id);
        }
        void LoadDataAboutClients(int id)
        {
            adapter = new SqlDataAdapter("Select tGroupsClients.ID_Client, concat (tClients.sName, ' ', tClients.sSurname) " +
                "as FIO FROM tGroupsClients inner join tClients on tGroupsClients.ID_Client=tClients.ID_Client " +
                "where tGroupsClients.ID_Group=" + id, connection);
            dtForClients = new DataTable();
            adapter.Fill(dtForClients);
            bsForClients = new BindingSource();
            bsForClients.DataSource = dtForClients;
           /* cbClients.DataSource = bsForClients;
            cbClients.ValueMember = "ID_Client";
            cbClients.DisplayMember = "FIO";*/

        }
        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
            fReturn rtrn = new fReturn();
            rtrn.ShowDialog();
        }
    }
}
