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
    public partial class fReturn : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        SqlDataAdapter adapter;
        BindingSource bs;
        int ID_Group = 0;
        public fReturn()
        {
            InitializeComponent();
        }
        public fReturn(int ID_Group)
        {
            InitializeComponent();
            this.ID_Group = ID_Group;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            LoadDataAboutClients();
            cbCauses.SelectedIndex = 0;
        }
        //загрузка добавленных клиентов
        void LoadDataAboutClients()
        {
            adapter = new SqlDataAdapter("SELECT tGroupsClients.ID_Client, concat(tClients.sName,' ', tClients.sSurname) as FIO FROM tGroupsClients INNER JOIN tGroups ON tGroups.ID_Group = tGroupsClients.ID_Group" +
       " inner join tClients ON tGroupsClients.ID_Client = tClients.ID_Client WHERE tGroupsClients.ID_Group=" + ID_Group, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbClients.DataSource = bs;
            cbClients.ValueMember = "ID_Client";
            cbClients.DisplayMember = "FIO";
            if (cbClients.Items.Count > 0)
            {
                returnBtn.Enabled = true;
            }
        }
        private void fReturn_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.V_Positive);
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                try
                {
                    connection.Open();
                    SqlCommand Return = new SqlCommand("Delete From tGroupsClients where ID_Group = @ID_Group AND ID_Client=@ID_Client", connection);
                    Return.Parameters.AddWithValue("@ID_Group", this.ID_Group);
                    Return.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(cbClients.SelectedValue));
                    Return.ExecuteNonQuery();
                    MessageBox.Show("Заявление отправлено на рассмотрение", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (SqlException ex)
                {
                    if ((uint)ex.ErrorCode == 0x80004005)
                        MessageBox.Show(
                        "В таблицах есть связанные записи",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    else
                        MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
