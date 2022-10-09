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
    public partial class Queries1 : Form
    {
        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        public Queries1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Queries1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringCon))
            {
                con.Open();
                SqlDataAdapter manual = new SqlDataAdapter("SELECT Клієнт.[Ім'я] as Власник_володіє, Автомобіль.Марка as маркою, Автомобіль.Модель as та_моделі, Клієнт.Телефон " +
                    "FROM Автомобіль " +
                    "INNER JOIN Клієнт on Автомобіль.Id_Клієнта = Клієнт.Id_Клієнта", con); ;
                DataTable dt = new DataTable();
                manual.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
