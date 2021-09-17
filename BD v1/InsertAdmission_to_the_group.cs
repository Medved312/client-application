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
    public partial class InsertAdmission_to_the_group : MetroFramework.Forms.MetroForm
    {
        public InsertAdmission_to_the_group(int _id)
        {
            InitializeComponent();
            id = _id;
            if (_id < 0)
            {
                InsertButtonAdmission_to_the_group.Visible = true;
            }
            else
            {
                UpButtonAdmission_to_the_group.Visible = true;
                DeletButtonAdmission_to_the_group.Visible = true;
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
                ($"Select * From Admission_to_the_group Where iD_admission_to_the_group={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            StudentName.SelectedValue = dt.Rows[0][2];
            GrupaName.SelectedValue = dt.Rows[0][3];
            Date.Text = dt.Rows[0][1].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * From Student", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * From Groupa", con);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            con.Close();
            StudentName.DataSource = dt3;
            StudentName.DisplayMember = "FIO";
            StudentName.ValueMember = "ID_student";
            GrupaName.DataSource = dt4;
            GrupaName.DisplayMember = "Name";
            GrupaName.ValueMember = "ID_group";

        }



        private void DeletButtonAdmission_to_the_group_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Admission_to_the_group WHERE iD_admission_to_the_group={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonAdmission_to_the_group_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Admission_to_the_group SET " +
                $"Date='{Date.Text}'," +
                $"ID_student={StudentName.SelectedValue}," +
                $"ID_group={GrupaName.SelectedValue} " +
                $"WHERE iD_admission_to_the_group ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonAdmission_to_the_group_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Admission_to_the_group(Date,ID_student,ID_group) " +
                $"VALUES('{Date.Text}',{StudentName.SelectedValue},{GrupaName.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}