namespace BD_v1
{
    partial class Insert
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
            this.SexName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.InsertButtonSex = new MetroFramework.Controls.MetroButton();
            this.UpButtonSex = new MetroFramework.Controls.MetroButton();
            this.DeletButtonSex = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // SexName
            // 
            this.SexName.Location = new System.Drawing.Point(161, 153);
            this.SexName.Name = "SexName";
            this.SexName.Size = new System.Drawing.Size(410, 23);
            this.SexName.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Наименование";
            // 
            // InsertButtonSex
            // 
            this.InsertButtonSex.Location = new System.Drawing.Point(255, 428);
            this.InsertButtonSex.Name = "InsertButtonSex";
            this.InsertButtonSex.Size = new System.Drawing.Size(155, 53);
            this.InsertButtonSex.TabIndex = 3;
            this.InsertButtonSex.Text = "Добавить";
            this.InsertButtonSex.Visible = false;
            this.InsertButtonSex.Click += new System.EventHandler(this.InsertButtonSex_Click);
            // 
            // UpButtonSex
            // 
            this.UpButtonSex.Location = new System.Drawing.Point(94, 428);
            this.UpButtonSex.Name = "UpButtonSex";
            this.UpButtonSex.Size = new System.Drawing.Size(155, 53);
            this.UpButtonSex.TabIndex = 12;
            this.UpButtonSex.Text = "Изменить";
            this.UpButtonSex.Visible = false;
            this.UpButtonSex.Click += new System.EventHandler(this.UpButtonSex_Click_1);
            // 
            // DeletButtonSex
            // 
            this.DeletButtonSex.Location = new System.Drawing.Point(416, 428);
            this.DeletButtonSex.Name = "DeletButtonSex";
            this.DeletButtonSex.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonSex.TabIndex = 13;
            this.DeletButtonSex.Text = "Удалить";
            this.DeletButtonSex.Visible = false;
            this.DeletButtonSex.Click += new System.EventHandler(this.DeletButtonSex_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 522);
            this.Controls.Add(this.DeletButtonSex);
            this.Controls.Add(this.UpButtonSex);
            this.Controls.Add(this.InsertButtonSex);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SexName);
            this.Name = "Insert";
            this.Text = "Пол";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox SexName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton InsertButtonSex;
        private MetroFramework.Controls.MetroButton UpButtonSex;
        private MetroFramework.Controls.MetroButton DeletButtonSex;
    }
}