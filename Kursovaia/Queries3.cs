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

namespace Kursovaia
{
    public partial class Queries3 : Form
    {
        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        public Queries3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Queries3_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT Майстер.[Ім'я] as Майстер_виконує, Майстер.Телефон, Запис.Примітки as Послугу, " +
                    "Автомобіль.Марка as для_авто, Автомобіль.Модель as моделі FROM Майстер " +
                    "INNER JOIN Запис on Майстер.Id_Майстра = Запис.Id_Майстра " +
                    "INNER JOIN Автомобіль on Автомобіль.Id_Автомобіля = Запис.Id_Автомобіля", con); ;
                DataTable dt = new DataTable();
                manual.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
