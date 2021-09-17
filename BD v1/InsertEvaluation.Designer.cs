namespace BD_v1
{
    partial class InsertEvaluation
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
            this.StudentName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SubjectName = new MetroFramework.Controls.MetroComboBox();
            this.DeletButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.UpButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.InsertButtonEvaluation = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EvaluationName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(76, 322);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 20);
            this.metroLabel6.TabIndex = 77;
            this.metroLabel6.Text = "Дата и время";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "yyyy-MM-dd HH-mm-ss";
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(313, 320);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 22);
            this.DateTime.TabIndex = 76;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(76, 271);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.TabIndex = 75;
            this.metroLabel3.Text = "Студент";
            // 
            // StudentName
            // 
            this.StudentName.FormattingEnabled = true;
            this.StudentName.ItemHeight = 24;
            this.StudentName.Location = new System.Drawing.Point(313, 261);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(455, 30);
            this.StudentName.TabIndex = 74;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(76, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 20);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Предмет";
            // 
            // SubjectName
            // 
            this.SubjectName.FormattingEnabled = true;
            this.SubjectName.ItemHeight = 24;
            this.SubjectName.Location = new System.Drawing.Point(313, 190);
            this.SubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(455, 30);
            this.SubjectName.TabIndex = 72;
            // 
            // DeletButtonEvaluation
            // 
            this.DeletButtonEvaluation.Location = new System.Drawing.Point(491, 385);
            this.DeletButtonEvaluation.Name = "DeletButtonEvaluation";
            this.DeletButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonEvaluation.TabIndex = 71;
            this.DeletButtonEvaluation.Text = "Удалить";
            this.DeletButtonEvaluation.Visible = false;
            this.DeletButtonEvaluation.Click += new System.EventHandler(this.DeletButtonEvaluation_Click);
            // 
            // UpButtonEvaluation
            // 
            this.UpButtonEvaluation.Location = new System.Drawing.Point(169, 385);
            this.UpButtonEvaluation.Name = "UpButtonEvaluation";
            this.UpButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.UpButtonEvaluation.TabIndex = 70;
            this.UpButtonEvaluation.Text = "Изменить";
            this.UpButtonEvaluation.Visible = false;
            this.UpButtonEvaluation.Click += new System.EventHandler(this.UpButtonEvaluation_Click);
            // 
            // InsertButtonEvaluation
            // 
            this.InsertButtonEvaluation.Location = new System.Drawing.Point(330, 385);
            this.InsertButtonEvaluation.Name = "InsertButtonEvaluation";
            this.InsertButtonEvaluation.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonEvaluation.TabIndex = 69;
            this.InsertButtonEvaluation.Text = "Добавить";
            this.InsertButtonEvaluation.Visible = false;
            this.InsertButtonEvaluation.Click += new System.EventHandler(this.InsertButtonEvaluation_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(76, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 20);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Оценка";
            // 
            // EvaluationName
            // 
            this.EvaluationName.Location = new System.Drawing.Point(313, 125);
            this.EvaluationName.Name = "EvaluationName";
            this.EvaluationName.Size = new System.Drawing.Size(455, 23);
            this.EvaluationName.TabIndex = 67;
            // 
            // InsertEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.DeletButtonEvaluation);
            this.Controls.Add(this.UpButtonEvaluation);
            this.Controls.Add(this.InsertButtonEvaluation);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.EvaluationName);
            this.Name = "InsertEvaluation";
            this.Text = "Таблица оценок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker DateTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox StudentName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox SubjectName;
        private MetroFramework.Controls.MetroButton DeletButtonEvaluation;
        private MetroFramework.Controls.MetroButton UpButtonEvaluation;
        private MetroFramework.Controls.MetroButton InsertButtonEvaluation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox EvaluationName;
    }
}