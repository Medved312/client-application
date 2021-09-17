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
    public partial class InsertEmployment : MetroFramework.Forms.MetroForm
    {
        public InsertEmployment(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonEvaluation.Visible = true;
            }
            else
            {
                UpButtonEvaluation.Visible = true;
                DeletButtonEvaluation.Visible = true;
                loadString();
            }
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Employment Where ID_employment={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            TeacherName.SelectedValue = dt.Rows[0][1];
            PosName.SelectedValue = dt.Rows[0][2];
            DateTime.Text = dt.Rows[0][3].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Teacher", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Pos", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            TeacherName.DataSource = dt1;
            TeacherName.DisplayMember = "FIO";
            TeacherName.ValueMember = "ID_teacher";
            PosName.DataSource = dt2;
            PosName.DisplayMember = "Name";
            PosName.ValueMember = "ID_position";

        }

        private void DeletButtonEvaluation_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Employment WHERE  ID_employment={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonEvaluation_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection($"Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Employment SET " +
                $"ID_teacher={TeacherName.SelectedValue}," +
                $"ID_position ={PosName.SelectedValue}," +
                $"Date='{DateTime.Text}' " +
                $"WHERE ID_employment ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonEvaluation_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Employment(ID_teacher,ID_position,Date) " +
                $"VALUES({TeacherName.SelectedValue},{PosName.SelectedValue},'{DateTime.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}