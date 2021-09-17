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
    public partial class InsertRaspisanie : MetroFramework.Forms.MetroForm
    {
        public InsertRaspisanie(int _id)
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
                ($"Select * From Raspisanie Where ID_raspisanie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            GruppaName.SelectedValue = dt.Rows[0][2];
            class_typeName.SelectedValue = dt.Rows[0][3];
            SubjectName.SelectedValue = dt.Rows[0][4];
            TeacherName.SelectedValue = dt.Rows[0][5];
            DateTime.Text = dt.Rows[0][1].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Groupa", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Class_type", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * From Subject", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * From Teacher", con);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            con.Close();
            GruppaName.DataSource = dt1;
            GruppaName.DisplayMember = "Name";
            GruppaName.ValueMember = "ID_group";
            class_typeName.DataSource = dt2;
            class_typeName.DisplayMember = "Name";
            class_typeName.ValueMember = "ID_class_type";
            SubjectName.DataSource = dt3;
            SubjectName.DisplayMember = "Name";
            SubjectName.ValueMember = "ID_subject";
            TeacherName.DataSource = dt4;
            TeacherName.DisplayMember = "FIO";
            TeacherName.ValueMember = "ID_teacher";

        }


        private void DeletButtonTeacher_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Raspisanie WHERE ID_raspisanie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonTeacher_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Raspisanie SET ID_group ={GruppaName.SelectedValue }," +
                $"ID_class_type ={class_typeName.SelectedValue}," +
                $"DateTime='{DateTime.Text}'," +
                $"ID_subject={SubjectName.SelectedValue}," +
                $"ID_teacher={TeacherName.SelectedValue} " +
                $"WHERE ID_raspisanie ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonTeacher_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Raspisanie(ID_group,ID_class_type,DateTime,ID_subject,ID_teacher) " +
                $"VALUES({GruppaName.SelectedValue},{class_typeName.SelectedValue},'{DateTime.Text}',{SubjectName.SelectedValue},{TeacherName.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}