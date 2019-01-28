using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class Registration : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);

        public Registration()
        {
            InitializeComponent();
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            this.ForeColor = Color.FromArgb(0, 71, 160);
            signInBtn.BackColor = Color.FromArgb(0, 71, 160);
            cbPosition.SelectedIndex = 0;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'Z') && word != '\b' && (word < 'a' || word > 'z') && (word < '0' || word > '9'))
            {
                e.Handled = true;
            }
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked) tbPassword.UseSystemPasswordChar = false;
            else tbPassword.UseSystemPasswordChar = true;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (tbLog.Text.Trim()!="" || tbPassword.Text.Trim() != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select MAX(ID_User) from tUser",connection);
                    SqlCommand Insert = new SqlCommand("Insert Into [tUser] Values (@Log, @Password, @Position)",connection);
                    Insert.Parameters.AddWithValue("@Log", tbLog.Text);
                    Insert.Parameters.AddWithValue("@Password", tbPassword.Text);
                    Insert.Parameters.AddWithValue("@Position", cbPosition.SelectedItem);
                    Insert.ExecuteNonQuery();
                    MessageBox.Show("Регистрация пройдена успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные и повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
