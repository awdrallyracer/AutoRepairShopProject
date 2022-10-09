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
    public partial class CarsList : Form
    {
        public CarsList()
        {
            InitializeComponent();
        }

        private void АвтомобільBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобільBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairShopDataSet);

        }

        private void CarsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairShopDataSet.Запис' table. You can move, or remove it, as needed.
            this.записTableAdapter.Fill(this.repairShopDataSet.Запис);
            // TODO: This line of code loads data into the 'repairShopDataSet.Автомобіль' table. You can move, or remove it, as needed.
            this.автомобільTableAdapter.Fill(this.repairShopDataSet.Автомобіль);
            // TODO: This line of code loads data into the 'repairShopDataSet.Автомобіль' table. You can move, or remove it, as needed.
            this.автомобільTableAdapter.Fill(this.repairShopDataSet.Автомобіль);

        }

        private void АвтомобільBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобільBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.repairShopDataSet);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                автомобільBindingSource.EndEdit();
                автомобільTableAdapter.Update(repairShopDataSet);
                записTableAdapter.Update(repairShopDataSet);
            }
        }
    }
}
