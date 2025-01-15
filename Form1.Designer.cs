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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noOfRecordsLbl = new System.Windows.Forms.Label();
            this.removeFiltersBtn = new System.Windows.Forms.Button();
            this.provinceTxt = new System.Windows.Forms.TextBox();
            this.skinColorCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.proffessionCombo = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.peselTxt = new System.Windows.Forms.TextBox();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.peopleDGV = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.showLogFile = new System.Windows.Forms.Button();
            this.exportSelectedBtn = new System.Windows.Forms.Button();
            this.exportProvinceBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDGV)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noOfRecordsLbl);
            this.groupBox1.Controls.Add(this.removeFiltersBtn);
            this.groupBox1.Controls.Add(this.provinceTxt);
            this.groupBox1.Controls.Add(this.skinColorCombo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.proffessionCombo);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.dateToPicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.peselTxt);
            this.groupBox1.Controls.Add(this.dateFromPicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrowanie i wyszukiwanie";
            // 
            // noOfRecordsLbl
            // 
            this.noOfRecordsLbl.AutoSize = true;
            this.noOfRecordsLbl.Location = new System.Drawing.Point(9, 144);
            this.noOfRecordsLbl.Name = "noOfRecordsLbl";
            this.noOfRecordsLbl.Size = new System.Drawing.Size(108, 13);
            this.noOfRecordsLbl.TabIndex = 14;
            this.noOfRecordsLbl.Text = "Ilość rekordów: 0";
            // 
            // removeFiltersBtn
            // 
            this.removeFiltersBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeFiltersBtn.Image")));
            this.removeFiltersBtn.Location = new System.Drawing.Point(584, 23);
            this.removeFiltersBtn.Name = "removeFiltersBtn";
            this.removeFiltersBtn.Size = new System.Drawing.Size(63, 43);
            this.removeFiltersBtn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.removeFiltersBtn, "Usuń filtry");
            this.removeFiltersBtn.UseVisualStyleBackColor = true;
            this.removeFiltersBtn.Click += new System.EventHandler(this.removeFiltersBtn_Click);
            // 
            // provinceTxt
            // 
            this.provinceTxt.Location = new System.Drawing.Point(134, 109);
            this.provinceTxt.Name = "provinceTxt";
            this.provinceTxt.Size = new System.Drawing.Size(152, 21);
            this.provinceTxt.TabIndex = 13;
            this.provinceTxt.TextChanged += new System.EventHandler(this.provinceTxt_TextChanged);
            // 
            // skinColorCombo
            // 
            this.skinColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinColorCombo.FormattingEnabled = true;
            this.skinColorCombo.Location = new System.Drawing.Point(402, 23);
            this.skinColorCombo.Name = "skinColorCombo";
            this.skinColorCombo.Size = new System.Drawing.Size(150, 21);
            this.skinColorCombo.TabIndex = 7;
            this.skinColorCombo.SelectedIndexChanged += new System.EventHandler(this.skinColorCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(9, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Województwo:";
            // 
            // proffessionCombo
            // 
            this.proffessionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proffessionCombo.FormattingEnabled = true;
            this.proffessionCombo.Location = new System.Drawing.Point(134, 23);
            this.proffessionCombo.Name = "proffessionCombo";
            this.proffessionCombo.Size = new System.Drawing.Size(152, 21);
            this.proffessionCombo.TabIndex = 6;
            this.proffessionCombo.SelectedIndexChanged += new System.EventHandler(this.proffessionCombo_SelectedIndexChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(402, 79);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(150, 21);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(402, 52);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(150, 21);
            this.dateToPicker.TabIndex = 5;
            this.dateToPicker.ValueChanged += new System.EventHandler(this.dateToPicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(312, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(312, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do:";
            // 
            // peselTxt
            // 
            this.peselTxt.Location = new System.Drawing.Point(134, 79);
            this.peselTxt.Name = "peselTxt";
            this.peselTxt.Size = new System.Drawing.Size(152, 21);
            this.peselTxt.TabIndex = 9;
            this.peselTxt.TextChanged += new System.EventHandler(this.peselTxt_TextChanged);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(134, 52);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(152, 21);
            this.dateFromPicker.TabIndex = 3;
            this.dateFromPicker.Value = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateFromPicker.ValueChanged += new System.EventHandler(this.dateFromPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pesel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolor skóry:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zawód:";
            // 
            // peopleDGV
            // 
            this.peopleDGV.AllowUserToAddRows = false;
            this.peopleDGV.AllowUserToDeleteRows = false;
            this.peopleDGV.BackgroundColor = System.Drawing.Color.White;
            this.peopleDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.peopleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.peopleDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.peopleDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleDGV.EnableHeadersVisualStyles = false;
            this.peopleDGV.Location = new System.Drawing.Point(5, 244);
            this.peopleDGV.Name = "peopleDGV";
            this.peopleDGV.RowHeadersVisible = false;
            this.peopleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peopleDGV.Size = new System.Drawing.Size(925, 396);
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
            this.buttonsPanel.Location = new System.Drawing.Point(5, 640);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.buttonsPanel.Size = new System.Drawing.Size(925, 52);
            this.buttonsPanel.TabIndex = 10;
            // 
            // showLogFile
            // 
            this.showLogFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.showLogFile.Location = new System.Drawing.Point(823, 3);
            this.showLogFile.Name = "showLogFile";
            this.showLogFile.Size = new System.Drawing.Size(99, 46);
            this.showLogFile.TabIndex = 4;
            this.showLogFile.Text = "Log";
            this.toolTip1.SetToolTip(this.showLogFile, "Otwórz plik logu");
            this.showLogFile.UseVisualStyleBackColor = true;
            this.showLogFile.Click += new System.EventHandler(this.showLogFile_Click);
            // 
            // exportSelectedBtn
            // 
            this.exportSelectedBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportSelectedBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportSelectedBtn.Image")));
            this.exportSelectedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportSelectedBtn.Location = new System.Drawing.Point(412, 3);
            this.exportSelectedBtn.Name = "exportSelectedBtn";
            this.exportSelectedBtn.Size = new System.Drawing.Size(202, 46);
            this.exportSelectedBtn.TabIndex = 3;
            this.exportSelectedBtn.Text = "Eksport wybranych";
            this.toolTip1.SetToolTip(this.exportSelectedBtn, "Eksportuj wybrane \r\nosoby do pliku excel");
            this.exportSelectedBtn.UseVisualStyleBackColor = true;
            this.exportSelectedBtn.Click += new System.EventHandler(this.exportSelectedBtn_Click);
            // 
            // exportProvinceBtn
            // 
            this.exportProvinceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportProvinceBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportProvinceBtn.Image")));
            this.exportProvinceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportProvinceBtn.Location = new System.Drawing.Point(210, 3);
            this.exportProvinceBtn.Name = "exportProvinceBtn";
            this.exportProvinceBtn.Size = new System.Drawing.Size(202, 46);
            this.exportProvinceBtn.TabIndex = 2;
            this.exportProvinceBtn.Text = "Eksport województwo";
            this.toolTip1.SetToolTip(this.exportProvinceBtn, "Eksportuj osoby z \r\nwybranego województwa\r\ndo pliku excel");
            this.exportProvinceBtn.UseVisualStyleBackColor = true;
            this.exportProvinceBtn.Click += new System.EventHandler(this.exportProvinceBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.Location = new System.Drawing.Point(108, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 46);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Usuń";
            this.toolTip1.SetToolTip(this.deleteBtn, "Usuń osobę");
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 46);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Dodaj";
            this.toolTip1.SetToolTip(this.addBtn, "Dodaj osobę");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.label8.Size = new System.Drawing.Size(925, 71);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ludzie Polska App v.1.0.0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 697);
            this.Controls.Add(this.peopleDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonsPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ludzie Polska";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

