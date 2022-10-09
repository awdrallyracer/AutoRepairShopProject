namespace Kursovaia
{
    partial class CarsList
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
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label двигунLabel;
            System.Windows.Forms.Label трансмісіяLabel;
            System.Windows.Forms.Label привідLabel;
            System.Windows.Forms.Label колірLabel;
            System.Windows.Forms.Label рік_випускуLabel;
            System.Windows.Forms.Label id_КлієнтаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsList));
            this.repairShopDataSet = new Kursovaia.RepairShopDataSet();
            this.автомобільBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобільTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.АвтомобільTableAdapter();
            this.tableAdapterManager = new Kursovaia.RepairShopDataSetTableAdapters.TableAdapterManager();
            this.записTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.ЗаписTableAdapter();
            this.автомобільBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.автомобільBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_АвтомобіляTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.двигунTextBox = new System.Windows.Forms.TextBox();
            this.трансмісіяTextBox = new System.Windows.Forms.TextBox();
            this.привідTextBox = new System.Windows.Forms.TextBox();
            this.колірTextBox = new System.Windows.Forms.TextBox();
            this.рік_випускуTextBox = new System.Windows.Forms.TextBox();
            this.id_КлієнтаTextBox = new System.Windows.Forms.TextBox();
            this.записBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.записDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            id_АвтомобіляLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            двигунLabel = new System.Windows.Forms.Label();
            трансмісіяLabel = new System.Windows.Forms.Label();
            привідLabel = new System.Windows.Forms.Label();
            колірLabel = new System.Windows.Forms.Label();
            рік_випускуLabel = new System.Windows.Forms.Label();
            id_КлієнтаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingNavigator)).BeginInit();
            this.автомобільBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_АвтомобіляLabel
            // 
            id_АвтомобіляLabel.AutoSize = true;
            id_АвтомобіляLabel.Location = new System.Drawing.Point(32, 36);
            id_АвтомобіляLabel.Name = "id_АвтомобіляLabel";
            id_АвтомобіляLabel.Size = new System.Drawing.Size(80, 13);
            id_АвтомобіляLabel.TabIndex = 1;
            id_АвтомобіляLabel.Text = "Id Автомобіля:";
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(32, 62);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(43, 13);
            маркаLabel.TabIndex = 3;
            маркаLabel.Text = "Марка:";
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(32, 88);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(49, 13);
            модельLabel.TabIndex = 5;
            модельLabel.Text = "Модель:";
            // 
            // двигунLabel
            // 
            двигунLabel.AutoSize = true;
            двигунLabel.Location = new System.Drawing.Point(32, 114);
            двигунLabel.Name = "двигунLabel";
            двигунLabel.Size = new System.Drawing.Size(47, 13);
            двигунLabel.TabIndex = 7;
            двигунLabel.Text = "Двигун:";
            // 
            // трансмісіяLabel
            // 
            трансмісіяLabel.AutoSize = true;
            трансмісіяLabel.Location = new System.Drawing.Point(32, 140);
            трансмісіяLabel.Name = "трансмісіяLabel";
            трансмісіяLabel.Size = new System.Drawing.Size(65, 13);
            трансмісіяLabel.TabIndex = 9;
            трансмісіяLabel.Text = "Трансмісія:";
            // 
            // привідLabel
            // 
            привідLabel.AutoSize = true;
            привідLabel.Location = new System.Drawing.Point(32, 166);
            привідLabel.Name = "привідLabel";
            привідLabel.Size = new System.Drawing.Size(44, 13);
            привідLabel.TabIndex = 11;
            привідLabel.Text = "Привід:";
            // 
            // колірLabel
            // 
            колірLabel.AutoSize = true;
            колірLabel.Location = new System.Drawing.Point(32, 192);
            колірLabel.Name = "колірLabel";
            колірLabel.Size = new System.Drawing.Size(37, 13);
            колірLabel.TabIndex = 13;
            колірLabel.Text = "Колір:";
            // 
            // рік_випускуLabel
            // 
            рік_випускуLabel.AutoSize = true;
            рік_випускуLabel.Location = new System.Drawing.Point(32, 218);
            рік_випускуLabel.Name = "рік_випускуLabel";
            рік_випускуLabel.Size = new System.Drawing.Size(68, 13);
            рік_випускуLabel.TabIndex = 15;
            рік_випускуLabel.Text = "Рік випуску:";
            // 
            // id_КлієнтаLabel
            // 
            id_КлієнтаLabel.AutoSize = true;
            id_КлієнтаLabel.Location = new System.Drawing.Point(32, 244);
            id_КлієнтаLabel.Name = "id_КлієнтаLabel";
            id_КлієнтаLabel.Size = new System.Drawing.Size(60, 13);
            id_КлієнтаLabel.TabIndex = 17;
            id_КлієнтаLabel.Text = "Id Клієнта:";
            // 
            // repairShopDataSet
            // 
            this.repairShopDataSet.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобільBindingSource
            // 
            this.автомобільBindingSource.DataMember = "Автомобіль";
            this.автомобільBindingSource.DataSource = this.repairShopDataSet;
            // 
            // автомобільTableAdapter
            // 
            this.автомобільTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursovaia.RepairShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобільTableAdapter = this.автомобільTableAdapter;
            this.tableAdapterManager.Запис_ПослугаTableAdapter = null;
            this.tableAdapterManager.ЗаписTableAdapter = this.записTableAdapter;
            this.tableAdapterManager.ЗапчастинаTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.МайстерTableAdapter = null;
            this.tableAdapterManager.Послуга_ЗапчастинаTableAdapter = null;
            this.tableAdapterManager.ПослугаTableAdapter = null;
            // 
            // записTableAdapter
            // 
            this.записTableAdapter.ClearBeforeFill = true;
            // 
            // автомобільBindingNavigator
            // 
            this.автомобільBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автомобільBindingNavigator.BindingSource = this.автомобільBindingSource;
            this.автомобільBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автомобільBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автомобільBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автомобільBindingNavigatorSaveItem});
            this.автомобільBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автомобільBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автомобільBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автомобільBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автомобільBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автомобільBindingNavigator.Name = "автомобільBindingNavigator";
            this.автомобільBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автомобільBindingNavigator.Size = new System.Drawing.Size(694, 25);
            this.автомобільBindingNavigator.TabIndex = 0;
            this.автомобільBindingNavigator.Text = "bindingNavigator1";
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
            // автомобільBindingNavigatorSaveItem
            // 
            this.автомобільBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автомобільBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автомобільBindingNavigatorSaveItem.Image")));
            this.автомобільBindingNavigatorSaveItem.Name = "автомобільBindingNavigatorSaveItem";
            this.автомобільBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.автомобільBindingNavigatorSaveItem.Text = "Save Data";
            this.автомобільBindingNavigatorSaveItem.Click += new System.EventHandler(this.АвтомобільBindingNavigatorSaveItem_Click_1);
            // 
            // id_АвтомобіляTextBox
            // 
            this.id_АвтомобіляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Id_Автомобіля", true));
            this.id_АвтомобіляTextBox.Location = new System.Drawing.Point(118, 33);
            this.id_АвтомобіляTextBox.Name = "id_АвтомобіляTextBox";
            this.id_АвтомобіляTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_АвтомобіляTextBox.TabIndex = 2;
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(118, 59);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 20);
            this.маркаTextBox.TabIndex = 4;
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(118, 85);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(100, 20);
            this.модельTextBox.TabIndex = 6;
            // 
            // двигунTextBox
            // 
            this.двигунTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Двигун", true));
            this.двигунTextBox.Location = new System.Drawing.Point(118, 111);
            this.двигунTextBox.Name = "двигунTextBox";
            this.двигунTextBox.Size = new System.Drawing.Size(100, 20);
            this.двигунTextBox.TabIndex = 8;
            // 
            // трансмісіяTextBox
            // 
            this.трансмісіяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Трансмісія", true));
            this.трансмісіяTextBox.Location = new System.Drawing.Point(118, 137);
            this.трансмісіяTextBox.Name = "трансмісіяTextBox";
            this.трансмісіяTextBox.Size = new System.Drawing.Size(100, 20);
            this.трансмісіяTextBox.TabIndex = 10;
            // 
            // привідTextBox
            // 
            this.привідTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Привід", true));
            this.привідTextBox.Location = new System.Drawing.Point(118, 163);
            this.привідTextBox.Name = "привідTextBox";
            this.привідTextBox.Size = new System.Drawing.Size(100, 20);
            this.привідTextBox.TabIndex = 12;
            // 
            // колірTextBox
            // 
            this.колірTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Колір", true));
            this.колірTextBox.Location = new System.Drawing.Point(118, 189);
            this.колірTextBox.Name = "колірTextBox";
            this.колірTextBox.Size = new System.Drawing.Size(100, 20);
            this.колірTextBox.TabIndex = 14;
            // 
            // рік_випускуTextBox
            // 
            this.рік_випускуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Рік випуску", true));
            this.рік_випускуTextBox.Location = new System.Drawing.Point(118, 215);
            this.рік_випускуTextBox.Name = "рік_випускуTextBox";
            this.рік_випускуTextBox.Size = new System.Drawing.Size(100, 20);
            this.рік_випускуTextBox.TabIndex = 16;
            // 
            // id_КлієнтаTextBox
            // 
            this.id_КлієнтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобільBindingSource, "Id_Клієнта", true));
            this.id_КлієнтаTextBox.Location = new System.Drawing.Point(118, 241);
            this.id_КлієнтаTextBox.Name = "id_КлієнтаTextBox";
            this.id_КлієнтаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_КлієнтаTextBox.TabIndex = 18;
            // 
            // записBindingSource
            // 
            this.записBindingSource.DataMember = "FK_Запис_Автомобіль";
            this.записBindingSource.DataSource = this.автомобільBindingSource;
            // 
            // записDataGridView
            // 
            this.записDataGridView.AutoGenerateColumns = false;
            this.записDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.записDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.записDataGridView.DataSource = this.записBindingSource;
            this.записDataGridView.Location = new System.Drawing.Point(35, 267);
            this.записDataGridView.Name = "записDataGridView";
            this.записDataGridView.Size = new System.Drawing.Size(646, 196);
            this.записDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Запису";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Запису";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Автомобіля";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Майстра";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Майстра";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Примітки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Примітки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ціна";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ціна";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.записDataGridView);
            this.Controls.Add(id_АвтомобіляLabel);
            this.Controls.Add(this.id_АвтомобіляTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(двигунLabel);
            this.Controls.Add(this.двигунTextBox);
            this.Controls.Add(трансмісіяLabel);
            this.Controls.Add(this.трансмісіяTextBox);
            this.Controls.Add(привідLabel);
            this.Controls.Add(this.привідTextBox);
            this.Controls.Add(колірLabel);
            this.Controls.Add(this.колірTextBox);
            this.Controls.Add(рік_випускуLabel);
            this.Controls.Add(this.рік_випускуTextBox);
            this.Controls.Add(id_КлієнтаLabel);
            this.Controls.Add(this.id_КлієнтаTextBox);
            this.Controls.Add(this.автомобільBindingNavigator);
            this.Name = "CarsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsList";
            this.Load += new System.EventHandler(this.CarsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingNavigator)).EndInit();
            this.автомобільBindingNavigator.ResumeLayout(false);
            this.автомобільBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepairShopDataSet repairShopDataSet;
        private System.Windows.Forms.BindingSource автомобільBindingSource;
        private RepairShopDataSetTableAdapters.АвтомобільTableAdapter автомобільTableAdapter;
        private RepairShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автомобільBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автомобільBindingNavigatorSaveItem;
        private RepairShopDataSetTableAdapters.ЗаписTableAdapter записTableAdapter;
        private System.Windows.Forms.TextBox id_АвтомобіляTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox двигунTextBox;
        private System.Windows.Forms.TextBox трансмісіяTextBox;
        private System.Windows.Forms.TextBox привідTextBox;
        private System.Windows.Forms.TextBox колірTextBox;
        private System.Windows.Forms.TextBox рік_випускуTextBox;
        private System.Windows.Forms.TextBox id_КлієнтаTextBox;
        private System.Windows.Forms.BindingSource записBindingSource;
        private System.Windows.Forms.DataGridView записDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}