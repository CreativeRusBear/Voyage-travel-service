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
        //начальная настройка для отображения и работы с данными
        void starterSettings()
        {
            dtForRoutes = new DataTable();
            adapter.Fill(dtForRoutes);
            bsForRoutes = new BindingSource();
            bsForRoutes.DataSource = dtForRoutes;
            textAboutSale.Text = "При покупке билетов группой от 3-ех и более человек предоставляется скидка " + Convert.ToString(((DataRowView)this.bsForRoutes.Current).Row["Sale"]) + "% каждому";
        }
        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
           DataRouteGroupForSale groupRoute = new DataRouteGroupForSale(Convert.ToInt32(cbNameOfRoute.SelectedValue), Convert.ToInt32(nudCountOfPeople.Value));
           groupRoute.ShowDialog();
        }

        void LoadDataFromTable()
        {
            
            adapter = new SqlDataAdapter("SELECT ID_Route, sNameOfRoute, Sale from tRoutes", connection);
            starterSettings();
            cbNameOfRoute.DataSource = bsForRoutes;
            cbNameOfRoute.ValueMember = "ID_Route";
            cbNameOfRoute.DisplayMember = "sNameOfRoute";
        }
        
        private void cbNameOfRoute_DropDownClosed(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT Sale from tRoutes where sNameOfRoute=" + "'" + cbNameOfRoute.Text + "'", connection);
            starterSettings();
        }
    }
}