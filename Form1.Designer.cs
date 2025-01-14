namespace LudziePolska
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeFiltersBtn = new System.Windows.Forms.Button();
            this.skinColorCombo = new System.Windows.Forms.ComboBox();
            this.proffessionCombo = new System.Windows.Forms.ComboBox();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noOfRecordsLbl = new System.Windows.Forms.Label();
            this.provinceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.peselTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.peopleDGV = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.showLogFile = new System.Windows.Forms.Button();
            this.exportSelectedBtn = new System.Windows.Forms.Button();
            this.exportProvinceBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDGV)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeFiltersBtn);
            this.groupBox1.Controls.Add(this.skinColorCombo);
            this.groupBox1.Controls.Add(this.proffessionCombo);
            this.groupBox1.Controls.Add(this.dateToPicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateFromPicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtruj";
            // 
            // removeFiltersBtn
            // 
            this.removeFiltersBtn.Location = new System.Drawing.Point(497, 38);
            this.removeFiltersBtn.Name = "removeFiltersBtn";
            this.removeFiltersBtn.Size = new System.Drawing.Size(63, 43);
            this.removeFiltersBtn.TabIndex = 8;
            this.removeFiltersBtn.Text = "Usuń filtry";
            this.removeFiltersBtn.UseVisualStyleBackColor = true;
            this.removeFiltersBtn.Click += new System.EventHandler(this.removeFiltersBtn_Click);
            // 
            // skinColorCombo
            // 
            this.skinColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinColorCombo.FormattingEnabled = true;
            this.skinColorCombo.Location = new System.Drawing.Point(155, 36);
            this.skinColorCombo.Name = "skinColorCombo";
            this.skinColorCombo.Size = new System.Drawing.Size(178, 21);
            this.skinColorCombo.TabIndex = 7;
            this.skinColorCombo.SelectedIndexChanged += new System.EventHandler(this.skinColorCombo_SelectedIndexChanged);
            // 
            // proffessionCombo
            // 
            this.proffessionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proffessionCombo.FormattingEnabled = true;
            this.proffessionCombo.Location = new System.Drawing.Point(155, 12);
            this.proffessionCombo.Name = "proffessionCombo";
            this.proffessionCombo.Size = new System.Drawing.Size(178, 21);
            this.proffessionCombo.TabIndex = 6;
            this.proffessionCombo.SelectedIndexChanged += new System.EventHandler(this.proffessionCombo_SelectedIndexChanged);
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(350, 60);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(127, 21);
            this.dateToPicker.TabIndex = 5;
            this.dateToPicker.ValueChanged += new System.EventHandler(this.dateToPicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do:";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(155, 60);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(128, 21);
            this.dateFromPicker.TabIndex = 3;
            this.dateFromPicker.Value = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateFromPicker.ValueChanged += new System.EventHandler(this.dateFromPicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolor skóry:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zawód:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noOfRecordsLbl);
            this.groupBox2.Controls.Add(this.provinceTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nameTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.peselTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukaj";
            // 
            // noOfRecordsLbl
            // 
            this.noOfRecordsLbl.AutoSize = true;
            this.noOfRecordsLbl.Location = new System.Drawing.Point(358, 79);
            this.noOfRecordsLbl.Name = "noOfRecordsLbl";
            this.noOfRecordsLbl.Size = new System.Drawing.Size(108, 13);
            this.noOfRecordsLbl.TabIndex = 14;
            this.noOfRecordsLbl.Text = "Ilość rekordów: 0";
            // 
            // provinceTxt
            // 
            this.provinceTxt.Location = new System.Drawing.Point(155, 71);
            this.provinceTxt.Name = "provinceTxt";
            this.provinceTxt.Size = new System.Drawing.Size(178, 21);
            this.provinceTxt.TabIndex = 13;
            this.provinceTxt.TextChanged += new System.EventHandler(this.provinceTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Województwo:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(155, 44);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(178, 21);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nazwisko:";
            // 
            // peselTxt
            // 
            this.peselTxt.Location = new System.Drawing.Point(155, 17);
            this.peselTxt.Name = "peselTxt";
            this.peselTxt.Size = new System.Drawing.Size(178, 21);
            this.peselTxt.TabIndex = 9;
            this.peselTxt.TextChanged += new System.EventHandler(this.peselTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pesel:";
            // 
            // peopleDGV
            // 
            this.peopleDGV.AllowUserToAddRows = false;
            this.peopleDGV.AllowUserToDeleteRows = false;
            this.peopleDGV.BackgroundColor = System.Drawing.Color.White;
            this.peopleDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.peopleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.peopleDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.peopleDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleDGV.EnableHeadersVisualStyles = false;
            this.peopleDGV.Location = new System.Drawing.Point(3, 203);
            this.peopleDGV.Name = "peopleDGV";
            this.peopleDGV.RowHeadersVisible = false;
            this.peopleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peopleDGV.Size = new System.Drawing.Size(929, 439);
            this.peopleDGV.TabIndex = 9;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonsPanel.Controls.Add(this.showLogFile);
            this.buttonsPanel.Controls.Add(this.exportSelectedBtn);
            this.buttonsPanel.Controls.Add(this.exportProvinceBtn);
            this.buttonsPanel.Controls.Add(this.deleteBtn);
            this.buttonsPanel.Controls.Add(this.addBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 642);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.buttonsPanel.Size = new System.Drawing.Size(929, 52);
            this.buttonsPanel.TabIndex = 10;
            // 
            // showLogFile
            // 
            this.showLogFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.showLogFile.Location = new System.Drawing.Point(827, 3);
            this.showLogFile.Name = "showLogFile";
            this.showLogFile.Size = new System.Drawing.Size(99, 46);
            this.showLogFile.TabIndex = 4;
            this.showLogFile.Text = "Log";
            this.showLogFile.UseVisualStyleBackColor = true;
            this.showLogFile.Click += new System.EventHandler(this.showLogFile_Click);
            // 
            // exportSelectedBtn
            // 
            this.exportSelectedBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportSelectedBtn.Location = new System.Drawing.Point(300, 3);
            this.exportSelectedBtn.Name = "exportSelectedBtn";
            this.exportSelectedBtn.Size = new System.Drawing.Size(99, 46);
            this.exportSelectedBtn.TabIndex = 3;
            this.exportSelectedBtn.Text = "Eksport wybranych";
            this.exportSelectedBtn.UseVisualStyleBackColor = true;
            this.exportSelectedBtn.Click += new System.EventHandler(this.exportSelectedBtn_Click);
            // 
            // exportProvinceBtn
            // 
            this.exportProvinceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportProvinceBtn.Location = new System.Drawing.Point(201, 3);
            this.exportProvinceBtn.Name = "exportProvinceBtn";
            this.exportProvinceBtn.Size = new System.Drawing.Size(99, 46);
            this.exportProvinceBtn.TabIndex = 2;
            this.exportProvinceBtn.Text = "Eksport województwo";
            this.exportProvinceBtn.UseVisualStyleBackColor = true;
            this.exportProvinceBtn.Click += new System.EventHandler(this.exportProvinceBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.Location = new System.Drawing.Point(102, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 46);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Usuń";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 46);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 697);
            this.Controls.Add(this.peopleDGV);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ludzie Polska";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDGV)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox skinColorCombo;
        private System.Windows.Forms.ComboBox proffessionCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox provinceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox peselTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView peopleDGV;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button exportSelectedBtn;
        private System.Windows.Forms.Button exportProvinceBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label noOfRecordsLbl;
        private System.Windows.Forms.Button removeFiltersBtn;
        private System.Windows.Forms.Button showLogFile;
    }
}

