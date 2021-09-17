namespace BD_v1
{
    partial class InsertAdmission_to_the_group
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
            this.GrupaName = new MetroFramework.Controls.MetroComboBox();
            this.StudentName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.DeletButtonAdmission_to_the_group = new MetroFramework.Controls.MetroButton();
            this.UpButtonAdmission_to_the_group = new MetroFramework.Controls.MetroButton();
            this.InsertButtonAdmission_to_the_group = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(105, 143);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 20);
            this.metroLabel8.TabIndex = 83;
            this.metroLabel8.Text = "Студент";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(105, 208);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 20);
            this.metroLabel7.TabIndex = 82;
            this.metroLabel7.Text = "Группа";
            // 
            // GrupaName
            // 
            this.GrupaName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupaName.FormattingEnabled = true;
            this.GrupaName.ItemHeight = 24;
            this.GrupaName.Location = new System.Drawing.Point(241, 198);
            this.GrupaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupaName.Name = "GrupaName";
            this.GrupaName.Size = new System.Drawing.Size(455, 30);
            this.GrupaName.TabIndex = 81;
            // 
            // StudentName
            // 
            this.StudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentName.FormattingEnabled = true;
            this.StudentName.ItemHeight = 24;
            this.StudentName.Location = new System.Drawing.Point(241, 133);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(455, 30);
            this.StudentName.TabIndex = 80;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(105, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 20);
            this.metroLabel6.TabIndex = 79;
            this.metroLabel6.Text = "Дата";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(241, 259);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 78;
            // 
            // DeletButtonAdmission_to_the_group
            // 
            this.DeletButtonAdmission_to_the_group.Location = new System.Drawing.Point(513, 369);
            this.DeletButtonAdmission_to_the_group.Name = "DeletButtonAdmission_to_the_group";
            this.DeletButtonAdmission_to_the_group.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonAdmission_to_the_group.TabIndex = 77;
            this.DeletButtonAdmission_to_the_group.Text = "Удалить";
            this.DeletButtonAdmission_to_the_group.Visible = false;
            this.DeletButtonAdmission_to_the_group.Click += new System.EventHandler(this.DeletButtonAdmission_to_the_group_Click);
            // 
            // UpButtonAdmission_to_the_group
            // 
            this.UpButtonAdmission_to_the_group.Location = new System.Drawing.Point(191, 369);
            this.UpButtonAdmission_to_the_group.Name = "UpButtonAdmission_to_the_group";
            this.UpButtonAdmission_to_the_group.Size = new System.Drawing.Size(155, 53);
            this.UpButtonAdmission_to_the_group.TabIndex = 76;
            this.UpButtonAdmission_to_the_group.Text = "Изменить";
            this.UpButtonAdmission_to_the_group.Visible = false;
            this.UpButtonAdmission_to_the_group.Click += new System.EventHandler(this.UpButtonAdmission_to_the_group_Click);
            // 
            // InsertButtonAdmission_to_the_group
            // 
            this.InsertButtonAdmission_to_the_group.Location = new System.Drawing.Point(352, 369);
            this.InsertButtonAdmission_to_the_group.Name = "InsertButtonAdmission_to_the_group";
            this.InsertButtonAdmission_to_the_group.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonAdmission_to_the_group.TabIndex = 75;
            this.InsertButtonAdmission_to_the_group.Text = "Добавить";
            this.InsertButtonAdmission_to_the_group.Visible = false;
            this.InsertButtonAdmission_to_the_group.Click += new System.EventHandler(this.InsertButtonAdmission_to_the_group_Click);
            // 
            // InsertAdmission_to_the_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.GrupaName);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DeletButtonAdmission_to_the_group);
            this.Controls.Add(this.UpButtonAdmission_to_the_group);
            this.Controls.Add(this.InsertButtonAdmission_to_the_group);
            this.Name = "InsertAdmission_to_the_group";
            this.Text = "Таблица зачисления в группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox GrupaName;
        private MetroFramework.Controls.MetroComboBox StudentName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker Date;
        private MetroFramework.Controls.MetroButton DeletButtonAdmission_to_the_group;
        private MetroFramework.Controls.MetroButton UpButtonAdmission_to_the_group;
        private MetroFramework.Controls.MetroButton InsertButtonAdmission_to_the_group;
    }
}