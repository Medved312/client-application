namespace BD_v1
{
    partial class InsertReg
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
            this.RoleName = new MetroFramework.Controls.MetroComboBox();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswoedTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AddRole = new MetroFramework.Controls.MetroButton();
            this.DeletButtonRole = new MetroFramework.Controls.MetroButton();
            this.UpButtonRole = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // RoleName
            // 
            this.RoleName.FormattingEnabled = true;
            this.RoleName.ItemHeight = 24;
            this.RoleName.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.RoleName.Location = new System.Drawing.Point(264, 227);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(303, 30);
            this.RoleName.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(264, 72);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(303, 30);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswoedTextBox
            // 
            this.PasswoedTextBox.Location = new System.Drawing.Point(264, 136);
            this.PasswoedTextBox.Name = "PasswoedTextBox";
            this.PasswoedTextBox.Size = new System.Drawing.Size(303, 30);
            this.PasswoedTextBox.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Пароль";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 237);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Роль";
            // 
            // AddRole
            // 
            this.AddRole.Location = new System.Drawing.Point(291, 359);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(154, 53);
            this.AddRole.TabIndex = 6;
            this.AddRole.Text = " Добывить";
            this.AddRole.Click += new System.EventHandler(this.AddRole_Click);
            // 
            // DeletButtonRole
            // 
            this.DeletButtonRole.Location = new System.Drawing.Point(442, 359);
            this.DeletButtonRole.Name = "DeletButtonRole";
            this.DeletButtonRole.Size = new System.Drawing.Size(155, 53);
            this.DeletButtonRole.TabIndex = 44;
            this.DeletButtonRole.Text = "Удалить";
            this.DeletButtonRole.Visible = false;
            this.DeletButtonRole.Click += new System.EventHandler(this.DeletButtonRole_Click);
            // 
            // UpButtonRole
            // 
            this.UpButtonRole.Location = new System.Drawing.Point(140, 359);
            this.UpButtonRole.Name = "UpButtonRole";
            this.UpButtonRole.Size = new System.Drawing.Size(155, 53);
            this.UpButtonRole.TabIndex = 43;
            this.UpButtonRole.Text = "Изменить";
            this.UpButtonRole.Visible = false;
            this.UpButtonRole.Click += new System.EventHandler(this.UpButtonRole_Click);
            // 
            // InsertReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletButtonRole);
            this.Controls.Add(this.UpButtonRole);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswoedTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RoleName);
            this.Name = "InsertReg";
            this.Text = "Таблица пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox RoleName;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroTextBox PasswoedTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton AddRole;
        private MetroFramework.Controls.MetroButton DeletButtonRole;
        private MetroFramework.Controls.MetroButton UpButtonRole;
    }
}