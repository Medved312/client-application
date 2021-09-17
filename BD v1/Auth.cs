using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_v1
{
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From LoginPas Where Log='{LoginTextBox.Text}' and Pas='{PasswordTextBox.Text}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                int role=Convert.ToInt32(dt.Rows[0][3]);
                Menu M = new Menu(role);
                M.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели не правильный логин и/или пароль", "Ошибка доступа");
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MetroButton1_Click(sender,e);
            }
        }
    }
}
