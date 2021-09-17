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
    public partial class InsertTeacher : MetroFramework.Forms.MetroForm
    {
        public InsertTeacher(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonTeacher.Visible = true;
            }
            else
            {
                UpButtonTeacher.Visible = true;
                DeletButtonTeacher.Visible = true;
                loadString();
            }
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Teacher Where ID_teacher={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            TeacherName.Text = dt.Rows[0][2].ToString();
            SexName.SelectedValue = dt.Rows[0][4];
            PresentName.SelectedValue = dt.Rows[0][3];
            CategoryName.SelectedValue = dt.Rows[0][5];
            DepartmentName.SelectedValue = dt.Rows[0][8];
            CandidanscaiName.Text = dt.Rows[0][6].ToString();
            DissertationName.Text = dt.Rows[0][7].ToString();
            DateB.Text = dt.Rows[0][1].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Sex", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Presence_of_children_and_their_number", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * From Category", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * From Department", con);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            con.Close();
            SexName.DataSource = dt1;
            SexName.DisplayMember = "Sex";
            SexName.ValueMember = "ID_sex";
            PresentName.DataSource = dt2;
            PresentName.DisplayMember = "Numder_of_children";
            PresentName.ValueMember = "ID_presence_of_children_and_their_number";
            CategoryName.DataSource = dt3;
            CategoryName.DisplayMember = "Name";
            CategoryName.ValueMember = "ID_category";
            DepartmentName.DataSource = dt4;
            DepartmentName.DisplayMember = "Name";
            DepartmentName.ValueMember = "ID_department";

        }

        private void DeletButtonTeacher_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Teacher WHERE ID_teacher={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonTeacher_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Teacher SET FIO='{TeacherName.Text}'," +
                $"ID_sex={SexName.SelectedValue}," +
                $"ID_presence_and_number ={PresentName.SelectedValue}," +
                $"topic_of_candidanscai='{CandidanscaiName.Text}'," +
                $"topic_of_doctorial_dissertation='{DissertationName.Text}'," +
                $"DateB='{DateB.Text}'," +
                $"ID_category={CategoryName.SelectedValue}," +
                $"ID_department={DepartmentName.SelectedValue} " +
                $"WHERE ID_teacher ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonTeacher_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Teacher(ID_sex,FIO,topic_of_candidanscai,topic_of_doctorial_dissertation,ID_presence_and_number,DateB,ID_category,ID_department) " +
                $"VALUES({SexName.SelectedValue},'{TeacherName.Text}','{CategoryName.Text}','{DissertationName.Text}',{PresentName.SelectedValue},'{DateB.Text}',{CategoryName.SelectedValue},{DepartmentName.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}