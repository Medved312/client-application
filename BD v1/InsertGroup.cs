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
    public partial class InsertGroup : MetroFramework.Forms.MetroForm
    {
        
        public InsertGroup(int _id)
        {
            InitializeComponent();
            id = _id;
            loadComboBox();
            if (_id < 0)
            {
                InsertButtonGroup.Visible = true;
                
            }
            else
            {
                UpButtonGroup.Visible = true;
                DeletButtonGroup.Visible = true;
                loadString();

            }
            
        }

        int id;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * From Groupa Where ID_group=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            GroupName.Text = dt.Rows[0][2].ToString();
            CouseName.SelectedValue = dt.Rows[0][1];
        }

        void loadComboBox()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * From Couse", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            CouseName.DataSource = dt1;
            CouseName.DisplayMember = "Name";
            CouseName.ValueMember = "ID_course";

        }


        private void UpButtonGroup_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da1 = new MySqlDataAdapter("UPDATE Groupa SET Name='" + GroupName.Text + "',ID_course='" + CouseName.SelectedValue + "'  WHERE ID_Group =" + id, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            Close();

        }

        private void InsertButtonGroup_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
              ("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO Groupa(Name,ID_course) VALUES('" + GroupName.Text + "','" + CouseName.SelectedValue + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();

        }

        private void DeletButtonGroup_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM Groupa WHERE ID_Group =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();

        }
    }
}
