namespace BD_v1
{
    partial class InsertDepartament
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
            this.DeletButtonDepartment = new MetroFramework.Controls.MetroButton();
            this.UpButtonDepartment = new MetroFramework.Controls.MetroButton();
            this.InsertButtonDepartment = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DepartamentName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // DeletButtonDepartment
            // 
            this.DeletButtonDepartment.Location = new System.Drawing.Point(448, 291);
            this.DeletButtonDepartment.Name = "DeletButtonDepartment";
            this.DeletButtonDepartment.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonDepartment.TabIndex = 76;
            this.DeletButtonDepartment.Text = "Удалить";
            this.DeletButtonDepartment.Visible = false;
            this.DeletButtonDepartment.Click += new System.EventHandler(this.DeletButtonDepartment_Click);
            // 
            // UpButtonDepartment
            // 
            this.UpButtonDepartment.Location = new System.Drawing.Point(126, 291);
            this.UpButtonDepartment.Name = "UpButtonDepartment";
            this.UpButtonDepartment.Size = new System.Drawing.Size(155, 53);
            this.UpButtonDepartment.TabIndex = 75;
            this.UpButtonDepartment.Text = "Изменить";
            this.UpButtonDepartment.Visible = false;
            this.UpButtonDepartment.Click += new System.EventHandler(this.UpButtonDepartment_Click);
            // 
            // InsertButtonDepartment
            // 
            this.InsertButtonDepartment.Location = new System.Drawing.Point(287, 291);
            this.InsertButtonDepartment.Name = "InsertButtonDepartment";
            this.InsertButtonDepartment.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonDepartment.TabIndex = 74;
            this.InsertButtonDepartment.Text = "Добавить";
            this.InsertButtonDepartment.Visible = false;
            this.InsertButtonDepartment.Click += new System.EventHandler(this.InsertButtonDepartment_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 155);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(168, 20);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "Наименование кафедры";
            // 
            // DepartamentName
            // 
            this.DepartamentName.Location = new System.Drawing.Point(276, 152);
            this.DepartamentName.Name = "DepartamentName";
            this.DepartamentName.Size = new System.Drawing.Size(455, 23);
            this.DepartamentName.TabIndex = 72;
            // 
            // InsertDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 370);
            this.Controls.Add(this.DeletButtonDepartment);
            this.Controls.Add(this.UpButtonDepartment);
            this.Controls.Add(this.InsertButtonDepartment);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DepartamentName);
            this.Name = "InsertDepartament";
            this.Text = "InsertDepartament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton DeletButtonDepartment;
        private MetroFramework.Controls.MetroButton UpButtonDepartment;
        private MetroFramework.Controls.MetroButton InsertButtonDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox DepartamentName;
    }
}