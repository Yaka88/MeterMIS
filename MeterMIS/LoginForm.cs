using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeterMIS
{
    public partial class LoginForm : Form
    {
        private string strSQLUser = "SELECT  * FROM  Users Order by UserID";      
        private OleDbDataAdapter adapter;
        private DataTable dt;
        
        public OleDbConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void execSQL()
        {
            string str = "SELECT  DetectPlace FROM     ImpModel GROUP BY DetectPlace order by DetectPlace";
            string strinsert = "INSERT INTO DetectPlace (DetectPlaceName) VALUES ('{0}')";
            try
            {
                OleDbCommand command = new OleDbCommand(str, conn);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strinsert, reader[0].ToString()), conn);
                    command2.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                string strr = e.Message;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            License lic = new License();
            if (lic.isValid)
            {
                conn = new OleDbConnection(License.strConnSQL);
                conn.Open();
                adapter = new OleDbDataAdapter(strSQLUser, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns["UserID"] };
                comboUser.DisplayMember = "UserName";
                comboUser.ValueMember = "UserID";
                comboUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("请确认系统合法性!", "登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void checkLogin()
        {

            DataRow dr = dt.Rows.Find(comboUser.SelectedValue);
            if (textPassword.Text == (string)dr["Password"])
            {               
                License.RoleID = (int)dr["RoleID"];
                License.UserID = (int)dr["UserID"];
                License.UserName = (string)dr["UserName"];
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误!", "登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                checkLogin();
        }
    }
}
