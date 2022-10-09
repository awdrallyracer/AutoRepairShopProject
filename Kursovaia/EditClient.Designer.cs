namespace Kursovaia
{
    partial class EditClient
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
            this.клієнтTableAdapter = new Kursovaia.RepairShopDataSetTableAdapters.КлієнтTableAdapter();
            this.repairShopDataSet1 = new Kursovaia.RepairShopDataSet();
            this.клієнтTableAdapter1 = new Kursovaia.RepairShopDataSetTableAdapters.КлієнтTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.primitki_textBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Клієнт";
            this.bindingSource1.DataSource = this.repairShopDataSet;
            // 
            // repairShopDataSet
            // 
            this.repairShopDataSet.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // repairShopDataSet1
            // 
            this.repairShopDataSet1.DataSetName = "RepairShopDataSet";
            this.repairShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клієнтTableAdapter1
            // 
            this.клієнтTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(133, 72);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textBox_KeyPress);
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(133, 98);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(100, 20);
            this.mail_textBox.TabIndex = 2;
            this.mail_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mail_textBox_KeyPress);
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(133, 124);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(100, 20);
            this.phone_textBox.TabIndex = 3;
            this.phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_textBox_KeyPress);
            // 
            // primitki_textBox
            // 
            this.primitki_textBox.Location = new System.Drawing.Point(133, 150);
            this.primitki_textBox.Name = "primitki_textBox";
            this.primitki_textBox.Size = new System.Drawing.Size(100, 20);
            this.primitki_textBox.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(79, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 6;
            this.name.Text = "Name";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(79, 105);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(26, 13);
            this.mail.TabIndex = 7;
            this.mail.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id_clienta";
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.name);
            this.Controls.Add(this.primitki_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.textBox1);
            this.Name = "EditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.EditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private RepairShopDataSet repairShopDataSet;
        private RepairShopDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private RepairShopDataSet repairShopDataSet1;
        private RepairShopDataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox primitki_textBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}