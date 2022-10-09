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
    public partial class Queries2 : Form
    {
        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        public Queries2()
        {
            InitializeComponent();
        }

        private void Queries2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT TOP 1 Запис.Примітки as Послуга, COUNT(*) as Кількість FROM Запис " +
                    "INNER JOIN Послуга on Запис.Примітки = Послуга.[Назва послуги] " +
                    "GROUP BY Запис.Примітки HAVING COUNT(*) > 1", con); ;
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
