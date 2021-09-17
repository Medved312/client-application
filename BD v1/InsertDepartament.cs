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
    public partial class InsertDepartament : MetroFramework.Forms.MetroForm
    {
        public InsertDepartament(int _id)
        {
            InitializeComponent();
            id = _id;
            if (_id < 0)
            {
                InsertButtonDepartment.Visible = true;
            }
            else
            {
                UpButtonDepartment.Visible = true;
                DeletButtonDepartment.Visible = true;
                loadString();
            }
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Department Where ID_department={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DepartamentName.Text = dt.Rows[0][1].ToString();
        }

        private void DeletButtonDepartment_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Department WHERE  ID_department={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonDepartment_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Department SET Name='{DepartamentName.Text}'" +
                $"WHERE ID_department ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonDepartment_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
            ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Department(Name) " +
                $"VALUES('{DepartamentName.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}