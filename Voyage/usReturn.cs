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
        DataTable dt;
        SqlDataAdapter adapter;
        BindingSource bs;
        public usReturn()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            cbCauses.SelectedIndex = 0;
            LoadDataFromTables();
        }
        void LoadDataFromTables()
        {
            adapter = new SqlDataAdapter("SELECT tRoutes.ID_Route, tRoutes.sCountry, tRoutes.sNameOfRoute, tRoutes.Sale, " +
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
           /* lIdOfGroup.DataBindings.Clear();
            lIdOfGroup.DataBindings.Add(new Binding("Text", bs, "ID_Group"));
            lCountOfGroup.DataBindings.Clear();
            lCountOfGroup.DataBindings.Add(new Binding("Text", bs, "sCount"));
            lCountry.DataBindings.Clear();
            lCountry.DataBindings.Add(new Binding("Text", bs, "sCountry"));*/
        }
        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {

        }
    }
}
