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
    public partial class InsertEvaluation : MetroFramework.Forms.MetroForm
    {
        public InsertEvaluation(int _id)
        {
            InitializeComponent();
            loadComboBox();
            id = _id;
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
                ($"Select * From Evaluation Where ID_evaluation={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            EvaluationName.Text = dt.Rows[0][1].ToString();
            SubjectName.SelectedValue = dt.Rows[0][2];
            StudentName.SelectedValue = dt.Rows[0][3];
            DateTime.Text = dt.Rows[0][4].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Subject", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Student", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            SubjectName.DataSource = dt1;
            SubjectName.DisplayMember = "Name";
            SubjectName.ValueMember = "ID_subject";
            StudentName.DataSource = dt2;
            StudentName.DisplayMember = "FIO";
            StudentName.ValueMember = "ID_student";

        }

        private void UpButtonEvaluation_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection($"Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Evaluation SET Evaluation='{EvaluationName.Text}'," +
                $"ID_subject={SubjectName.SelectedValue}," +
                $"ID_student ={StudentName.SelectedValue}," +
                $"DateTime='{DateTime.Text}' " +
                $"WHERE ID_evaluation ={id}", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonEvaluation_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Evaluation(Evaluation,ID_subject,ID_student,DateTime) " +
                $"VALUES('{EvaluationName.Text}',{SubjectName.SelectedValue},{StudentName.SelectedValue},'{DateTime.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void DeletButtonEvaluation_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Evaluation WHERE  ID_evaluation={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}