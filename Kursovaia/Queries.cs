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
    public partial class Queries : Form
    {

        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        public Queries()
        {
            InitializeComponent();
        }

        private void Queries_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT TOP 3 Запис.Id_Автомобіля, COUNT(*) AS Кількість_обслуговувань, Автомобіль.Марка, Автомобіль.Модель " +
                    "FROM Запис " +
                    "INNER JOIN Автомобіль ON Запис.Id_Автомобіля = Автомобіль.Id_Автомобіля " +
                    "GROUP BY Запис.Id_Автомобіля, Автомобіль.Марка, Автомобіль.Модель " +
                    "HAVING COUNT(*) > 1", con); ;
                DataTable dt = new DataTable();
                manual.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
