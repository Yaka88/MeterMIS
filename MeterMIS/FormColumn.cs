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
    public partial class FormColumn : Form
    {
        private DataGridView dgv;
        public OleDbConnection conn;
        private string strSQLUser = "UPDATE Users SET ColIndex = '{0}' WHERE UserID = {1}";
        public FormColumn()
        {
            InitializeComponent();            
        }
        public void LoadItems(DataGridView dgview)
        {
            dgv = dgview;
            for (int i = 4; i < dgv.ColumnCount; i++)
            {
                checkedListBox1.Items.Add(dgv.Columns[i].HeaderText, dgv.Columns[i].Visible);
            }
        }       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string strColIndex = string.Empty;
            for (int i = 4; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = checkedListBox1.GetItemChecked(i-4);
                if (dgv.Columns[i].Visible)
                    strColIndex += (char)(i + 61);//from A
            }
            OleDbCommand command2 = new OleDbCommand(string.Format(strSQLUser, strColIndex,License.UserID), conn);
            command2.ExecuteNonQuery();
            this.Hide();
        }
    }
}
