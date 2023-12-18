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
    public partial class PasswordForm : Form
    {
        string strChangePass = "Update Users set password = {0} where Userid = {1}";
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textNewPass1.Text != textNewPass2.Text)
            {
                MessageBox.Show("两次密码不同,请重新输入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else if (textNewPass1.Text == string.Empty)
                MessageBox.Show("密码不得为空,请重新输入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                OleDbConnection conn = new OleDbConnection(License.strConnSQL);
                conn.Open();
                OleDbCommand command2 = new OleDbCommand(string.Format(strChangePass,textNewPass1.Text ,License.UserID),conn);
                command2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("密码修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
