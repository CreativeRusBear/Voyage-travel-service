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
    public partial class usSales : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dtForRoutes;
        SqlDataAdapter adapter;
        BindingSource bsForRoutes;
        public usSales()
        {
            InitializeComponent();
            LoadDataFromTable();
            this.ForeColor = Color.FromArgb(0, 71, 160);
        }

        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
           DataRouteGroupForSale groupRoute = new DataRouteGroupForSale(Convert.ToInt32(cbNameOfRoute.SelectedValue), Convert.ToInt32(nudCountOfPeople.Value));
           groupRoute.ShowDialog();
        }

        void LoadDataFromTable()
        {
            adapter = new SqlDataAdapter("SELECT ID_Route, sNameOfRoute from tRoutes", connection);
            dtForRoutes = new DataTable();
            adapter.Fill(dtForRoutes);
            bsForRoutes = new BindingSource();
            bsForRoutes.DataSource = dtForRoutes;
            cbNameOfRoute.DataSource = bsForRoutes;
            cbNameOfRoute.ValueMember = "ID_Route";
            cbNameOfRoute.DisplayMember = "sNameOfRoute";
        }
    }
}
