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
    public partial class createNewGroup : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt, dtGroup;
        SqlDataAdapter adapter;
        BindingSource bs, bsGroup;


        /*загрузка маршрутов*/
        void LoadDataFromRoutes()
        {
            adapter = new SqlDataAdapter("SELECT tRoutes.ID_Route, tRoutes.sNameOfRoute from tRoutes LEFT JOIN tGroupsRoutes ON tRoutes.ID_Route=tGroupsRoutes.ID_Route WHERE tGroupsRoutes.ID_Route IS NULL", connection);
          
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbRoutes.DataSource = bs;
            cbRoutes.ValueMember = "ID_Route";
            cbRoutes.DisplayMember = "sNameOfRoute";
        }
       void LoadIdGroup(string name)
        {
            adapter = new SqlDataAdapter("SELECT ID_Group from tGroups where sName='"+name+"'", connection);
            dtGroup = new DataTable();
            adapter.Fill(dtGroup);
            bsGroup = new BindingSource();
            bsGroup.DataSource = dtGroup;
        }
        public createNewGroup()
        {
            InitializeComponent();
            LoadDataFromRoutes();
            saveBtn.Enabled = false;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void createNewGroup_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.H_Positive);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandInsert = new SqlCommand("INSERT INTO [tGroups]" +
                " VALUES(@Name, @Count)", connection);
            commandInsert.Parameters.AddWithValue("@Name", tbName.Text);
            commandInsert.Parameters.AddWithValue("@Count", tbCount.Text);
            commandInsert.ExecuteNonQuery();
            connection.Close();
            connection.Open();

            SqlCommand commandInsertRoutes = new SqlCommand("INSERT INTO [tGroupsRoutes]" +
            " VALUES (@ID_Group, @ID_Route)", connection);
            commandInsertRoutes.Parameters.AddWithValue("@ID_Route", Convert.ToInt32(cbRoutes.SelectedValue));
            LoadIdGroup(tbName.Text);
            commandInsertRoutes.Parameters.AddWithValue("@ID_Group", Convert.ToInt32(((DataRowView)this.bsGroup.Current).Row["ID_Group"]));
            commandInsertRoutes.ExecuteNonQuery();
            connection.Close();
            this.Dispose();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbName.Text != "" && tbCount.Text != "")
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }
    }
}
