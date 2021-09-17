namespace BD_v1
{
    partial class InsertStudent
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SexName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonStudent = new MetroFramework.Controls.MetroButton();
            this.UpButtonStudent = new MetroFramework.Controls.MetroButton();
            this.InsertButtonStudent = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.StudentName = new MetroFramework.Controls.MetroTextBox();
            this.PresentName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PhoneName = new MetroFramework.Controls.MetroTextBox();
            this.AddressName = new MetroFramework.Controls.MetroTextBox();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(109, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Пол";
            // 
            // SexName
            // 
            this.SexName.FormattingEnabled = true;
            this.SexName.ItemHeight = 24;
            this.SexName.Location = new System.Drawing.Point(245, 116);
            this.SexName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SexName.Name = "SexName";
            this.SexName.Size = new System.Drawing.Size(455, 30);
            this.SexName.TabIndex = 26;
            // 
            // DeletButtonStudent
            // 
            this.DeletButtonStudent.Location = new System.Drawing.Point(500, 374);
            this.DeletButtonStudent.Name = "DeletButtonStudent";
            this.DeletButtonStudent.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonStudent.TabIndex = 25;
            this.DeletButtonStudent.Text = "Удалить";
            this.DeletButtonStudent.Visible = false;
            this.DeletButtonStudent.Click += new System.EventHandler(this.DeletButtonStudent_Click);
            // 
            // UpButtonStudent
            // 
            this.UpButtonStudent.Location = new System.Drawing.Point(178, 374);
            this.UpButtonStudent.Name = "UpButtonStudent";
            this.UpButtonStudent.Size = new System.Drawing.Size(155, 53);
            this.UpButtonStudent.TabIndex = 24;
            this.UpButtonStudent.Text = "Изменить";
            this.UpButtonStudent.Visible = false;
            this.UpButtonStudent.Click += new System.EventHandler(this.UpButtonStudent_Click);
            // 
            // InsertButtonStudent
            // 
            this.InsertButtonStudent.Location = new System.Drawing.Point(339, 374);
            this.InsertButtonStudent.Name = "InsertButtonStudent";
            this.InsertButtonStudent.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonStudent.TabIndex = 23;
            this.InsertButtonStudent.Text = "Добавить";
            this.InsertButtonStudent.Visible = false;
            this.InsertButtonStudent.Click += new System.EventHandler(this.InsertButtonStudent_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(109, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "ФИО";
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(245, 71);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(455, 23);
            this.StudentName.TabIndex = 21;
            // 
            // PresentName
            // 
            this.PresentName.FormattingEnabled = true;
            this.PresentName.ItemHeight = 24;
            this.PresentName.Location = new System.Drawing.Point(245, 159);
            this.PresentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PresentName.Name = "PresentName";
            this.PresentName.Size = new System.Drawing.Size(455, 30);
            this.PresentName.TabIndex = 28;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(109, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Есть дети";
            // 
            // PhoneName
            // 
            this.PhoneName.Location = new System.Drawing.Point(245, 206);
            this.PhoneName.Name = "PhoneName";
            this.PhoneName.Size = new System.Drawing.Size(455, 23);
            this.PhoneName.TabIndex = 30;
            // 
            // AddressName
            // 
            this.AddressName.Location = new System.Drawing.Point(245, 247);
            this.AddressName.Name = "AddressName";
            this.AddressName.Size = new System.Drawing.Size(455, 23);
            this.AddressName.TabIndex = 31;
            // 
            // DateB
            // 
            this.DateB.CustomFormat = "yyyy-MM-dd";
            this.DateB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateB.Location = new System.Drawing.Point(245, 294);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(200, 22);
            this.DateB.TabIndex = 33;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(109, 209);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 20);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Телефон";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(109, 250);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 20);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Адрес";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(109, 296);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 20);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Дата рождения";
            // 
            // InsertStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.AddressName);
            this.Controls.Add(this.PhoneName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.PresentName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SexName);
            this.Controls.Add(this.DeletButtonStudent);
            this.Controls.Add(this.UpButtonStudent);
            this.Controls.Add(this.InsertButtonStudent);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.StudentName);
            this.Name = "InsertStudent";
            this.Text = "Таблица студентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox SexName;
        private MetroFramework.Controls.MetroButton DeletButtonStudent;
        private MetroFramework.Controls.MetroButton UpButtonStudent;
        private MetroFramework.Controls.MetroButton InsertButtonStudent;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox StudentName;
        private MetroFramework.Controls.MetroComboBox PresentName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox PhoneName;
        private MetroFramework.Controls.MetroTextBox AddressName;
        private System.Windows.Forms.DateTimePicker DateB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}