using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class EditForm : Form
    {
        private readonly int id;

        readonly bool edit;

        public EditForm()
        {
            InitializeComponent();
            автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
            edit = false;
        }

        public EditForm(int id, String marka, String model, String engine , String transmission, String privod, string color, String year, int idclienta)
        {
            InitializeComponent();
            автомобільTableAdapter.Fill(repairShopDataSet.Автомобіль);
            edit = true;
            this.id = id;
            marka_comboBox.Text = marka;
            model_comboBox.Text = model;
            year_textBox.Text = year;
            color_textBox.Text = color;
            transmisia_comboBox.Text = transmission;
            privod_comboBox.Text = privod;
            dvigun_comboBox.Text = engine;
            idC_comboBox.DataSource = клієнтBindingSource;
            this.idclienta = idclienta.ToString();

        }

        private string idclienta;
        private void Model_comboBox_TextUpdate(object sender, EventArgs e)
        {
         
        }

        private void Model_comboBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Marka_comboBox_TextChanged(object sender, EventArgs e) 
        {
            if (marka_comboBox.Text == "Subaru")
            {
                model_comboBox.Items.Clear();
                model_comboBox.Items.AddRange(new string[] { "WRX", "STI" });
            }
            else
                if (marka_comboBox.Text == "Nissan")
                {
                    model_comboBox.Items.Clear();
                    model_comboBox.Items.AddRange(new string[] { "Almera", "GTR" });
                }
            else
                if (marka_comboBox.Text == "Toyota")
                 {
                    model_comboBox.Items.Clear();
                    model_comboBox.Items.AddRange(new string[] { "Prado", "Mark II" });
                 }
            else
                if (marka_comboBox.Text == "BMW")
                {
                    model_comboBox.Items.Clear();
                    model_comboBox.Items.AddRange(new string[] { "M3", "M5" });
                }
            else
                if (marka_comboBox.Text == "Volkswagen")
                {
                    model_comboBox.Items.Clear();
                    model_comboBox.Items.AddRange(new string[] { "Polo", "Golf" });
                }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.repairShopDataSet.Клієнт);
            // TODO: This line of code loads data into the 'repairShopDataSet.Автомобіль' table. You can move, or remove it, as needed.
            this.автомобільTableAdapter.Fill(this.repairShopDataSet.Автомобіль);
            idC_comboBox.SelectedIndex = idC_comboBox.FindStringExact(idclienta);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                автомобільTableAdapter.UpdateQuery(marka_comboBox.Text, model_comboBox.Text, dvigun_comboBox.Text, transmisia_comboBox.Text, privod_comboBox.Text,
               color_textBox.Text, (int.Parse(year_textBox.Text)), (int.Parse(idC_comboBox.Text)), id);
            }
            else
            {
                автомобільTableAdapter.InsertQuery(marka_comboBox.Text, model_comboBox.Text, dvigun_comboBox.Text, transmisia_comboBox.Text, privod_comboBox.Text,
               color_textBox.Text, (int.Parse(year_textBox.Text)), (int.Parse(idC_comboBox.Text)));
            }
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Year_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                MessageBox.Show("Введите год выпуска корректно", "Сообщение", MessageBoxButtons.YesNo);
                e.Handled = true;
            }

        }

        private void Color_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'z') && word != '\b' && word != '.')
            {
                MessageBox.Show("Введите цвет автомобиля", "Сообщение", MessageBoxButtons.YesNo);
                e.Handled = true;
            }
        }
    }
}
