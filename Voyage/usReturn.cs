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
    public partial class usReturn : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        SqlDataAdapter adapter;
        BindingSource bs;
        public usReturn()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            LoadDataFromTable();
        }

        //начальная настройка для отображения и работы с данными
        void starterSettings()
        {
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            textAboutSale.Text = $"Возврат денежных средств из общей суммы составляет {Convert.ToString(((DataRowView)this.bs.Current).Row["sReturn"])}%";
        }

        //загрузка возврата при выборе другого маршрута
        private void cbRoutes_DropDownClosed(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT sReturn from tRoutes where sNameOfRoute=" + "'" +
            cbRoutes.Text + "'", connection);
            starterSettings();
        }

        //загрузка данных
        void LoadDataFromTable()
        {
            try { 
            adapter = new SqlDataAdapter("SELECT tRoutes.ID_Route, tGroups.ID_Group, tRoutes.sNameOfRoute, tRoutes.sReturn, " +
                   "tGroups.sName FROM tGroups INNER JOIN " +
                   "tGroupsRoutes ON tGroups.ID_Group =tGroupsRoutes.ID_Group " +
                   "inner join tRoutes ON tGroupsRoutes.ID_Route = tRoutes.ID_Route", connection);
            starterSettings();
            cbRoutes.DataSource = bs;
            cbRoutes.ValueMember = "ID_Route";
            cbRoutes.DisplayMember = "sNameOfRoute";
            ID_Group.DataBindings.Clear();
            ID_Group.DataBindings.Add(new Binding("Text", bs, "ID_Group"));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(
                "Прежде чем начать работу с разделом 'Возвраты', необходимо добавить группу",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                mainElements.Visible = false;
                addNewClientsWithSales.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //переход к след. пункту
        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
            fReturn rtrn = new fReturn(Convert.ToInt32(ID_Group.Text));
            rtrn.ShowDialog();
        }
    }
}
