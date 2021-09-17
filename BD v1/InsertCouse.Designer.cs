namespace BD_v1
{
    partial class InsertCouse
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
            this.CouseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.FacultyName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonCouse = new MetroFramework.Controls.MetroButton();
            this.UpButtonCouse = new MetroFramework.Controls.MetroButton();
            this.InsertButtonCouse = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CouseName
            // 
            this.CouseName.Location = new System.Drawing.Point(303, 156);
            this.CouseName.Name = "CouseName";
            this.CouseName.Size = new System.Drawing.Size(455, 23);
            this.CouseName.TabIndex = 95;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(93, 209);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 20);
            this.metroLabel8.TabIndex = 94;
            this.metroLabel8.Text = "Факультет";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(93, 156);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 20);
            this.metroLabel7.TabIndex = 93;
            this.metroLabel7.Text = "Название курса";
            // 
            // FacultyName
            // 
            this.FacultyName.FormattingEnabled = true;
            this.FacultyName.ItemHeight = 24;
            this.FacultyName.Location = new System.Drawing.Point(303, 199);
            this.FacultyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.Size = new System.Drawing.Size(455, 30);
            this.FacultyName.TabIndex = 92;
            // 
            // DeletButtonCouse
            // 
            this.DeletButtonCouse.Location = new System.Drawing.Point(502, 324);
            this.DeletButtonCouse.Name = "DeletButtonCouse";
            this.DeletButtonCouse.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonCouse.TabIndex = 91;
            this.DeletButtonCouse.Text = "Удалить";
            this.DeletButtonCouse.Visible = false;
            this.DeletButtonCouse.Click += new System.EventHandler(this.DeletButtonCouse_Click);
            // 
            // UpButtonCouse
            // 
            this.UpButtonCouse.Location = new System.Drawing.Point(180, 324);
            this.UpButtonCouse.Name = "UpButtonCouse";
            this.UpButtonCouse.Size = new System.Drawing.Size(155, 53);
            this.UpButtonCouse.TabIndex = 90;
            this.UpButtonCouse.Text = "Изменить";
            this.UpButtonCouse.Visible = false;
            this.UpButtonCouse.Click += new System.EventHandler(this.UpButtonCouse_Click);
            // 
            // InsertButtonCouse
            // 
            this.InsertButtonCouse.Location = new System.Drawing.Point(341, 324);
            this.InsertButtonCouse.Name = "InsertButtonCouse";
            this.InsertButtonCouse.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonCouse.TabIndex = 89;
            this.InsertButtonCouse.Text = "Добавить";
            this.InsertButtonCouse.Visible = false;
            this.InsertButtonCouse.Click += new System.EventHandler(this.InsertButtonCouse_Click);
            // 
            // InsertCouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 408);
            this.Controls.Add(this.CouseName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.FacultyName);
            this.Controls.Add(this.DeletButtonCouse);
            this.Controls.Add(this.UpButtonCouse);
            this.Controls.Add(this.InsertButtonCouse);
            this.Name = "InsertCouse";
            this.Text = "Таблица курса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CouseName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox FacultyName;
        private MetroFramework.Controls.MetroButton DeletButtonCouse;
        private MetroFramework.Controls.MetroButton UpButtonCouse;
        private MetroFramework.Controls.MetroButton InsertButtonCouse;
    }
}