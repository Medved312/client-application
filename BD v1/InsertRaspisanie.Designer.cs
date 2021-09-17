namespace BD_v1
{
    partial class InsertRaspisanie
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
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TeacherName = new MetroFramework.Controls.MetroComboBox();
            this.SubjectName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.class_typeName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.GruppaName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.UpButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.InsertButtonTeacher = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(126, 249);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 20);
            this.metroLabel8.TabIndex = 74;
            this.metroLabel8.Text = "Предмет";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(126, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(110, 20);
            this.metroLabel7.TabIndex = 73;
            this.metroLabel7.Text = "Преподователь";
            // 
            // TeacherName
            // 
            this.TeacherName.FormattingEnabled = true;
            this.TeacherName.ItemHeight = 24;
            this.TeacherName.Location = new System.Drawing.Point(262, 304);
            this.TeacherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(455, 30);
            this.TeacherName.TabIndex = 72;
            // 
            // SubjectName
            // 
            this.SubjectName.FormattingEnabled = true;
            this.SubjectName.ItemHeight = 24;
            this.SubjectName.Location = new System.Drawing.Point(262, 239);
            this.SubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(455, 30);
            this.SubjectName.TabIndex = 71;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(126, 367);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 20);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "Дата и время";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(262, 365);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 22);
            this.DateTime.TabIndex = 67;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(126, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 20);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "Тип занятия";
            // 
            // class_typeName
            // 
            this.class_typeName.FormattingEnabled = true;
            this.class_typeName.ItemHeight = 24;
            this.class_typeName.Location = new System.Drawing.Point(262, 181);
            this.class_typeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_typeName.Name = "class_typeName";
            this.class_typeName.Size = new System.Drawing.Size(455, 30);
            this.class_typeName.TabIndex = 63;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(126, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 20);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "Группа";
            // 
            // GruppaName
            // 
            this.GruppaName.FormattingEnabled = true;
            this.GruppaName.ItemHeight = 24;
            this.GruppaName.Location = new System.Drawing.Point(262, 131);
            this.GruppaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GruppaName.Name = "GruppaName";
            this.GruppaName.Size = new System.Drawing.Size(455, 30);
            this.GruppaName.TabIndex = 61;
            // 
            // DeletButtonTeacher
            // 
            this.DeletButtonTeacher.Location = new System.Drawing.Point(534, 475);
            this.DeletButtonTeacher.Name = "DeletButtonTeacher";
            this.DeletButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonTeacher.TabIndex = 60;
            this.DeletButtonTeacher.Text = "Удалить";
            this.DeletButtonTeacher.Visible = false;
            this.DeletButtonTeacher.Click += new System.EventHandler(this.DeletButtonTeacher_Click_1);
            // 
            // UpButtonTeacher
            // 
            this.UpButtonTeacher.Location = new System.Drawing.Point(212, 475);
            this.UpButtonTeacher.Name = "UpButtonTeacher";
            this.UpButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.UpButtonTeacher.TabIndex = 59;
            this.UpButtonTeacher.Text = "Изменить";
            this.UpButtonTeacher.Visible = false;
            this.UpButtonTeacher.Click += new System.EventHandler(this.UpButtonTeacher_Click_1);
            // 
            // InsertButtonTeacher
            // 
            this.InsertButtonTeacher.Location = new System.Drawing.Point(373, 475);
            this.InsertButtonTeacher.Name = "InsertButtonTeacher";
            this.InsertButtonTeacher.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonTeacher.TabIndex = 58;
            this.InsertButtonTeacher.Text = "Добавить";
            this.InsertButtonTeacher.Visible = false;
            this.InsertButtonTeacher.Click += new System.EventHandler(this.InsertButtonTeacher_Click_1);
            // 
            // InsertRaspisanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 555);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.class_typeName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.GruppaName);
            this.Controls.Add(this.DeletButtonTeacher);
            this.Controls.Add(this.UpButtonTeacher);
            this.Controls.Add(this.InsertButtonTeacher);
            this.Name = "InsertRaspisanie";
            this.Text = "Таблица расписания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox TeacherName;
        private MetroFramework.Controls.MetroComboBox SubjectName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker DateTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox class_typeName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox GruppaName;
        private MetroFramework.Controls.MetroButton DeletButtonTeacher;
        private MetroFramework.Controls.MetroButton UpButtonTeacher;
        private MetroFramework.Controls.MetroButton InsertButtonTeacher;
    }
}