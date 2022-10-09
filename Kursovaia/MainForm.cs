using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Kursovaia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True");

        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Послуга' table. You can move, or remove it, as needed.
            this.послугаTableAdapter.Fill(this.repairShopDataSet.Послуга);
            // TODO: This line of code loads data into the 'repairShopDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.repairShopDataSet.Клієнт);
            // TODO: This line of code loads data into the 'repairShopDataSet.Автомобіль' table. You can move, or remove it, as needed.
            this.автомобільTableAdapter.Fill(this.repairShopDataSet.Автомобіль);

            dataGridView1.AutoGenerateColumns = true;

        }

        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            автомобільTableAdapter.Update(repairShopDataSet);
            клієнтTableAdapter.Update(repairShopDataSet);
            послугаTableAdapter.Update(repairShopDataSet);
        }

        public void Method(object sender, DataGridViewCellEventArgs e) //автоматизація
        {
            DataGridView grid = sender as DataGridView;
            if ( e.ColumnIndex == 4)
            {
                bool? a = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as bool?;
                if (a == true)
                {
                    using (SqlConnection conn = new SqlConnection(StringCon))
                    {
                        con.Open();
                        SqlDataAdapter manual = new SqlDataAdapter("SELECT Id_Клієнта, Email FROM Клієнт WHERE Id_Клієнта in " +
                            "(SELECT Id_Клієнта FROM Автомобіль WHERE Id_Автомобіля in " +
                            "(SELECT Id_Автомобіля FROM Запис WHERE Id_Запису in " +
                            "(SELECT Id_Запису FROM Запис_Послуга WHERE Id_Послуги in " +
                            $"(SELECT Id_Послуги FROM Послуга WHERE Id_Послуги = {grid.Rows[e.RowIndex].Cells[0].Value}))))", con);

                        DataTable dt = new DataTable();
                        manual.Fill(dt);
                
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string Id = dt.Rows[i][0].ToString();
                            string email = dt.Rows[i][1].ToString();
                            MailAddress from = new MailAddress("andrii.martynenko1@nure.ua", "Автомайстерня");
                            MailAddress to = new MailAddress(email, "Шановний клієнт");
                            MailMessage m = new MailMessage(from, to);
                            m.Subject = "Замовлення";
                            m.Body = "Ваша послуга доступна зараз!!! Та готова до виконання, гарного дня!";
                            m.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.Credentials = new NetworkCredential("andrii.martynenko1@nure.ua", ""); //логин пароль
                            smtp.EnableSsl = true;
                            smtp.Send(m);
                        }
                        con.Close();
                    }
                }
            }
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = автомобільBindingSource;
            dataGridView1.DataSource = автомобільBindingSource;
            label1.Text = "Автомобілі";
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = клієнтBindingSource;
            dataGridView1.DataSource = клієнтBindingSource;
            label1.Text = "Клієнти";
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = послугаBindingSource;
            dataGridView1.DataSource = послугаBindingSource;
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(Method);
            label1.Text = "Послуги";
        }

        private void CarListNotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new CarsList();
            rs.ShowDialog();
            автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
        }

        private void QueryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == автомобільBindingSource)
            {
                автомобільBindingSource.Filter = " [Марка] LIKE'" + textBox1.Text + "%'";
            }
        }

        private void CarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new EditForm();
            qe.Show();
        }

        private bool edit = true;
        private void AddCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (!edit) return;
                var edt = new EditForm();
                edt.ShowDialog();
                автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
                repairShopDataSet.AcceptChanges();
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new RepairShopDataSet.АвтомобільDataTable();
            автомобільTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditForm(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            row[3].ToString(),
            row[4].ToString(),
            row[5].ToString(),
            row[6].ToString(),
            row[7].ToString(),
            Convert.ToInt32(row[8]));
            edt.ShowDialog();
            автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
            repairShopDataSet.AcceptChanges();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            автомобільTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
            repairShopDataSet.AcceptChanges();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new EditClient();
            edt.ShowDialog();
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            repairShopDataSet.AcceptChanges();
        }

        private void UpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new RepairShopDataSet.КлієнтDataTable();
            клієнтTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditClient(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            row[3].ToString(),
            row[4].ToString());
            edt.ShowDialog();
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            repairShopDataSet.AcceptChanges();
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            клієнтTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            repairShopDataSet.AcceptChanges();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new EditService();
            edt.ShowDialog();
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
            repairShopDataSet.AcceptChanges();
        }

        private void UpdateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new RepairShopDataSet.ПослугаDataTable();
            послугаTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditService(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToInt32(row[2]));
            edt.ShowDialog();
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
            repairShopDataSet.AcceptChanges();
        }

        private void DeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            послугаTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
            repairShopDataSet.AcceptChanges();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == клієнтBindingSource)
            {
                клієнтBindingSource.Filter = " [Ім'я] LIKE'" + textBox2.Text + "%'";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == послугаBindingSource)
            {
                послугаBindingSource.Filter = " [Назва послуги] LIKE'" + textBox3.Text + "%'";
            }
        }

        private void Cars1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter manual = new SqlDataAdapter("Select * From Автомобіль Where Трансмісія = 'Manual'", con);
            DataTable dt = new DataTable();
            manual.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Cars2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter manual = new SqlDataAdapter("Select * From Автомобіль Where Трансмісія = 'Automatic'", con);
            DataTable dt = new DataTable();
            manual.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void None_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = автомобільBindingSource;
            dataGridView1.DataSource = автомобільBindingSource;
        }

        private void Car_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void Yearsort_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
        }

        private void Sortname_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Ім'я"], ListSortDirection.Ascending);
        }

        private void Sortphone_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Телефон"], ListSortDirection.Ascending);
        }

        private void Sortcost_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Вартість"], ListSortDirection.Ascending);
        }

        private void Sortposl_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Назва послуги"], ListSortDirection.Ascending);
        }

        private void Notion_button_Click_1(object sender, EventArgs e)
        {
            var rs = new NotionForm();
            rs.ShowDialog();

        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MostPopularServiceCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Queries();
            rs.ShowDialog();
        }

        private void ServicesPriceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Queries1();
            rs.ShowDialog();
        }

        private void PartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Queries2();
            rs.ShowDialog();
        }

        private void AttendingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Queries3();
            rs.ShowDialog();
        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header

            BaseFont bfntHead = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper()));
            document.Add(prgHeading);

            //Add line break
            document.Add(new Chunk("\n"));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper()));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT * FROM Клієнт", con); ;
                DataTable dt = new DataTable();
                manual.Fill(dt);
                dataGridView1.DataSource = dt;


                ExportDataTableToPdf(dt, @"C:\Users\User\Desktop\Reports\ReportClients.pdf", "Clients");
                MessageBox.Show("Report client info created");
                System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\Reports\ReportClients.pdf");
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var rs = new Report1();
            rs.Show();
        }

        private void Details_button_Click(object sender, EventArgs e)
        {

        }

        /*private void Details_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT Id_Клієнта, Email FROM Клієнт WHERE Id_Клієнта in " +
                    "(SELECT Id_Клієнта FROM Автомобіль WHERE Id_Автомобіля in " +
                    "(SELECT Id_Автомобіля FROM Запис WHERE Id_Запису in " +
                    "(SELECT Id_Запису FROM Запис_Послуга WHERE Id_Послуги in " +
                    "(SELECT Id_Послуги FROM Послуга WHERE isReady = 0))))", con);

                DataTable dt = new DataTable();
                manual.Fill(dt);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                }
                
            }
        }*/
    }
}
