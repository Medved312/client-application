namespace BD_v1
{
    partial class InsertEmployment
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
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PosName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TeacherName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.UpButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.InsertButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(79, 306);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 20);
            this.metroLabel6.TabIndex = 86;
            this.metroLabel6.Text = "Дата";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "yyyy-MM-dd";
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(316, 304);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 22);
            this.DateTime.TabIndex = 85;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(79, 255);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 20);
            this.metroLabel3.TabIndex = 84;
            this.metroLabel3.Text = "Должность";
            // 
            // PosName
            // 
            this.PosName.FormattingEnabled = true;
            this.PosName.ItemHeight = 24;
            this.PosName.Location = new System.Drawing.Point(316, 245);
            this.PosName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PosName.Name = "PosName";
            this.PosName.Size = new System.Drawing.Size(455, 30);
            this.PosName.TabIndex = 83;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 184);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 20);
            this.metroLabel2.TabIndex = 82;
            this.metroLabel2.Text = "Преподаватель";
            // 
            // TeacherName
            // 
            this.TeacherName.FormattingEnabled = true;
            this.TeacherName.ItemHeight = 24;
            this.TeacherName.Location = new System.Drawing.Point(316, 174);
            this.TeacherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(455, 30);
            this.TeacherName.TabIndex = 81;
            // 
            // DeletButtonEvaluation
            // 
            this.DeletButtonEvaluation.Location = new System.Drawing.Point(494, 369);
            this.DeletButtonEvaluation.Name = "DeletButtonEvaluation";
            this.DeletButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonEvaluation.TabIndex = 80;
            this.DeletButtonEvaluation.Text = "Удалить";
            this.DeletButtonEvaluation.Visible = false;
            this.DeletButtonEvaluation.Click += new System.EventHandler(this.DeletButtonEvaluation_Click_1);
            // 
            // UpButtonEvaluation
            // 
            this.UpButtonEvaluation.Location = new System.Drawing.Point(172, 369);
            this.UpButtonEvaluation.Name = "UpButtonEvaluation";
            this.UpButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.UpButtonEvaluation.TabIndex = 79;
            this.UpButtonEvaluation.Text = "Изменить";
            this.UpButtonEvaluation.Visible = false;
            this.UpButtonEvaluation.Click += new System.EventHandler(this.UpButtonEvaluation_Click_1);
            // 
            // InsertButtonEvaluation
            // 
            this.InsertButtonEvaluation.Location = new System.Drawing.Point(333, 369);
            this.InsertButtonEvaluation.Name = "InsertButtonEvaluation";
            this.InsertButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonEvaluation.TabIndex = 78;
            this.InsertButtonEvaluation.Text = "Добавить";
            this.InsertButtonEvaluation.Visible = false;
            this.InsertButtonEvaluation.Click += new System.EventHandler(this.InsertButtonEvaluation_Click_1);
            // 
            // InsertEmployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.PosName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.DeletButtonEvaluation);
            this.Controls.Add(this.UpButtonEvaluation);
            this.Controls.Add(this.InsertButtonEvaluation);
            this.Name = "InsertEmployment";
            this.Text = "Таблица должностей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker DateTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox PosName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox TeacherName;
        private MetroFramework.Controls.MetroButton DeletButtonEvaluation;
        private MetroFramework.Controls.MetroButton UpButtonEvaluation;
        private MetroFramework.Controls.MetroButton InsertButtonEvaluation;
    }
}