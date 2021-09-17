namespace BD_v1
{
    partial class InsertFaculty
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
            this.DepartName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.UpButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.InsertButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.FaculryName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(72, 204);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 20);
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Кафедра";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(72, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(146, 20);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Название факультета";
            // 
            // DepartName
            // 
            this.DepartName.FormattingEnabled = true;
            this.DepartName.ItemHeight = 24;
            this.DepartName.Location = new System.Drawing.Point(282, 194);
            this.DepartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartName.Name = "DepartName";
            this.DepartName.Size = new System.Drawing.Size(455, 30);
            this.DepartName.TabIndex = 85;
            // 
            // DeletButtonForm_of_control
            // 
            this.DeletButtonForm_of_control.Location = new System.Drawing.Point(481, 319);
            this.DeletButtonForm_of_control.Name = "DeletButtonForm_of_control";
            this.DeletButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonForm_of_control.TabIndex = 83;
            this.DeletButtonForm_of_control.Text = "Удалить";
            this.DeletButtonForm_of_control.Visible = false;
            this.DeletButtonForm_of_control.Click += new System.EventHandler(this.DeletButtonForm_of_control_Click_1);
            // 
            // UpButtonForm_of_control
            // 
            this.UpButtonForm_of_control.Location = new System.Drawing.Point(159, 319);
            this.UpButtonForm_of_control.Name = "UpButtonForm_of_control";
            this.UpButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.UpButtonForm_of_control.TabIndex = 82;
            this.UpButtonForm_of_control.Text = "Изменить";
            this.UpButtonForm_of_control.Visible = false;
            this.UpButtonForm_of_control.Click += new System.EventHandler(this.UpButtonForm_of_control_Click);
            // 
            // InsertButtonForm_of_control
            // 
            this.InsertButtonForm_of_control.Location = new System.Drawing.Point(320, 319);
            this.InsertButtonForm_of_control.Name = "InsertButtonForm_of_control";
            this.InsertButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonForm_of_control.TabIndex = 81;
            this.InsertButtonForm_of_control.Text = "Добавить";
            this.InsertButtonForm_of_control.Visible = false;
            this.InsertButtonForm_of_control.Click += new System.EventHandler(this.InsertButtonForm_of_control_Click);
            // 
            // FaculryName
            // 
            this.FaculryName.Location = new System.Drawing.Point(282, 151);
            this.FaculryName.Name = "FaculryName";
            this.FaculryName.Size = new System.Drawing.Size(455, 23);
            this.FaculryName.TabIndex = 88;
            // 
            // InsertFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FaculryName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.DepartName);
            this.Controls.Add(this.DeletButtonForm_of_control);
            this.Controls.Add(this.UpButtonForm_of_control);
            this.Controls.Add(this.InsertButtonForm_of_control);
            this.Name = "InsertFaculty";
            this.Text = "Таблица факультетов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox DepartName;
        private MetroFramework.Controls.MetroButton DeletButtonForm_of_control;
        private MetroFramework.Controls.MetroButton UpButtonForm_of_control;
        private MetroFramework.Controls.MetroButton InsertButtonForm_of_control;
        private MetroFramework.Controls.MetroTextBox FaculryName;
    }
}