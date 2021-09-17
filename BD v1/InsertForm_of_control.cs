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
    public partial class InsertPrisvaivanie_kontrol : MetroFramework.Forms.MetroForm
    {
        public InsertPrisvaivanie_kontrol(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
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
            
        }
        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ($"Select * From Prisvaivanie_kontrol Where ID_prisvaivanie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            GruppaName.SelectedValue = dt.Rows[0][1];
            FormName.SelectedValue = dt.Rows[0][2];

        }
        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * From Form_of_control", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * From Groupa", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            GruppaName.DataSource = dt1;
            GruppaName.DisplayMember = "Name";
            GruppaName.ValueMember = "ID_form_of_control";
            FormName.DataSource = dt2;
            FormName.DisplayMember = "Name";
            FormName.ValueMember = "ID_group";

        }

        private void DeletButtonForm_of_control_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE FROM Prisvaivanie_kontrol WHERE  ID_prisvaivanie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }

        private void UpButtonForm_of_control_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter($"UPDATE Prisvaivanie_kontrol SET ID_form_of_control={FormName.SelectedValue}, ID_group={GruppaName.SelectedValue} WHERE ID_prisvaivanie={id}", con); 
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();
        }

        private void InsertButtonForm_of_control_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO Prisvaivanie_kontrol(ID_form_of_control,ID_group) " +
                $"VALUES({FormName.SelectedValue},{GruppaName.SelectedValue})", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}