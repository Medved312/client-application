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
    public partial class InsertFaculty : MetroFramework.Forms.MetroForm
    {
        public InsertFaculty(int _id)
        {
            InitializeComponent();
            id = _id;
            if (_id < 0)
            {
                InsertButtonForm_of_control.Visible = true;
            }
            else
            {
                UpButtonForm_of_control.Visible = true;
                DeletButtonForm_of_control.Visible = true;
                loadString();
            }
            loadComboBox();
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Faculty Where ID_faculty={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            FaculryName.Text = dt.Rows[0][2].ToString();
            DepartName.SelectedValue = dt.Rows[0][1];

        }
        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Department", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            DepartName.DataSource = dt2;
            DepartName.DisplayMember = "Name";
            DepartName.ValueMember = "ID_department";

        }

        private void DeletButtonForm_of_control_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Faculty WHERE  ID_faculty={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonForm_of_control_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Faculty SET ID_department={DepartName.SelectedValue}, Name={FaculryName.Text} WHERE ID_faculty={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonForm_of_control_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Faculty(ID_department,Name) " +
                $"VALUES({DepartName.SelectedValue},{FaculryName.Text})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}
