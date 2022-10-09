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
    public partial class Info : Form
    {
        private int idzapis;
        private bool isReady;

        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        public Info(int idzapis, bool isReady)
        {
            InitializeComponent();
            this.idzapis = idzapis;
            this.isReady = isReady;
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


        private void Info_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT [z].Дата,[z].Примітки,[z].Ціна, [a].Марка,[a].Модель,[u].Email,[m].[Ім'я] " +
                    " FROM Запис as z " +
                    "LEFT JOIN Автомобіль as a ON [z].Id_Автомобіля = [a].Id_Автомобіля  " +
                    "LEFT JOIN [Клієнт] as [u] ON [u].Id_Клієнта = [a].Id_Клієнта " +
                    "LEFT JOIN [Майстер] as [m] ON [z].Id_Майстра = [m].Id_Майстра" +
                    $" WHERE [z].Id_Запису = {idzapis}", con); ;
                DataTable dt = new DataTable();
                manual.Fill(dt);
                dataGridView1.DataSource = dt;

                ExportDataTableToPdf(dt, @"C:\Users\User\Desktop\Reports\ReportCheck.pdf", "Check");

                if (isReady)
                {
                    SuccesMessage(dt);
                }
                else
                {
                    ErrorMessage(dt);
                }

                System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\Reports\ReportCheck.pdf");
                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        

            }
        }

        private void SuccesMessage(DataTable dt)
        {
            string email = dt.Rows[0][5].ToString();

            MailAddress from = new MailAddress("andrii.martynenko1@nure.ua", "Автомайстерня");
            MailAddress to = new MailAddress(email, "Шановний клієнт!");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Замовлення";
            m.Body = "Ваше замовлення прийнято";
            m.Attachments.Add(new Attachment("C:/Users/User/Desktop/Reports/ReportCheck.pdf"));
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("andrii.martynenko1@nure.ua", ""); //логин пароль
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void ErrorMessage(DataTable dt)
        {

            string email = dt.Rows[0][5].ToString();

            MailAddress from = new MailAddress("andrii.martynenko1@nure.ua", "Автомайстерня");
            MailAddress to = new MailAddress(email, "Шановний клієнт");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Замовлення";
            m.Body = "На жаль послуга недоступна";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("andrii.martynenko1@nure.ua", ""); //логин пароль
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
