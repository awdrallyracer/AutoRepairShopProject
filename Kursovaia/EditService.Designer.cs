namespace Kursovaia
{
    partial class EditService
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repairShopDataSet = new Kursovaia.RepairShopDataSet();
            this.послугаTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.ПослугаTableAdapter();
            this.послугаTableAdapter1 = new Kursovaia.RepairShopDataSetTableAdapters.ПослугаTableAdapter();
            this.repairShopDataSet1 = new Kursovaia.RepairShopDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idp_textBox = new System.Windows.Forms.TextBox();
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.cost_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Послуга";
            this.bindingSource1.DataSource = this.repairShopDataSet;
            // 
            // repairShopDataSet
            // 
            this.repairShopDataSet.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // послугаTableAdapter
            // 
            this.послугаTableAdapter.ClearBeforeFill = true;
            // 
            // послугаTableAdapter1
            // 
            this.послугаTableAdapter1.ClearBeforeFill = true;
            // 
            // repairShopDataSet1
            // 
            this.repairShopDataSet1.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва послуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вартість";
            // 
            // idp_textBox
            // 
            this.idp_textBox.Location = new System.Drawing.Point(103, 31);
            this.idp_textBox.Name = "idp_textBox";
            this.idp_textBox.Size = new System.Drawing.Size(121, 20);
            this.idp_textBox.TabIndex = 3;
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(103, 62);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(121, 21);
            this.name_comboBox.TabIndex = 4;
            // 
            // cost_textBox
            // 
            this.cost_textBox.Location = new System.Drawing.Point(103, 90);
            this.cost_textBox.Name = "cost_textBox";
            this.cost_textBox.Size = new System.Drawing.Size(121, 20);
            this.cost_textBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cost_textBox);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.idp_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditService";
            this.Load += new System.EventHandler(this.EditService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private RepairShopDataSet repairShopDataSet;
        private RepairShopDataSetTableAdapters.ПослугаTableAdapter послугаTableAdapter;
        private RepairShopDataSetTableAdapters.ПослугаTableAdapter послугаTableAdapter1;
        private RepairShopDataSet repairShopDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idp_textBox;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.TextBox cost_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}