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
    public partial class InsertCouse : MetroFramework.Forms.MetroForm
    {
        public InsertCouse(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonCouse.Visible = true;
            }
            else
            {
                UpButtonCouse.Visible = true;
                DeletButtonCouse.Visible = true;
                loadString();
            }
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Couse Where ID_course={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            CouseName.Text = dt.Rows[0][2].ToString();
            FacultyName.SelectedValue = dt.Rows[0][1];

        }
        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Faculty", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            FacultyName.DataSource = dt2;
            FacultyName.DisplayMember = "Name";
            FacultyName.ValueMember = "ID_faculty";

        }

        private void DeletButtonCouse_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Couse WHERE ID_course={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonCouse_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Couse SET ID_faculty={FacultyName.SelectedValue}, Name={CouseName.Text} WHERE ID_course={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonCouse_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Couse(ID_faculty,Name) " +
                $"VALUES({FacultyName.SelectedValue},{CouseName.Text})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}
