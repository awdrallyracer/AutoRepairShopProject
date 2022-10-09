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
    public partial class EditClient : Form
    {
        private readonly int id;
        readonly bool edit;
        public EditClient()
        {
            InitializeComponent();
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            edit = false;
        }

        public EditClient(int id, String name, String mail, String phone, String primitki)
        {
            InitializeComponent();
            клієнтTableAdapter.Fill(repairShopDataSet.Клієнт);
            edit = true;
            this.id = id;
            name_textBox.Text = name;
            mail_textBox.Text = mail;
            phone_textBox.Text = phone;
            primitki_textBox.Text = primitki;
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Клієнт' table. You can move, or remove it, as needed.
            this.клієнтTableAdapter.Fill(this.repairShopDataSet.Клієнт);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                клієнтTableAdapter.UpdateQuery1(name_textBox.Text, mail_textBox.Text, phone_textBox.Text, primitki_textBox.Text, id);
            }
            else
            {
                клієнтTableAdapter.InsertQuery1(name_textBox.Text, mail_textBox.Text, phone_textBox.Text, primitki_textBox.Text);
            }
            Close();
        }

        private void Name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'z') && word != '\b' && word != '.')
            {
                MessageBox.Show("Введите имя корректно", "Сообщение", MessageBoxButtons.YesNo);
                e.Handled = true;
            }
        }

        private void Phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '+')
            {
                MessageBox.Show("Введите номер мобильного корректно", "Сообщение", MessageBoxButtons.YesNo);
                e.Handled = true;
            }
        }

        private void Mail_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'z') && word != '@' && word != '.' && word != 8 && !Char.IsDigit(word))
            {
                MessageBox.Show("Введите электронную почту корректно", "Сообщение", MessageBoxButtons.YesNo);
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
