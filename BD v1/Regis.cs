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
    public partial class Regis : MetroFramework.Forms.MetroForm
    {
        public Regis(int _role)
        {
            InitializeComponent();
            Role = _role;
            refresh();
        }
        int Role;
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=Role;Uid=root;Pwd=;charset=utf8");
            con.Open();
            switch (Role)
            {
                case 1:
                    MySqlDataAdapter da = new MySqlDataAdapter
                ("Select LoginPas.ID_LogPas,LoginPas.Log as 'Логин', LoginPas.Pas as 'Пароль', Role.Role as 'Привилегии' From LoginPas, Role  " +
                "where LoginPas.ID_Role=Role.ID_Role AND LoginPas.ID_Role in (2,3)", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    dataGridView1.Columns[0].Visible = false;
                    break;
                case 2:
                    MySqlDataAdapter da2 = new MySqlDataAdapter
                ("Select LoginPas.ID_LogPas,LoginPas.Log as 'Логин', LoginPas.Pas as 'Пароль', Role.Role as 'Привилегии' From LoginPas, Role " +
                "where LoginPas.ID_Role=Role.ID_Role AND LoginPas.ID_Role in (3)", con);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    con.Close();
                    dataGridView1.Columns[0].Visible = false;
                    break; 
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            InsertReg ir = new InsertReg(-1,Role);
            ir.ShowDialog();
            refresh();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                if (e.RowIndex !=-1)
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    InsertReg ir = new InsertReg(id, Role);
                    ir.ShowDialog();
                    refresh();
                }
                catch
                { }
            
        }

    }
}
