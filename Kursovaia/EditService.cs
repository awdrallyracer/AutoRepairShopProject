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
    public partial class EditService : Form
    {
        private readonly int id;
        readonly bool edit;
        public EditService()
        {
            InitializeComponent();
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
            edit = false;
        }

        public EditService(int id, String name, int cost)
        {
            InitializeComponent();
            послугаTableAdapter.Fill(repairShopDataSet.Послуга);
            edit = true;
            this.id = id;
            name_comboBox.Text = name;
            cost_textBox.Text = cost.ToString();
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Послуга' table. You can move, or remove it, as needed.
            this.послугаTableAdapter.Fill(this.repairShopDataSet.Послуга);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                послугаTableAdapter.UpdateQuery2(name_comboBox.Text, (int.Parse(cost_textBox.Text)), id);
            }
            else
            {
                послугаTableAdapter.InsertQuery2(name_comboBox.Text, (int.Parse(cost_textBox.Text)));
            }
            Close();
        }
    }
}
