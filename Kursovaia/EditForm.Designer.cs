namespace Kursovaia
{
    partial class EditForm
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
            this.ida_textBox = new System.Windows.Forms.TextBox();
            this.marka_comboBox = new System.Windows.Forms.ComboBox();
            this.model_comboBox = new System.Windows.Forms.ComboBox();
            this.dvigun_comboBox = new System.Windows.Forms.ComboBox();
            this.transmisia_comboBox = new System.Windows.Forms.ComboBox();
            this.privod_comboBox = new System.Windows.Forms.ComboBox();
            this.color_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.ida_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.dvigun_label = new System.Windows.Forms.Label();
            this.transmisia_label = new System.Windows.Forms.Label();
            this.privod_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.idC_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repairShopDataSet = new Kursovaia.RepairShopDataSet();
            this.автомобільTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.АвтомобільTableAdapter();
            this.idC_comboBox = new System.Windows.Forms.ComboBox();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клієнтTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.КлієнтTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ida_textBox
            // 
            this.ida_textBox.Enabled = false;
            this.ida_textBox.Location = new System.Drawing.Point(123, 40);
            this.ida_textBox.Name = "ida_textBox";
            this.ida_textBox.Size = new System.Drawing.Size(100, 20);
            this.ida_textBox.TabIndex = 0;
            // 
            // marka_comboBox
            // 
            this.marka_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marka_comboBox.FormattingEnabled = true;
            this.marka_comboBox.Items.AddRange(new object[] {
            "Subaru",
            "Nissan",
            "Toyota",
            "BMW",
            "Volkswagen"});
            this.marka_comboBox.Location = new System.Drawing.Point(123, 67);
            this.marka_comboBox.Name = "marka_comboBox";
            this.marka_comboBox.Size = new System.Drawing.Size(121, 21);
            this.marka_comboBox.TabIndex = 1;
            this.marka_comboBox.TextChanged += new System.EventHandler(this.Marka_comboBox_TextChanged);
            // 
            // model_comboBox
            // 
            this.model_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_comboBox.FormattingEnabled = true;
            this.model_comboBox.Items.AddRange(new object[] {
            "M3"});
            this.model_comboBox.Location = new System.Drawing.Point(123, 95);
            this.model_comboBox.Name = "model_comboBox";
            this.model_comboBox.Size = new System.Drawing.Size(121, 21);
            this.model_comboBox.TabIndex = 2;
            // 
            // dvigun_comboBox
            // 
            this.dvigun_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dvigun_comboBox.FormattingEnabled = true;
            this.dvigun_comboBox.Items.AddRange(new object[] {
            "1.4",
            "1.5",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "2.5",
            "2.8",
            "3.0",
            "3.5",
            "3.6"});
            this.dvigun_comboBox.Location = new System.Drawing.Point(123, 123);
            this.dvigun_comboBox.Name = "dvigun_comboBox";
            this.dvigun_comboBox.Size = new System.Drawing.Size(121, 21);
            this.dvigun_comboBox.TabIndex = 3;
            // 
            // transmisia_comboBox
            // 
            this.transmisia_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmisia_comboBox.FormattingEnabled = true;
            this.transmisia_comboBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.transmisia_comboBox.Location = new System.Drawing.Point(123, 151);
            this.transmisia_comboBox.Name = "transmisia_comboBox";
            this.transmisia_comboBox.Size = new System.Drawing.Size(121, 21);
            this.transmisia_comboBox.TabIndex = 4;
            // 
            // privod_comboBox
            // 
            this.privod_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privod_comboBox.FormattingEnabled = true;
            this.privod_comboBox.Items.AddRange(new object[] {
            "FWD",
            "RWD",
            "AWD"});
            this.privod_comboBox.Location = new System.Drawing.Point(123, 179);
            this.privod_comboBox.Name = "privod_comboBox";
            this.privod_comboBox.Size = new System.Drawing.Size(121, 21);
            this.privod_comboBox.TabIndex = 5;
            // 
            // color_textBox
            // 
            this.color_textBox.Location = new System.Drawing.Point(123, 206);
            this.color_textBox.Name = "color_textBox";
            this.color_textBox.Size = new System.Drawing.Size(100, 20);
            this.color_textBox.TabIndex = 6;
            this.color_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Color_textBox_KeyPress);
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(123, 232);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(100, 20);
            this.year_textBox.TabIndex = 7;
            this.year_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_textBox_KeyPress);
            // 
            // ida_label
            // 
            this.ida_label.AutoSize = true;
            this.ida_label.Location = new System.Drawing.Point(22, 40);
            this.ida_label.Name = "ida_label";
            this.ida_label.Size = new System.Drawing.Size(79, 13);
            this.ida_label.TabIndex = 8;
            this.ida_label.Text = "id_Автомобіля";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Location = new System.Drawing.Point(22, 70);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(40, 13);
            this.marka_label.TabIndex = 9;
            this.marka_label.Text = "Марка";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(22, 103);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(46, 13);
            this.model_label.TabIndex = 10;
            this.model_label.Text = "Модель";
            // 
            // dvigun_label
            // 
            this.dvigun_label.AutoSize = true;
            this.dvigun_label.Location = new System.Drawing.Point(22, 131);
            this.dvigun_label.Name = "dvigun_label";
            this.dvigun_label.Size = new System.Drawing.Size(44, 13);
            this.dvigun_label.TabIndex = 11;
            this.dvigun_label.Text = "Двигун";
            // 
            // transmisia_label
            // 
            this.transmisia_label.AutoSize = true;
            this.transmisia_label.Location = new System.Drawing.Point(22, 159);
            this.transmisia_label.Name = "transmisia_label";
            this.transmisia_label.Size = new System.Drawing.Size(62, 13);
            this.transmisia_label.TabIndex = 12;
            this.transmisia_label.Text = "Трансмісія";
            // 
            // privod_label
            // 
            this.privod_label.AutoSize = true;
            this.privod_label.Location = new System.Drawing.Point(22, 187);
            this.privod_label.Name = "privod_label";
            this.privod_label.Size = new System.Drawing.Size(41, 13);
            this.privod_label.TabIndex = 13;
            this.privod_label.Text = "Привід";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(22, 213);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(34, 13);
            this.color_label.TabIndex = 14;
            this.color_label.Text = "Колір";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(22, 239);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(65, 13);
            this.year_label.TabIndex = 15;
            this.year_label.Text = "Рік випуску";
            // 
            // idC_label
            // 
            this.idC_label.AutoSize = true;
            this.idC_label.Location = new System.Drawing.Point(22, 265);
            this.idC_label.Name = "idC_label";
            this.idC_label.Size = new System.Drawing.Size(59, 13);
            this.idC_label.TabIndex = 17;
            this.idC_label.Text = "id_Клієнта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Автомобіль";
            this.bindingSource1.DataSource = this.repairShopDataSet;
            // 
            // repairShopDataSet
            // 
            this.repairShopDataSet.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобільTableAdapter
            // 
            this.автомобільTableAdapter.ClearBeforeFill = true;
            // 
            // idC_comboBox
            // 
            this.idC_comboBox.DataSource = this.клієнтBindingSource;
            this.idC_comboBox.DisplayMember = "Id_Клієнта";
            this.idC_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idC_comboBox.FormattingEnabled = true;
            this.idC_comboBox.Location = new System.Drawing.Point(123, 265);
            this.idC_comboBox.Name = "idC_comboBox";
            this.idC_comboBox.Size = new System.Drawing.Size(121, 21);
            this.idC_comboBox.TabIndex = 20;
            // 
            // клієнтBindingSource
            // 
            this.клієнтBindingSource.DataMember = "Клієнт";
            this.клієнтBindingSource.DataSource = this.repairShopDataSet;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 362);
            this.Controls.Add(this.idC_comboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idC_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.privod_label);
            this.Controls.Add(this.transmisia_label);
            this.Controls.Add(this.dvigun_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.ida_label);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.color_textBox);
            this.Controls.Add(this.privod_comboBox);
            this.Controls.Add(this.transmisia_comboBox);
            this.Controls.Add(this.dvigun_comboBox);
            this.Controls.Add(this.model_comboBox);
            this.Controls.Add(this.marka_comboBox);
            this.Controls.Add(this.ida_textBox);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ida_textBox;
        private System.Windows.Forms.ComboBox marka_comboBox;
        private System.Windows.Forms.ComboBox model_comboBox;
        private System.Windows.Forms.ComboBox dvigun_comboBox;
        private System.Windows.Forms.ComboBox transmisia_comboBox;
        private System.Windows.Forms.ComboBox privod_comboBox;
        private System.Windows.Forms.TextBox color_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.Label ida_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label dvigun_label;
        private System.Windows.Forms.Label transmisia_label;
        private System.Windows.Forms.Label privod_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label idC_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RepairShopDataSet repairShopDataSet;
        private RepairShopDataSetTableAdapters.АвтомобільTableAdapter автомобільTableAdapter;
        private System.Windows.Forms.ComboBox idC_comboBox;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private RepairShopDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
    }
}