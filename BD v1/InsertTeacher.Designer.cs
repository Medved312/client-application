namespace BD_v1
{
    partial class InsertTeacher
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.DissertationName = new MetroFramework.Controls.MetroTextBox();
            this.CandidanscaiName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PresentName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SexName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.UpButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.InsertButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TeacherName = new MetroFramework.Controls.MetroTextBox();
            this.CategoryName = new MetroFramework.Controls.MetroComboBox();
            this.DepartmentName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(96, 386);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 20);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "Дата рождения";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(96, 340);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 20);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Докторская";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(96, 299);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 20);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "Кандидатская";
            // 
            // DateB
            // 
            this.DateB.CustomFormat = "yyyy-MM-dd";
            this.DateB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateB.Location = new System.Drawing.Point(257, 384);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(200, 22);
            this.DateB.TabIndex = 48;
            // 
            // DissertationName
            // 
            this.DissertationName.Location = new System.Drawing.Point(257, 337);
            this.DissertationName.Name = "DissertationName";
            this.DissertationName.Size = new System.Drawing.Size(455, 23);
            this.DissertationName.TabIndex = 47;
            // 
            // CandidanscaiName
            // 
            this.CandidanscaiName.Location = new System.Drawing.Point(257, 296);
            this.CandidanscaiName.Name = "CandidanscaiName";
            this.CandidanscaiName.Size = new System.Drawing.Size(455, 23);
            this.CandidanscaiName.TabIndex = 46;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(96, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 20);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Количество детей";
            // 
            // PresentName
            // 
            this.PresentName.FormattingEnabled = true;
            this.PresentName.ItemHeight = 24;
            this.PresentName.Location = new System.Drawing.Point(257, 151);
            this.PresentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PresentName.Name = "PresentName";
            this.PresentName.Size = new System.Drawing.Size(455, 30);
            this.PresentName.TabIndex = 44;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(96, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Пол";
            // 
            // SexName
            // 
            this.SexName.FormattingEnabled = true;
            this.SexName.ItemHeight = 24;
            this.SexName.Location = new System.Drawing.Point(257, 108);
            this.SexName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SexName.Name = "SexName";
            this.SexName.Size = new System.Drawing.Size(455, 30);
            this.SexName.TabIndex = 42;
            // 
            // DeletButtonTeacher
            // 
            this.DeletButtonTeacher.Location = new System.Drawing.Point(529, 452);
            this.DeletButtonTeacher.Name = "DeletButtonTeacher";
            this.DeletButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonTeacher.TabIndex = 41;
            this.DeletButtonTeacher.Text = "Удалить";
            this.DeletButtonTeacher.Visible = false;
            this.DeletButtonTeacher.Click += new System.EventHandler(this.DeletButtonTeacher_Click);
            // 
            // UpButtonTeacher
            // 
            this.UpButtonTeacher.Location = new System.Drawing.Point(207, 452);
            this.UpButtonTeacher.Name = "UpButtonTeacher";
            this.UpButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.UpButtonTeacher.TabIndex = 40;
            this.UpButtonTeacher.Text = "Изменить";
            this.UpButtonTeacher.Visible = false;
            this.UpButtonTeacher.Click += new System.EventHandler(this.UpButtonTeacher_Click);
            // 
            // InsertButtonTeacher
            // 
            this.InsertButtonTeacher.Location = new System.Drawing.Point(368, 452);
            this.InsertButtonTeacher.Name = "InsertButtonTeacher";
            this.InsertButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonTeacher.TabIndex = 39;
            this.InsertButtonTeacher.Text = "Добавить";
            this.InsertButtonTeacher.Visible = false;
            this.InsertButtonTeacher.Click += new System.EventHandler(this.InsertButtonTeacher_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(96, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "ФИО";
            // 
            // TeacherName
            // 
            this.TeacherName.Location = new System.Drawing.Point(257, 63);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(455, 23);
            this.TeacherName.TabIndex = 37;
            // 
            // CategoryName
            // 
            this.CategoryName.FormattingEnabled = true;
            this.CategoryName.ItemHeight = 24;
            this.CategoryName.Location = new System.Drawing.Point(257, 198);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(455, 30);
            this.CategoryName.TabIndex = 52;
            // 
            // DepartmentName
            // 
            this.DepartmentName.FormattingEnabled = true;
            this.DepartmentName.ItemHeight = 24;
            this.DepartmentName.Location = new System.Drawing.Point(257, 248);
            this.DepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(455, 30);
            this.DepartmentName.TabIndex = 53;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(96, 258);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 20);
            this.metroLabel7.TabIndex = 54;
            this.metroLabel7.Text = "Кафедра";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(96, 208);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 20);
            this.metroLabel8.TabIndex = 55;
            this.metroLabel8.Text = "Категория";
            // 
            // InsertTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 551);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.DissertationName);
            this.Controls.Add(this.CandidanscaiName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.PresentName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SexName);
            this.Controls.Add(this.DeletButtonTeacher);
            this.Controls.Add(this.UpButtonTeacher);
            this.Controls.Add(this.InsertButtonTeacher);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TeacherName);
            this.Name = "InsertTeacher";
            this.Text = "Таблица преподователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker DateB;
        private MetroFramework.Controls.MetroTextBox DissertationName;
        private MetroFramework.Controls.MetroTextBox CandidanscaiName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox PresentName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox SexName;
        private MetroFramework.Controls.MetroButton DeletButtonTeacher;
        private MetroFramework.Controls.MetroButton UpButtonTeacher;
        private MetroFramework.Controls.MetroButton InsertButtonTeacher;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TeacherName;
        private MetroFramework.Controls.MetroComboBox CategoryName;
        private MetroFramework.Controls.MetroComboBox DepartmentName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}