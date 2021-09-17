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
    public partial class Insert : MetroFramework.Forms.MetroForm
    {
        
        public Insert(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id<0)
            {
                InsertButtonSex.Visible = true;
            }
            else
            {
                UpButtonSex.Visible = true;
                DeletButtonSex.Visible = true;
                loadString();
            }
            
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * From Sex Where ID_sex=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            SexName.Text = dt.Rows[0][1].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Sex ", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();

        }


        private void InsertButtonSex_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
              ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO Sex(Sex) VALUES('" + SexName.Text+ "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonSex_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("UPDATE Sex SET Sex='" + SexName.Text + "' WHERE ID_sex =" + id, con);
            DataTable dt2 = new DataTable();
            da1.Fill(dt2); 
            con.Close();
            Close();
        }

        private void DeletButtonSex_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM Sex WHERE ID_Sex =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}
