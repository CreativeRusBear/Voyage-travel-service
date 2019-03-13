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
        int i=0;

        //стартовые настройки
        void Settings()
        {
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            this.ForeColor = Color.FromArgb(0, 71, 160);
            signInBtn.BackColor = Color.FromArgb(0, 71, 160);
            cbPosition.SelectedIndex = 0;
        }

        //загрузка данных о пользователе
        void loadData(int ID)
        {
            SqlCommand SelectCommand = new SqlCommand("SELECT sLog, sPassword, sRole from tUser WHERE ID_User =" + ID + ";", connection);
            connection.Open();
            SqlDataReader reader = SelectCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbLog.Text = Convert.ToString(reader.GetValue(0));
                    tbPassword.Text = Convert.ToString(reader.GetValue(1));
                    cbPosition.Text = Convert.ToString(reader.GetValue(2));
                }
            }
            connection.Close();
        }

        //работа с данными при нажатии на кнопку "Зарегестрироваться"
        void workWithLoadData(SqlCommand nameOfCommand)
        {
            nameOfCommand.Parameters.AddWithValue("@Log", tbLog.Text);
            nameOfCommand.Parameters.AddWithValue("@Password", tbPassword.Text);
            nameOfCommand.Parameters.AddWithValue("@Position", cbPosition.SelectedItem);
        }

        public Registration(string role="user")
        {
            InitializeComponent();
            Settings();
            if (role == "admin")
            {
                cbPosition.Items.Add("Главный");
            }
        }
        //обновление данных пользователя
        public Registration(int i)
        {
            InitializeComponent();
            this.i = i;
            Settings();
            cbPosition.Items.Add("Главный");
            loadData(i);
            signInBtn.Text = "Обновить";
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

        //событие для регистрации/обновления данных о клиенте
        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (tbLog.Text!="" || tbPassword.Text!= "")
            {
                try
                {
                    connection.Open();
                    if (i == 0)
                    {
                        SqlCommand MaxID = new SqlCommand("Select MAX(ID_User) from tUser", connection);
                        SqlCommand Insert = new SqlCommand("Insert Into [tUser] Values (@Log, @Password, @Position)", connection);
                        workWithLoadData(Insert);
                        Insert.ExecuteNonQuery();
                        MessageBox.Show("Регистрация пройдена успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand commandUpdate = new SqlCommand("UPDATE tUser SET sLog=@Log, sPassword=@Password, sRole= @Position WHERE ID_User=@IDSS", connection);
                        workWithLoadData(commandUpdate);
                        commandUpdate.Parameters.AddWithValue("@IDSS", i);
                        commandUpdate.ExecuteNonQuery();
                        MessageBox.Show("Запись обновлена");
                    }
                    connection.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные и повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //запуск анимации
        private void Registration_Load(object sender, EventArgs e)
        {
            formAnimationAPI.AnimateWindow(this.Handle, 2000, formAnimationAPI.V_Positive);
        }
    }
}
