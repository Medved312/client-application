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
    public partial class InsertStudent : MetroFramework.Forms.MetroForm
    {
        public InsertStudent(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonStudent.Visible = true;
            }
            else
            {
                UpButtonStudent.Visible = true;
                DeletButtonStudent.Visible = true;
                loadString();
            }
           
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * From Student Where ID_student=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            StudentName.Text = dt.Rows[0][2].ToString();
            SexName.SelectedValue = dt.Rows[0][1];
            PresentName.SelectedValue = dt.Rows[0][5];
            PhoneName.Text = dt.Rows[0][3].ToString(); 
            AddressName.Text = dt.Rows[0][4].ToString();
            DateB.Text = dt.Rows[0][6].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter ("Select * From Sex", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter ("Select * From Presence_of_children", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            SexName.DataSource = dt1;
            SexName.DisplayMember = "Sex";
            SexName.ValueMember = "ID_sex";
            PresentName.DataSource = dt2;
            PresentName.DisplayMember = "Name";
            PresentName.ValueMember = "ID_Presence_of_children";
        }


        private void UpButtonStudent_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("UPDATE Student SET FIO='" + StudentName.Text + "'," +
                "ID_sex=" + SexName.SelectedValue + "," +
                "ID_presence =" + PresentName.SelectedValue + "," +
                "Phone='" + PhoneName.Text + "'," +
                "Address='" + AddressName.Text + "'," +
                "DateB='" + DateB.Text + "' " +
                "WHERE ID_student =" + id, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonStudent_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
              ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Student(ID_sex,FIO,Phone,Address,ID_presence,DateB) " +
                "VALUES(" + SexName.SelectedValue + ",'" + StudentName.Text + "','" + PhoneName.Text + "','" + AddressName.Text + "',"+ PresentName.SelectedValue + ",'" + DateB.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void DeletButtonStudent_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM Student WHERE ID_student =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}
