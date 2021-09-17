namespace BD_v1
{
    partial class InsertPrisvaivanie_kontrol
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
            this.DeletButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.UpButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.InsertButtonForm_of_control = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.FormName = new MetroFramework.Controls.MetroComboBox();
            this.GruppaName = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // DeletButtonForm_of_control
            // 
            this.DeletButtonForm_of_control.Location = new System.Drawing.Point(502, 293);
            this.DeletButtonForm_of_control.Name = "DeletButtonForm_of_control";
            this.DeletButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonForm_of_control.TabIndex = 76;
            this.DeletButtonForm_of_control.Text = "Удалить";
            this.DeletButtonForm_of_control.Visible = false;
            this.DeletButtonForm_of_control.Click += new System.EventHandler(this.DeletButtonForm_of_control_Click);
            // 
            // UpButtonForm_of_control
            // 
            this.UpButtonForm_of_control.Location = new System.Drawing.Point(180, 293);
            this.UpButtonForm_of_control.Name = "UpButtonForm_of_control";
            this.UpButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.UpButtonForm_of_control.TabIndex = 75;
            this.UpButtonForm_of_control.Text = "Изменить";
            this.UpButtonForm_of_control.Visible = false;
            this.UpButtonForm_of_control.Click += new System.EventHandler(this.UpButtonForm_of_control_Click_1);
            // 
            // InsertButtonForm_of_control
            // 
            this.InsertButtonForm_of_control.Location = new System.Drawing.Point(341, 293);
            this.InsertButtonForm_of_control.Name = "InsertButtonForm_of_control";
            this.InsertButtonForm_of_control.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonForm_of_control.TabIndex = 74;
            this.InsertButtonForm_of_control.Text = "Добавить";
            this.InsertButtonForm_of_control.Visible = false;
            this.InsertButtonForm_of_control.Click += new System.EventHandler(this.InsertButtonForm_of_control_Click_1);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(93, 128);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 20);
            this.metroLabel8.TabIndex = 80;
            this.metroLabel8.Text = "Группа";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(93, 178);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 20);
            this.metroLabel7.TabIndex = 79;
            this.metroLabel7.Text = "Форма";
            // 
            // FormName
            // 
            this.FormName.FormattingEnabled = true;
            this.FormName.ItemHeight = 24;
            this.FormName.Location = new System.Drawing.Point(229, 168);
            this.FormName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(455, 30);
            this.FormName.TabIndex = 78;
            // 
            // GruppaName
            // 
            this.GruppaName.FormattingEnabled = true;
            this.GruppaName.ItemHeight = 24;
            this.GruppaName.Location = new System.Drawing.Point(229, 118);
            this.GruppaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GruppaName.Name = "GruppaName";
            this.GruppaName.Size = new System.Drawing.Size(455, 30);
            this.GruppaName.TabIndex = 77;
            // 
            // InsertPrisvaivanie_kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 405);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.GruppaName);
            this.Controls.Add(this.DeletButtonForm_of_control);
            this.Controls.Add(this.UpButtonForm_of_control);
            this.Controls.Add(this.InsertButtonForm_of_control);
            this.Name = "InsertPrisvaivanie_kontrol";
            this.Text = "Форма контроля группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton DeletButtonForm_of_control;
        private MetroFramework.Controls.MetroButton UpButtonForm_of_control;
        private MetroFramework.Controls.MetroButton InsertButtonForm_of_control;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox FormName;
        private MetroFramework.Controls.MetroComboBox GruppaName;
    }
}