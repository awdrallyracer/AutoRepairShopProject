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
    public partial class NotionForm : Form
    {
        string StringCon = "Data Source=ANDREW-PC;Initial Catalog=RepairShop;Integrated Security=True";

        private readonly int id;

        readonly bool edit;
        public NotionForm()
        {
            InitializeComponent();
            записTableAdapter.Fill(repairShopDataSet.Запис);
            запис_ПослугаTableAdapter.Fill(repairShopDataSet.Запис_Послуга);
            edit = false;
        }

          public NotionForm(int id, int id_a, int id_m, DateTime date, String primitki, int cina, int zap, int pos)
          {
              InitializeComponent();
              автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
              edit = true;
              this.id = id;
              id_АвтомобіляTextBox.Text = id_a.ToString();
              id_МайстраTextBox.Text = id_m.ToString();
              датаDateTimePicker.Value = date;
              приміткиTextBox.Text = primitki;
              цінаTextBox.Text = cina.ToString();
          

           // id_ЗаписуTextBox1.Text = zap.ToString();
           // id_ПослугиComboBox.Text =pos.ToString();
          }



        private void ЗаписBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairShopDataSet);

        }

        private void NotionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Запчастина' table. You can move, or remove it, as needed.
            this.запчастинаTableAdapter.Fill(this.repairShopDataSet.Запчастина);
            // TODO: This line of code loads data into the 'repairShopDataSet.Запис_Послуга' table. You can move, or remove it, as needed.
            this.запис_ПослугаTableAdapter.Fill(this.repairShopDataSet.Запис_Послуга);
            // TODO: This line of code loads data into the 'repairShopDataSet.Майстер' table. You can move, or remove it, as needed.
            this.майстерTableAdapter.Fill(this.repairShopDataSet.Майстер);
            // TODO: This line of code loads data into the 'repairShopDataSet.Автомобіль' table. You can move, or remove it, as needed.
            this.автомобільTableAdapter.Fill(this.repairShopDataSet.Автомобіль);
            // TODO: This line of code loads data into the 'repairShopDataSet.Послуга' table. You can move, or remove it, as needed.
            this.послугаTableAdapter.Fill(this.repairShopDataSet.Послуга);
            // TODO: This line of code loads data into the 'repairShopDataSet.Запис' table. You can move, or remove it, as needed.
            this.записTableAdapter.Fill(this.repairShopDataSet.Запис);

            

        }

        private void Note_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                записTableAdapter.InsertQuery((int.Parse(id_АвтомобіляTextBox.Text)), (int.Parse(id_МайстраTextBox.Text)), датаDateTimePicker.Value, приміткиTextBox.Text, (int.Parse(цінаTextBox.Text)));
                записTableAdapter.Fill(repairShopDataSet.Запис);
                repairShopDataSet.AcceptChanges();

                using (SqlConnection con = new SqlConnection(StringCon))
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("SELECT TOP 1 Id_Запису FROM Запис ORDER BY Id_Запису Desc", con);

                    SqlCommand auto = new SqlCommand($"SELECT isReady FROM Послуга WHERE [Назва послуги] = '{приміткиTextBox.Text}'", con);
                    bool isReady = (bool)auto.ExecuteScalar();

                    object id = cm.ExecuteScalar() ;

                 

                    var info = new Info((int)id, isReady);
                    info.ShowDialog();
                }


            }
        }

      

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ПриміткиTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void ПриміткиTextBox_TextChanged(object sender, EventArgs e)
        {
            if (приміткиTextBox.Text == "Покраска")
            {
                цінаTextBox.Items.Clear();
                цінаTextBox.Items.AddRange(new string[] { "200" });
                цінаTextBox.SelectedIndex = 0;
            }
            else if (приміткиTextBox.Text == "Ремонт двигуна")
            {
                цінаTextBox.Items.Clear();
                цінаTextBox.Items.AddRange(new string[] { "500" });
                цінаTextBox.SelectedIndex = 0;
            }
            else if (приміткиTextBox.Text == "Ремонт траансмісії")
            {
                цінаTextBox.Items.Clear();
                цінаTextBox.Items.AddRange(new string[] { "400" });
                цінаTextBox.SelectedIndex = 0;
            }
            else if (приміткиTextBox.Text == "Заміна масла")
            {
                цінаTextBox.Items.Clear();
                цінаTextBox.Items.AddRange(new string[] { "50" });
                цінаTextBox.SelectedIndex = 0;
            }
            else if (приміткиTextBox.Text == "Заміна шин")
            {
                цінаTextBox.Items.Clear();
                цінаTextBox.Items.AddRange(new string[] { "50" });
                цінаTextBox.SelectedIndex = 0;
            }

        }

        private void Id_ЗаписуTextBox_TextChanged(object sender, EventArgs e)
        {
          // id_ЗаписуTextBox1.Text = id_ЗаписуTextBox.Text;
        }

    }
}
