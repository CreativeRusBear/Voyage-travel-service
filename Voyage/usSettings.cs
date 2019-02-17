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
    public partial class usSettings : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt;
        BindingSource bs;
        string login="";
        string password = "";
        public usSettings()
        {
            InitializeComponent();
        }
        public usSettings(string login)
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            changeBtn.BackColor = Color.FromArgb(0, 71, 160);
            this.login = login;
            adapter = new SqlDataAdapter("SELECT sPassword from tUser WHERE sLog='" + this.login+"'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs= new BindingSource();
            bs.DataSource = dt;
            this.password = Convert.ToString(((DataRowView)this.bs.Current).Row["sPassword"]);
        }
        private void cbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChangePassword.Checked)
            {
                panelForChange.Visible = true;
            }
            else
            {
                panelForChange.Visible = false;
            }
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked) tbNewPassword.UseSystemPasswordChar = false;
            else tbNewPassword.UseSystemPasswordChar = true;
        }

        private void tbOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'Z') && word != '\b' && (word < 'a' || word > 'z') && (word < '0' || word > '9'))
            {
                e.Handled = true;
            }
        }

        //изменение пароля
        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (tbOldPassword.Text!="" && tbNewPassword.Text != ""){
                if(tbOldPassword.Text == this.password)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        SqlCommand updateUserData = new SqlCommand("UPDATE tUser SET " +
                           "sPassword=@Password WHERE sLog=@Login", connection);
                        updateUserData.Parameters.AddWithValue("@Password", tbNewPassword.Text);
                        updateUserData.Parameters.AddWithValue("@Login", this.login);
                        updateUserData.ExecuteNonQuery();
                        MessageBox.Show("Пароль был обновлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.password = tbNewPassword.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        tbOldPassword.Text = "";
                        tbNewPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ваш старый пароль введен неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные и повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
