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
        int ID_Group = 0;
        List<int> ID_Route = new List<int>();

        //добавление новой записи
        public createNewGroup()
        {
            InitializeComponent();
            statrterSettings();
            LoadDataFromRoutes();
        }

        //редактирование записи
        public createNewGroup(int ID_Group)
        {
            InitializeComponent();
            this.ID_Group = ID_Group;
            statrterSettings();
            loadData(ID_Group);
            label1.Text = "Изменить группу";
        }

        //стартовые настройки
        void statrterSettings()
        {
            saveBtn.Enabled = false;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
        }

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

        //метод загрузки данных (при нажатии на кнопку Изменить во вкладке Группы)
        void loadData(int ID)
        {
            SqlCommand SelectCommand = new SqlCommand("SELECT tGroups.sName, tGroups.sCount, tRoutes.ID_Route, tRoutes.sNameOfRoute " +
            "FROM tGroups INNER JOIN tGroupsRoutes ON tGroups.ID_Group = tGroupsRoutes.ID_Group INNER JOIN tRoutes on tGroupsRoutes.ID_Route = tRoutes.ID_Route WHERE(tGroups.ID_Group =" + ID + "); ", connection);
            connection.Open();
            SqlDataReader reader = SelectCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbName.Text = Convert.ToString(reader.GetValue(0));
                    tbCount.Text = Convert.ToString(reader.GetValue(1));
                    ID_Route.Add(Convert.ToInt32(reader.GetValue(2)));
                    cbRoutes.Items.Add(Convert.ToString(reader.GetValue(3)));
                    cbRoutes.SelectedItem= Convert.ToString(reader.GetValue(3));
                }
            }
            connection.Close();
            SelectCommand = new SqlCommand("SELECT tRoutes.ID_Route, tRoutes.sNameOfRoute from tRoutes LEFT JOIN tGroupsRoutes ON tRoutes.ID_Route=tGroupsRoutes.ID_Route WHERE tGroupsRoutes.ID_Route IS NULL", connection);
            connection.Open();
            reader = SelectCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ID_Route.Add(Convert.ToInt32(reader.GetValue(0)));
                    cbRoutes.Items.Add(Convert.ToString(reader.GetValue(1)));
                }
            }
            connection.Close();
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void createNewGroup_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.H_Positive);
        }

        private void cbRoutes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ID_Group != 0)
            {
                saveBtn.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (ID_Group == 0)
                {
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tGroups]" +
                        " VALUES(@Name, @Count)", connection);
                    commandInsert.Parameters.AddWithValue("@Name", tbName.Text);
                    commandInsert.Parameters.AddWithValue("@Count", tbCount.Text);
                    commandInsert.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    SqlCommand commandInsertRoutes = new SqlCommand("INSERT INTO [tGroupsRoutes]" +
                    " VALUES (@ID_Group, @ID_Route)", connection);
                    commandInsertRoutes.Parameters.AddWithValue("@ID_Route", cbRoutes.SelectedValue);
                    LoadIdGroup(tbName.Text);
                    commandInsertRoutes.Parameters.AddWithValue("@ID_Group", Convert.ToInt32(((DataRowView)this.bsGroup.Current).Row["ID_Group"]));
                    commandInsertRoutes.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tGroups SET sName=@Name, sCount=@Count WHERE ID_Group=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Name", tbName.Text);
                    commandUpdate.Parameters.AddWithValue("@Count", tbCount.Text);
                    commandUpdate.Parameters.AddWithValue("@IDSS", ID_Group);
                    commandUpdate.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    commandUpdate = new SqlCommand("UPDATE tGroupsRoutes SET ID_Route=@ID_Route WHERE ID_Group=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@ID_Route", ID_Route[cbRoutes.SelectedIndex]);
                    commandUpdate.Parameters.AddWithValue("@IDSS", ID_Group);
                    commandUpdate.ExecuteNonQuery();
                }
                connection.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
