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
        List<int> ID_User = new List<int>();

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

        //добавить клиента в список
        private void addPunct_Click(object sender, EventArgs e)
        {
            if (ID_User.Count != this.countOfClients)
            {
                bool add = false;
                if (cbClientsWithSales.Items.Count > 0)
                {
                    for (int i = 0; i < cbClientsWithSales.Items.Count; i++)
                    {
                        if (cbAllClients.Text == cbClientsWithSales.Items[i].ToString()) add = true;
                    }
                }
                if (add == false)
                {
                    ID_User.Add(Convert.ToInt32(cbAllClients.SelectedValue));
                    cbClientsWithSales.Items.Add(cbAllClients.Text);
                    cbClientsWithSales.SelectedItem = cbAllClients.Text;
                    if (ID_User.Count == this.countOfClients)
                    {
                        addNewClientsWithSales.Enabled = true;
                    }
                }
            }
        }

        //добавление клиентов со сидкой в бд
        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < this.ID_User.Count; i++)
                {
                    connection.Open();
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tGroupsClients]" +
                          " VALUES (@ID_Group, @ID_Client, @Sale)", connection);
                    commandInsert.Parameters.AddWithValue("@ID_Group", this.ID);
                    commandInsert.Parameters.AddWithValue("@ID_Client", this.ID_User[i]);
                    commandInsert.Parameters.AddWithValue("@Sale", true);
                    commandInsert.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Скидка успешно оформлена");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //удалить клиента из списока
        private void delPunct_Click(object sender, EventArgs e)
        {
            if (cbClientsWithSales.Items.Count > 0)
            {
                ID_User.RemoveAt(cbClientsWithSales.SelectedIndex);
                cbClientsWithSales.Items.RemoveAt(cbClientsWithSales.SelectedIndex);
                if (ID_User.Count != this.countOfClients)
                {
                    addNewClientsWithSales.Enabled = false;
                }
                if (cbClientsWithSales.Items.Count > 0)
                {
                    cbClientsWithSales.SelectedIndex = 0;
                }
            }
        }

        //загрузка клиентов
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
