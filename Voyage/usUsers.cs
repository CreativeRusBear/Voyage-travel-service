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
    public partial class usUsers : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        SqlDataAdapter adapter;
        BindingSource bs;
        void LoadDataFromTable()
        {
            adapter = new SqlDataAdapter("Select * from tUser",connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dgvUsers.DataSource = bs;
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].HeaderText = "Логин";
            dgvUsers.Columns[2].HeaderText = "Пароль";
            dgvUsers.Columns[3].HeaderText = "Должность";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public usUsers()
        {
            InitializeComponent();
            headerPanel.BackColor = Color.FromArgb(0, 71, 160);
            LoadDataFromTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
           // formAnimationAPI.AnimateWindow(reg.Handle, 2000, formAnimationAPI.V_Positive);
            reg.ShowDialog();
        }
    }
}
