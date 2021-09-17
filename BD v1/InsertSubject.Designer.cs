namespace BD_v1
{
    partial class InsertSubject
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
            this.DeletButtonSubject = new MetroFramework.Controls.MetroButton();
            this.UpButtonSubject = new MetroFramework.Controls.MetroButton();
            this.InsertButtonSubject = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SubjectName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // DeletButtonSubject
            // 
            this.DeletButtonSubject.Location = new System.Drawing.Point(458, 253);
            this.DeletButtonSubject.Name = "DeletButtonSubject";
            this.DeletButtonSubject.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonSubject.TabIndex = 71;
            this.DeletButtonSubject.Text = "Удалить";
            this.DeletButtonSubject.Visible = false;
            this.DeletButtonSubject.Click += new System.EventHandler(this.DeletButtonSubject_Click_1);
            // 
            // UpButtonSubject
            // 
            this.UpButtonSubject.Location = new System.Drawing.Point(136, 253);
            this.UpButtonSubject.Name = "UpButtonSubject";
            this.UpButtonSubject.Size = new System.Drawing.Size(155, 53);
            this.UpButtonSubject.TabIndex = 70;
            this.UpButtonSubject.Text = "Изменить";
            this.UpButtonSubject.Visible = false;
            this.UpButtonSubject.Click += new System.EventHandler(this.UpButtonSubject_Click);
            // 
            // InsertButtonSubject
            // 
            this.InsertButtonSubject.Location = new System.Drawing.Point(297, 253);
            this.InsertButtonSubject.Name = "InsertButtonSubject";
            this.InsertButtonSubject.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonSubject.TabIndex = 69;
            this.InsertButtonSubject.Text = "Добавить";
            this.InsertButtonSubject.Visible = false;
            this.InsertButtonSubject.Click += new System.EventHandler(this.InsertButtonSubject_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 20);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Наименование предмета";
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(286, 114);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(455, 23);
            this.SubjectName.TabIndex = 67;
            // 
            // InsertSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.DeletButtonSubject);
            this.Controls.Add(this.UpButtonSubject);
            this.Controls.Add(this.InsertButtonSubject);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SubjectName);
            this.Name = "InsertSubject";
            this.Text = "Таблица предметов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton DeletButtonSubject;
        private MetroFramework.Controls.MetroButton UpButtonSubject;
        private MetroFramework.Controls.MetroButton InsertButtonSubject;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox SubjectName;
    }
}