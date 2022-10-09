namespace Kursovaia
{
    partial class NotionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_АвтомобіляLabel;
            System.Windows.Forms.Label id_МайстраLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label приміткиLabel;
            System.Windows.Forms.Label цінаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotionForm));
            this.repairShopDataSet = new Kursovaia.RepairShopDataSet();
            this.записTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.ЗаписTableAdapter();
            this.послугаTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.ПослугаTableAdapter();
            this.записBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.записBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.записBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.послугаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.послугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.note_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.автомобільTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.АвтомобільTableAdapter();
            this.автомобільDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобільBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.майстерTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.МайстерTableAdapter();
            this.майстерDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.майстерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Kursovaia.RepairShopDataSetTableAdapters.TableAdapterManager();
            this.записDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запис_ПослугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запис_ПослугаTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.Запис_ПослугаTableAdapter();
            this.послугаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_АвтомобіляTextBox = new System.Windows.Forms.ComboBox();
            this.автомобільBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_МайстраTextBox = new System.Windows.Forms.ComboBox();
            this.майстерBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.приміткиTextBox = new System.Windows.Forms.ComboBox();
            this.послугаBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.послугаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.цінаTextBox = new System.Windows.Forms.ComboBox();
            this.послугаBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.послугаBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.запчастинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастинаTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.ЗапчастинаTableAdapter();
            id_АвтомобіляLabel = new System.Windows.Forms.Label();
            id_МайстраLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            приміткиLabel = new System.Windows.Forms.Label();
            цінаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingNavigator)).BeginInit();
            this.записBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запис_ПослугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастинаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_АвтомобіляLabel
            // 
            id_АвтомобіляLabel.AutoSize = true;
            id_АвтомобіляLabel.Location = new System.Drawing.Point(64, 87);
            id_АвтомобіляLabel.Name = "id_АвтомобіляLabel";
            id_АвтомобіляLabel.Size = new System.Drawing.Size(80, 13);
            id_АвтомобіляLabel.TabIndex = 3;
            id_АвтомобіляLabel.Text = "Id Автомобіля:";
            // 
            // id_МайстраLabel
            // 
            id_МайстраLabel.AutoSize = true;
            id_МайстраLabel.Location = new System.Drawing.Point(64, 113);
            id_МайстраLabel.Name = "id_МайстраLabel";
            id_МайстраLabel.Size = new System.Drawing.Size(66, 13);
            id_МайстраLabel.TabIndex = 5;
            id_МайстраLabel.Text = "Id Майстра:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(64, 140);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 7;
            датаLabel.Text = "Дата:";
            // 
            // приміткиLabel
            // 
            приміткиLabel.AutoSize = true;
            приміткиLabel.Location = new System.Drawing.Point(64, 165);
            приміткиLabel.Name = "приміткиLabel";
            приміткиLabel.Size = new System.Drawing.Size(52, 13);
            приміткиLabel.TabIndex = 9;
            приміткиLabel.Text = "Послуга:";
            // 
            // цінаLabel
            // 
            цінаLabel.AutoSize = true;
            цінаLabel.Location = new System.Drawing.Point(64, 191);
            цінаLabel.Name = "цінаLabel";
            цінаLabel.Size = new System.Drawing.Size(32, 13);
            цінаLabel.TabIndex = 11;
            цінаLabel.Text = "Ціна:";
            // 
            // repairShopDataSet
            // 
            this.repairShopDataSet.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записTableAdapter
            // 
            this.записTableAdapter.ClearBeforeFill = true;
            // 
            // послугаTableAdapter
            // 
            this.послугаTableAdapter.ClearBeforeFill = true;
            // 
            // записBindingNavigator
            // 
            this.записBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.записBindingNavigator.BindingSource = this.записBindingSource;
            this.записBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.записBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.записBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.записBindingNavigatorSaveItem});
            this.записBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.записBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.записBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.записBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.записBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.записBindingNavigator.Name = "записBindingNavigator";
            this.записBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.записBindingNavigator.Size = new System.Drawing.Size(762, 25);
            this.записBindingNavigator.TabIndex = 0;
            this.записBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // записBindingSource
            // 
            this.записBindingSource.DataMember = "Запис";
            this.записBindingSource.DataSource = this.repairShopDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // записBindingNavigatorSaveItem
            // 
            this.записBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.записBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("записBindingNavigatorSaveItem.Image")));
            this.записBindingNavigatorSaveItem.Name = "записBindingNavigatorSaveItem";
            this.записBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.записBindingNavigatorSaveItem.Text = "Save Data";
            this.записBindingNavigatorSaveItem.Click += new System.EventHandler(this.ЗаписBindingNavigatorSaveItem_Click);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.записBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(150, 136);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 8;
            // 
            // послугаDataGridView
            // 
            this.послугаDataGridView.AutoGenerateColumns = false;
            this.послугаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.послугаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.послугаDataGridView.DataSource = this.послугаBindingSource;
            this.послугаDataGridView.Location = new System.Drawing.Point(368, 28);
            this.послугаDataGridView.Name = "послугаDataGridView";
            this.послугаDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.послугаDataGridView.Size = new System.Drawing.Size(343, 99);
            this.послугаDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Послуги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Послуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Назва послуги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва послуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вартість";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вартість";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // послугаBindingSource
            // 
            this.послугаBindingSource.DataMember = "Послуга";
            this.послугаBindingSource.DataSource = this.repairShopDataSet;
            // 
            // note_button
            // 
            this.note_button.Location = new System.Drawing.Point(293, 478);
            this.note_button.Name = "note_button";
            this.note_button.Size = new System.Drawing.Size(75, 23);
            this.note_button.TabIndex = 14;
            this.note_button.Text = "Note";
            this.note_button.UseVisualStyleBackColor = true;
            this.note_button.Click += new System.EventHandler(this.Note_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(391, 478);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // автомобільTableAdapter
            // 
            this.автомобільTableAdapter.ClearBeforeFill = true;
            // 
            // автомобільDataGridView
            // 
            this.автомобільDataGridView.AutoGenerateColumns = false;
            this.автомобільDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.автомобільDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.автомобільDataGridView.DataSource = this.автомобільBindingSource;
            this.автомобільDataGridView.Location = new System.Drawing.Point(368, 131);
            this.автомобільDataGridView.Name = "автомобільDataGridView";
            this.автомобільDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.автомобільDataGridView.Size = new System.Drawing.Size(343, 108);
            this.автомобільDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn5.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Модель";
            this.dataGridViewTextBoxColumn6.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Двигун";
            this.dataGridViewTextBoxColumn7.HeaderText = "Двигун";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Трансмісія";
            this.dataGridViewTextBoxColumn8.HeaderText = "Трансмісія";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Привід";
            this.dataGridViewTextBoxColumn9.HeaderText = "Привід";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Колір";
            this.dataGridViewTextBoxColumn10.HeaderText = "Колір";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Рік випуску";
            this.dataGridViewTextBoxColumn11.HeaderText = "Рік випуску";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Id_Клієнта";
            this.dataGridViewTextBoxColumn12.HeaderText = "Id_Клієнта";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // автомобільBindingSource
            // 
            this.автомобільBindingSource.DataMember = "Автомобіль";
            this.автомобільBindingSource.DataSource = this.repairShopDataSet;
            // 
            // майстерTableAdapter
            // 
            this.майстерTableAdapter.ClearBeforeFill = true;
            // 
            // майстерDataGridView
            // 
            this.майстерDataGridView.AutoGenerateColumns = false;
            this.майстерDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.майстерDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.майстерDataGridView.DataSource = this.майстерBindingSource;
            this.майстерDataGridView.Location = new System.Drawing.Point(368, 244);
            this.майстерDataGridView.Name = "майстерDataGridView";
            this.майстерDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.майстерDataGridView.Size = new System.Drawing.Size(343, 106);
            this.майстерDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id_Майстра";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id_Майстра";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Ім\'я";
            this.dataGridViewTextBoxColumn14.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn15.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // майстерBindingSource
            // 
            this.майстерBindingSource.DataMember = "Майстер";
            this.майстерBindingSource.DataSource = this.repairShopDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Kursovaia.RepairShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобільTableAdapter = null;
            this.tableAdapterManager.Запис_ПослугаTableAdapter = null;
            this.tableAdapterManager.ЗаписTableAdapter = null;
            this.tableAdapterManager.ЗапчастинаTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.МайстерTableAdapter = null;
            this.tableAdapterManager.Послуга_ЗапчастинаTableAdapter = null;
            this.tableAdapterManager.ПослугаTableAdapter = null;
            // 
            // записDataGridView
            // 
            this.записDataGridView.AutoGenerateColumns = false;
            this.записDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.записDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.записDataGridView.DataSource = this.записBindingSource;
            this.записDataGridView.Location = new System.Drawing.Point(63, 355);
            this.записDataGridView.Name = "записDataGridView";
            this.записDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.записDataGridView.Size = new System.Drawing.Size(648, 106);
            this.записDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Id_Майстра";
            this.dataGridViewTextBoxColumn18.HeaderText = "Id_Майстра";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn19.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Примітки";
            this.dataGridViewTextBoxColumn20.HeaderText = "Примітки";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Ціна";
            this.dataGridViewTextBoxColumn21.HeaderText = "Ціна";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // запис_ПослугаBindingSource
            // 
            this.запис_ПослугаBindingSource.DataMember = "FK_Запис_Послуга_Запис";
            this.запис_ПослугаBindingSource.DataSource = this.записBindingSource;
            // 
            // запис_ПослугаTableAdapter
            // 
            this.запис_ПослугаTableAdapter.ClearBeforeFill = true;
            // 
            // послугаBindingSource1
            // 
            this.послугаBindingSource1.DataMember = "Послуга";
            this.послугаBindingSource1.DataSource = this.repairShopDataSet;
            // 
            // id_АвтомобіляTextBox
            // 
            this.id_АвтомобіляTextBox.DataSource = this.автомобільBindingSource1;
            this.id_АвтомобіляTextBox.DisplayMember = "Id_Автомобіля";
            this.id_АвтомобіляTextBox.FormattingEnabled = true;
            this.id_АвтомобіляTextBox.Location = new System.Drawing.Point(150, 83);
            this.id_АвтомобіляTextBox.Name = "id_АвтомобіляTextBox";
            this.id_АвтомобіляTextBox.Size = new System.Drawing.Size(200, 21);
            this.id_АвтомобіляTextBox.TabIndex = 21;
            // 
            // автомобільBindingSource1
            // 
            this.автомобільBindingSource1.DataMember = "Автомобіль";
            this.автомобільBindingSource1.DataSource = this.repairShopDataSet;
            // 
            // id_МайстраTextBox
            // 
            this.id_МайстраTextBox.DataSource = this.майстерBindingSource1;
            this.id_МайстраTextBox.DisplayMember = "Id_Майстра";
            this.id_МайстраTextBox.FormattingEnabled = true;
            this.id_МайстраTextBox.Location = new System.Drawing.Point(150, 110);
            this.id_МайстраTextBox.Name = "id_МайстраTextBox";
            this.id_МайстраTextBox.Size = new System.Drawing.Size(200, 21);
            this.id_МайстраTextBox.TabIndex = 22;
            // 
            // майстерBindingSource1
            // 
            this.майстерBindingSource1.DataMember = "Майстер";
            this.майстерBindingSource1.DataSource = this.repairShopDataSet;
            // 
            // приміткиTextBox
            // 
            this.приміткиTextBox.DataSource = this.послугаBindingSource5;
            this.приміткиTextBox.DisplayMember = "Назва послуги";
            this.приміткиTextBox.FormattingEnabled = true;
            this.приміткиTextBox.Location = new System.Drawing.Point(150, 161);
            this.приміткиTextBox.Name = "приміткиTextBox";
            this.приміткиTextBox.Size = new System.Drawing.Size(200, 21);
            this.приміткиTextBox.TabIndex = 23;
            this.приміткиTextBox.SelectedIndexChanged += new System.EventHandler(this.ПриміткиTextBox_SelectedIndexChanged);
            this.приміткиTextBox.TextChanged += new System.EventHandler(this.ПриміткиTextBox_TextChanged);
            // 
            // послугаBindingSource5
            // 
            this.послугаBindingSource5.DataMember = "Послуга";
            this.послугаBindingSource5.DataSource = this.repairShopDataSet;
            // 
            // послугаBindingSource2
            // 
            this.послугаBindingSource2.DataMember = "Послуга";
            this.послугаBindingSource2.DataSource = this.repairShopDataSet;
            // 
            // цінаTextBox
            // 
            this.цінаTextBox.Enabled = false;
            this.цінаTextBox.FormattingEnabled = true;
            this.цінаTextBox.Location = new System.Drawing.Point(150, 191);
            this.цінаTextBox.Name = "цінаTextBox";
            this.цінаTextBox.Size = new System.Drawing.Size(200, 21);
            this.цінаTextBox.TabIndex = 24;
            // 
            // послугаBindingSource3
            // 
            this.послугаBindingSource3.DataMember = "Послуга";
            this.послугаBindingSource3.DataSource = this.repairShopDataSet;
            // 
            // послугаBindingSource4
            // 
            this.послугаBindingSource4.DataMember = "Послуга";
            this.послугаBindingSource4.DataSource = this.repairShopDataSet;
            // 
            // запчастинаBindingSource
            // 
            this.запчастинаBindingSource.DataMember = "Запчастина";
            this.запчастинаBindingSource.DataSource = this.repairShopDataSet;
            // 
            // запчастинаTableAdapter
            // 
            this.запчастинаTableAdapter.ClearBeforeFill = true;
            // 
            // NotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 521);
            this.Controls.Add(this.цінаTextBox);
            this.Controls.Add(this.приміткиTextBox);
            this.Controls.Add(this.id_МайстраTextBox);
            this.Controls.Add(this.id_АвтомобіляTextBox);
            this.Controls.Add(this.записDataGridView);
            this.Controls.Add(this.майстерDataGridView);
            this.Controls.Add(this.автомобільDataGridView);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.note_button);
            this.Controls.Add(this.послугаDataGridView);
            this.Controls.Add(id_АвтомобіляLabel);
            this.Controls.Add(id_МайстраLabel);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(приміткиLabel);
            this.Controls.Add(цінаLabel);
            this.Controls.Add(this.записBindingNavigator);
            this.Name = "NotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotionForm";
            this.Load += new System.EventHandler(this.NotionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingNavigator)).EndInit();
            this.записBindingNavigator.ResumeLayout(false);
            this.записBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запис_ПослугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.майстерBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послугаBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастинаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepairShopDataSet repairShopDataSet;
        private System.Windows.Forms.BindingSource записBindingSource;
        private RepairShopDataSetTableAdapters.ЗаписTableAdapter записTableAdapter;
        private RepairShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator записBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton записBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private RepairShopDataSetTableAdapters.ПослугаTableAdapter послугаTableAdapter;
        private System.Windows.Forms.BindingSource послугаBindingSource;
        private System.Windows.Forms.DataGridView послугаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button note_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.BindingSource автомобільBindingSource;
        private RepairShopDataSetTableAdapters.АвтомобільTableAdapter автомобільTableAdapter;
        private System.Windows.Forms.DataGridView автомобільDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource майстерBindingSource;
        private RepairShopDataSetTableAdapters.МайстерTableAdapter майстерTableAdapter;
        private System.Windows.Forms.DataGridView майстерDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView записDataGridView;
        private System.Windows.Forms.BindingSource запис_ПослугаBindingSource;
        private RepairShopDataSetTableAdapters.Запис_ПослугаTableAdapter запис_ПослугаTableAdapter;
        private System.Windows.Forms.BindingSource послугаBindingSource1;
        private System.Windows.Forms.ComboBox id_АвтомобіляTextBox;
        private System.Windows.Forms.BindingSource автомобільBindingSource1;
        private System.Windows.Forms.ComboBox id_МайстраTextBox;
        private System.Windows.Forms.BindingSource майстерBindingSource1;
        private System.Windows.Forms.ComboBox приміткиTextBox;
        private System.Windows.Forms.BindingSource послугаBindingSource2;
        private System.Windows.Forms.ComboBox цінаTextBox;
        private System.Windows.Forms.BindingSource послугаBindingSource3;
        private System.Windows.Forms.BindingSource послугаBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.BindingSource послугаBindingSource5;
        private System.Windows.Forms.BindingSource запчастинаBindingSource;
        private RepairShopDataSetTableAdapters.ЗапчастинаTableAdapter запчастинаTableAdapter;
    }
}