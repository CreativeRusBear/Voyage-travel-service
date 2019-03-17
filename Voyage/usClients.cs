﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace Voyage
{
    public partial class usClients : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;

        //загрузка данных  из таблиц
        void LoadDataFromTable()
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tClients Order By sName, sSurname", connection);
                ds = new DataSet();
                //заполняем ds
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];

                tbName.DataBindings.Clear();
                tbName.DataBindings.Add(new Binding("Text", bs, "sName"));
                tbSurname.DataBindings.Clear();
                tbSurname.DataBindings.Add(new Binding("Text", bs, "sSurname"));
                tbPatronymic.DataBindings.Clear();
                tbPatronymic.DataBindings.Add(new Binding("Text", bs, "sPatronymic"));
                photoOfClient.Image = imageList1.Images[0];
                if (bs.Count > 0) LoadPhoto();
                dtpBithday.DataBindings.Clear();
                dtpBithday.DataBindings.Add(new Binding("Text", bs, "Bithday"));
                cbDoc.DataBindings.Clear();
                cbDoc.DataBindings.Add(new Binding("Text", bs, "sDoc"));
                tbSeries.DataBindings.Clear();
                tbSeries.DataBindings.Add(new Binding("Text", bs, "Series"));
                tbNumber.DataBindings.Clear();
                tbNumber.DataBindings.Add(new Binding("Text", bs, "Number"));
                lbDocIssue.DataBindings.Clear();
                lbDocIssue.DataBindings.Add(new Binding("Text", bs, "sDocIssue"));
                dtpDateIssue.DataBindings.Clear();
                dtpDateIssue.DataBindings.Add(new Binding("Text", bs, "DateIssue"));
                AbroadDoc.DataBindings.Clear();
                AbroadDoc.DataBindings.Add(new Binding("Checked", bs, "AbroadDoc"));
                // Отображаем данные
                dgvClients.DataSource = bs;
                dgvClients.Columns[0].Visible = false;
                dgvClients.Columns[1].HeaderText = "Имя";
                dgvClients.Columns[2].HeaderText = "Фамилия";
                dgvClients.Columns[3].Visible = false;
                dgvClients.Columns[4].Visible = false;
                dgvClients.Columns[5].Visible = false;
                dgvClients.Columns[6].Visible = false;
                dgvClients.Columns[7].Visible = false;
                dgvClients.Columns[8].Visible = false;
                dgvClients.Columns[9].Visible = false;
                dgvClients.Columns[10].Visible = false;
                dgvClients.Columns[11].Visible = false;
                dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvClients.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

                //подсчет клиентов
                lCount.Text = bs.Count.ToString()+" человек";
                checkForAvailability();
            }
        }

        //загузка фото
        void LoadPhoto()
        {
            string fileName = "";
            photoOfClient.Image = imageList1.Images[0];
            string s = ((DataRowView)this.bs.Current).Row["Photo"].ToString();
            if (s != null)
                if (s != "")
                {
                    photoOfClient.Load(@"img\clients\" + s);
                    fileName = s;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        fileName = fileName.Replace(c, '_');
                    }
                }
            nameOfPhoto.Text = fileName;
        }

        //очистка необходимых полей и ячеек
        private void ClearText()
        {
            photoOfClient.Image = imageList1.Images[0];
            nameOfPhoto.Text = "";
            tbName.Text = "";
            tbSurname.Text = "";
            tbPatronymic.Text = "";
            tbSeries.Text = "";
            tbNumber.Text = "";
            lbDocIssue.Text = "";
            cbDoc.SelectedIndex = 0;
            dtpBithday.Text = DateTime.Now.ToString();
            dtpDateIssue.Text= DateTime.Now.ToString();
            AbroadDoc.Checked = false;
        }

        //метод проверки наличия записей
        void checkForAvailability()
        {
            if (bs.Count == 0)
            {
                chooseDisplay(false);
            }
            else
            {
                chooseDisplay(true);
            }
        }
        //методотображения элементов
        void chooseDisplay(bool val)
        {
            tbName.Enabled = val;
            tbSurname.Enabled = val;
            tbPatronymic.Enabled = val;
            dtpBithday.Enabled = val;
            photoOfClient.Enabled = val;
            cbDoc.Enabled = val;
            tbSeries.Enabled = val;
            tbNumber.Enabled = val;
            lbDocIssue.Enabled = val;
            dtpDateIssue.Enabled = val;
            AbroadDoc.Enabled = val;
        }

        //метод, использующиеся для показа/скрытия кнопки сохранить
        void EnabledBtn()
        {
            if ((tbSeries.Text.Length - tbSeries.MaxLength == 0) && (tbNumber.Text.Length - tbNumber.MaxLength == 0) 
                && tbName.Text.Length != 0 && tbSurname.Text.Length != 0)
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }   
        }

        public usClients()
        {
            InitializeComponent();
            LoadDataFromTable();
            forBtn = false;
            this.ForeColor=Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor= Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor=Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        //отображение/скрытие окна поиска 
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
            {
                label11.Visible = false;
                tbSearchClient.Visible = false;
            }
            else
            {
                label11.Visible = true;
                tbSearchClient.Visible = true;
            }
        }

        //кнопка отмены/удаления 
        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn)
            {
                //отмена
                forBtn = false;
            }
            else if (bs.Count > 0)
            {
                //удаление
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
                try
                {
                    DialogResult result = MessageBox.Show(
                   "Нажмите \"Ок\", чтобы удалить запись. \"Отмена\" - для того, чтобы отменить внесенные изменения",
                   "Удаление",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Cancel)
                    {
                        ClearText();
                        LoadDataFromTable();
                        return;
                    }
                    if (result == DialogResult.OK)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tClients where ID_Client = @ID", connection);
                        Delete.Parameters.AddWithValue("@ID", delId);
                        Delete.ExecuteNonQuery();
                    }
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
                    else if ((uint)ex.ErrorCode == 0x80131904)
                        MessageBox.Show(
                        "Клиент добавлен в одну из существующих групп",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
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
            ClearText();
            LoadDataFromTable();
        }

        //изменение текущей фотографии
        private void photoOfClient_DoubleClick(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = "c:\\";
            Dialog.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = Dialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            photoOfClient.Image = Image.FromFile(Dialog.FileName);
                            nameOfPhoto.Text = Dialog.SafeFileName.ToString();
                            EnabledBtn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка:" + ex.Message);
                }
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только русских и ангийских символов
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < 'A' || word > 'Z') && word != '\b'  && (word < 'a' || word > 'z') && (word < 'а' || word > 'я'))
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        //добавление новой записи
        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
            chooseDisplay(true);
        }

        //событие для перехода по записям
        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                photoOfClient.Image = imageList1.Images[0];
                LoadPhoto();
            }
            saveBtn.Enabled = false;
        }

        //кнопка сохранения/обновления данных
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Client) from tClients", connection);
                    int max = int.Parse(dgvClients.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tClients]" +
                        " VALUES(@Name, @Surname, @Patronymic, @Photo, @Bithday, @Doc, @Series, @Number,"+
                        " @DocIssue, @DateIssue, @AbroadDoc)", connection);
                    commandInsert.Parameters.AddWithValue("@Name", tbName.Text);
                    commandInsert.Parameters.AddWithValue("@Surname", tbSurname.Text);
                    commandInsert.Parameters.AddWithValue("@Patronymic", tbPatronymic.Text);
                    commandInsert.Parameters.AddWithValue("@Bithday", dtpBithday.Text);
                    commandInsert.Parameters.AddWithValue("@Doc", cbDoc.Text);
                    commandInsert.Parameters.AddWithValue("@Series", tbSeries.Text);
                    commandInsert.Parameters.AddWithValue("@Number", tbNumber.Text);
                    commandInsert.Parameters.AddWithValue("@DocIssue", lbDocIssue.Text);
                    commandInsert.Parameters.AddWithValue("@DateIssue", dtpDateIssue.Text);
                    commandInsert.Parameters.AddWithValue("@AbroadDoc", AbroadDoc.Checked);
                    if ((photoOfClient.Image != null) && (!(System.IO.File.Exists(@"img\clients\" + nameOfPhoto.Text)))) {
                        if(nameOfPhoto.Text!="")
                        photoOfClient.Image.Save(@"img\clients\" + nameOfPhoto.Text);
                    }
                    commandInsert.Parameters.AddWithValue("@Photo", nameOfPhoto.Text);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена");
                    forBtn = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromTable();
                }

            } else if (bs.Count > 0)
            {
                int i = bs.Position;
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tClients SET " +
                        "sName=@Name, sSurname=@Surname, sPatronymic=@Patronymic, Photo=@Photo, Bithday=@Bithday, sDoc=@Doc, Series=@Series," +
                        " Number=@Number, sDocIssue=@DocIssue, DateIssue=@DateIssue, AbroadDoc=@AbroadDoc WHERE ID_Client=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Name", tbName.Text);
                    commandUpdate.Parameters.AddWithValue("@Surname", tbSurname.Text);
                    commandUpdate.Parameters.AddWithValue("@Patronymic", tbPatronymic.Text);
                    commandUpdate.Parameters.AddWithValue("@Bithday", dtpBithday.Text);
                    commandUpdate.Parameters.AddWithValue("@Doc", cbDoc.Text);
                    commandUpdate.Parameters.AddWithValue("@Series", tbSeries.Text);
                    commandUpdate.Parameters.AddWithValue("@Number", tbNumber.Text);
                    commandUpdate.Parameters.AddWithValue("@DocIssue", lbDocIssue.Text);
                    commandUpdate.Parameters.AddWithValue("@DateIssue", dtpDateIssue.Text);
                    commandUpdate.Parameters.AddWithValue("@AbroadDoc", AbroadDoc.Checked);
                    if ((nameOfPhoto.Text != "") && (!(System.IO.File.Exists(@"img\clients\" + nameOfPhoto.Text)))) photoOfClient.Image.Save(@"img\clients\" + nameOfPhoto.Text);
                    commandUpdate.Parameters.AddWithValue("@Photo", nameOfPhoto.Text);
                    commandUpdate.Parameters.AddWithValue("@IDSS", ID_SS);
                    commandUpdate.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromTable();
                    bs.Position = i;
                }

            }
            saveBtn.Enabled = false;
        }

        //вывод в Excel
        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список клиентов";
            workSheet.Cells[1, 1] = "Имя";
            workSheet.Cells[1, 2] = "Фамилия";
            workSheet.Cells[1, 3] = "Отчество";
            workSheet.Cells[1, 4] = "День рождения";
            workSheet.Cells[1, 5] = "Документ, удостоверяющий личность";
            workSheet.Cells[1, 6] = "Серия";
            workSheet.Cells[1, 7] = "Номер";
            workSheet.Cells[1, 8] = "Документ выдан...";
            workSheet.Cells[1, 9] = "Дата выдачи";
            workSheet.Cells[1, 10] = "Наличие загрант паспорта";
            Excel.Range title = workSheet.Range["A1:J1"];
            title.Cells.Font.Name = "Tahoma";
            title.Font.Size = "16";
            title.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
            title.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xCC));
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.EntireColumn.AutoFit();
            title.EntireRow.AutoFit();
            title.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for (int i = 0; i < dgvClients.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvClients.RowCount; j++)
                {
                    if (i > 3)
                    {
                        workSheet.Cells[j + 2, i] = dgvClients.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i].Font.Size = "14";
                        workSheet.Cells[j + 2, i].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    else
                    {
                        workSheet.Cells[j + 2, i + 1] = dgvClients.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i + 1].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i + 1].Font.Size = "14";
                        workSheet.Cells[j + 2, i + 1].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i + 1].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                }

            }
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        //поиск
        private void tbSearchClient_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "sName LIKE '%" + tbSearchClient.Text + "%' OR sSurname LIKE '%" + tbSearchClient.Text + "%'";
        }

        private void tbSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < '0' || word > '9') && word != '\b')
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void cbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void AbroadDoc_CheckedChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void tbSeries_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void usClients_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }
    }
}