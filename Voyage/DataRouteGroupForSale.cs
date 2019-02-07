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
    public partial class DataRouteGroupForSale : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
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
            furtherBtn.BackColor= Color.FromArgb(0, 71, 160);
            furtherBtn.Enabled = false;
            this.idRoute = idRoute;
            this.count = count;
            LoadDataFromTable();
        }
        /*Выбор необходимой группы*/
        void LoadDataFromTable()
        {
            adapter = new SqlDataAdapter("SELECT tGroupsRoutes.ID_Route, tGroupsRoutes.ID_Group, tGroups.ID_Group, tGroups.sCount, tGroups.sName FROM tGroups INNER JOIN tGroupsRoutes ON tGroups.ID_Group =tGroupsRoutes.ID_Group" +
            " inner join tRoutes ON tGroupsRoutes.ID_Route = tRoutes.ID_Route WHERE tRoutes.ID_Route=" + this.idRoute, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbGroup.DataSource = bs;
            cbGroup.ValueMember = "ID_Group";
            cbGroup.DisplayMember = "sName";
            if (cbGroup.Items.Count > 0)
            {
                int PlacesCount = Convert.ToInt32(((DataRowView)this.bs.Current).Row["sCount"]),
                    IdGroup = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
                LoadDataAboutCountOfPeople(IdGroup, PlacesCount, this.count);
            }
        }
        /*Возможность добавления клиентов в необходимую группу*/
        void LoadDataAboutCountOfPeople(int idGroup, int allCount, int countSale)
        {
            SqlCommand command = new SqlCommand("SELECT Count(ID_Client) from tGroupsClients where ID_Group=" + idGroup, connection);
            connection.Open();
            int freeCount = allCount - (int)command.ExecuteScalar()-countSale;
            if(freeCount>=0) furtherBtn.Enabled = true;
            connection.Close();
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
