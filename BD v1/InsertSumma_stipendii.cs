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
    public partial class InsertSumma_stipendii : MetroFramework.Forms.MetroForm
    {
        public InsertSumma_stipendii(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonSumma_stipendii.Visible = true;
            }
            else
            {
                UpButtonSumma_stipendii.Visible = true;
                DeletButtonSumma_stipendii.Visible = true;
                loadString();
            }
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * From Summa_stipendii Where ID_summa_stipendii=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Summa_stipendiiName.Text = dt.Rows[0][1].ToString();
            sign_receivedName.SelectedValue = dt.Rows[0][2];
            StudentName.SelectedValue = dt.Rows[0][3];
            DateTime.Text = dt.Rows[0][4].ToString();
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Sing_receeived", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Student", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            sign_receivedName.DataSource = dt1;
            sign_receivedName.DisplayMember = "Name";
            sign_receivedName.ValueMember = "ID_sing_receeived";
            StudentName.DataSource = dt2;
            StudentName.DisplayMember = "FIO";
            StudentName.ValueMember = "ID_student";

        }



        private void DeletButtonSumma_stipendii_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM Summa_stipendii WHERE  ID_summa_stipendii=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonSumma_stipendii_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("UPDATE Summa_stipendii SET Summa_stipendii='" + Summa_stipendiiName.Text + "'," +
                "ID_sign_received=" + sign_receivedName.SelectedValue + "," +
                "ID_student =" + StudentName.SelectedValue + "," +
                "DateTime='" + DateTime.Text + "' " +
                "WHERE ID_summa_stipendii =" + id, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonSumma_stipendii_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Summa_stipendii(Summa_stipendii,ID_sign_received,ID_student,dateTime) " +
                "VALUES('" + Summa_stipendiiName.Text + "'," + sign_receivedName.SelectedValue + "," + StudentName.SelectedValue + ",'" + DateTime.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}