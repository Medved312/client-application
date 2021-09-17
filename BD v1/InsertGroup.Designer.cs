namespace BD_v1
{
    partial class InsertGroup
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
            this.DeletButtonGroup = new MetroFramework.Controls.MetroButton();
            this.UpButtonGroup = new MetroFramework.Controls.MetroButton();
            this.InsertButtonGroup = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GroupName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CouseName = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // DeletButtonGroup
            // 
            this.DeletButtonGroup.Location = new System.Drawing.Point(407, 327);
            this.DeletButtonGroup.Name = "DeletButtonGroup";
            this.DeletButtonGroup.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonGroup.TabIndex = 18;
            this.DeletButtonGroup.Text = "Удалить";
            this.DeletButtonGroup.Visible = false;
            this.DeletButtonGroup.Click += new System.EventHandler(this.DeletButtonGroup_Click);
            // 
            // UpButtonGroup
            // 
            this.UpButtonGroup.Location = new System.Drawing.Point(85, 327);
            this.UpButtonGroup.Name = "UpButtonGroup";
            this.UpButtonGroup.Size = new System.Drawing.Size(155, 53);
            this.UpButtonGroup.TabIndex = 17;
            this.UpButtonGroup.Text = "Изменить";
            this.UpButtonGroup.Visible = false;
            this.UpButtonGroup.Click += new System.EventHandler(this.UpButtonGroup_Click);
            // 
            // InsertButtonGroup
            // 
            this.InsertButtonGroup.Location = new System.Drawing.Point(246, 327);
            this.InsertButtonGroup.Name = "InsertButtonGroup";
            this.InsertButtonGroup.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonGroup.TabIndex = 16;
            this.InsertButtonGroup.Text = "Добавить";
            this.InsertButtonGroup.Visible = false;
            this.InsertButtonGroup.Click += new System.EventHandler(this.InsertButtonGroup_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Наименование";
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(169, 71);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(410, 23);
            this.GroupName.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Курс";
            // 
            // CouseName
            // 
            this.CouseName.FormattingEnabled = true;
            this.CouseName.ItemHeight = 24;
            this.CouseName.Location = new System.Drawing.Point(169, 145);
            this.CouseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CouseName.Name = "CouseName";
            this.CouseName.Size = new System.Drawing.Size(455, 30);
            this.CouseName.TabIndex = 19;
            // 
            // InsertGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CouseName);
            this.Controls.Add(this.DeletButtonGroup);
            this.Controls.Add(this.UpButtonGroup);
            this.Controls.Add(this.InsertButtonGroup);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.GroupName);
            this.Name = "InsertGroup";
            this.Text = "Таблица группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton DeletButtonGroup;
        private MetroFramework.Controls.MetroButton UpButtonGroup;
        private MetroFramework.Controls.MetroButton InsertButtonGroup;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox GroupName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CouseName;
    }
}