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
    public partial class InsertReg : MetroFramework.Forms.MetroForm
    {
        public InsertReg(int _id,int _role)
        {
            InitializeComponent();
            id = _id;
            role = _role;
            if (_id < 0)
            {
                AddRole.Visible = true;
            }
            else
            {
                UpButtonRole.Visible = true;
                DeletButtonRole.Visible = true;
                loadString();
            }
            
            if (role == 2)
            {
                RoleName.Visible = false;
                metroLabel3.Visible = false;
            }
        }
        int id;
        int role;
        void loadString()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * From LoginPas Where ID_logPas=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            LoginTextBox.Text = dt.Rows[0][1].ToString();
            PasswoedTextBox.Text = dt.Rows[0][2].ToString();
            RoleName.SelectedValue = dt.Rows[0][3];

        }

        void povtor()
        {
            MySqlConnection con = new MySqlConnection
             ("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter($"DELETE LoginPas "+ 
            $"FROM LoginPas " +
            $"LEFT OUTER JOIN(SELECT MIN(ID_LogPas) AS ID_LogPas, Log FROM LoginPas GROUP BY Log) AS tmp " +
            $"on LoginPas.ID_LogPas = tmp.ID_LogPas " +
            $"WHERE tmp.ID_LogPas is null ",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();

        }
        private void AddRole_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswoedTextBox.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
            }
            else
            {
                MySqlConnection con = new MySqlConnection
                 ("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
                con.Open();
                switch (role)
                {
                    case 1:
                        if (RoleName.Text == "Администратор")
                        {

                            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO LoginPas(Log,Pas,ID_Role) " +
                        "VALUES('" + LoginTextBox.Text + "','" + PasswoedTextBox.Text + "',2)", con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            con.Close();
                            Close();
                        }
                        else
                        {
                            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO LoginPas(Log,Pas,ID_Role) " +
                        "VALUES('" + LoginTextBox.Text + "','" + PasswoedTextBox.Text + "',3)", con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            con.Close();
                            Close();
                        }
                        povtor();


                        break;
                    case 2:
                        MySqlDataAdapter da2 = new MySqlDataAdapter("INSERT INTO LoginPas(Log,Pas,Role) " +
                    "VALUES('" + LoginTextBox.Text + "','" + PasswoedTextBox.Text + "',3)", con);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        con.Close();
                        Close();
                        povtor();
                        break;
                }
            }
        }

        private void UpButtonRole_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            switch (role)
            {
                case 1:
                    if (RoleName.Text == "Администратор")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("UPDATE LoginPas SET Log='" + LoginTextBox.Text + "'," +
                        "ID_Role =2," +
                        "Pas='" + PasswoedTextBox.Text + "' " +
                        "WHERE ID_logPas =" + id, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        Close();
                    }
                    else
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("UPDATE LoginPas SET Log='" + LoginTextBox.Text + "'," +
                        "ID_Role =3," +
                        "Pas='" + PasswoedTextBox.Text + "' " +
                        "WHERE ID_logPas =" + id, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        Close();
                    }
                    povtor();
                        break;
                case 2:
                    MySqlDataAdapter da1 = new MySqlDataAdapter("UPDATE LoginPas SET Log='" + LoginTextBox.Text + "'," +
                        "ID_Role =3," +
                        "Pas='" + PasswoedTextBox.Text + "'," +
                        "WHERE ID_logPas =" + id, con);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    con.Close();
                    Close();
                    povtor();
                    break;
            }
        }

        private void DeletButtonRole_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM LoginPas Where ID_logPas=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Close();
        }
    }
}
