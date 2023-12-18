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
    public partial class BatchForm : Form
    {        
        private string strSQLDepartment = "SELECT  * FROM  Departments Order by DepID";
        private string strSQLImp = "SELECT  * FROM  Implements Order by ImpName";
        private string strSQLUser = "SELECT  * FROM  Users WHERE roleID = 1 Order by UserID";
        private string strSQLPerson = "SELECT  * FROM  Persons Order by PersonName ";
        private string strSQLInsertHistory = "Insert into DetectHistory select ModID,ImpID,{0} AS LastDetectTime,DetResultID,107 AS stateID,DepID,PersonID,UserID from ImpModel ";

        private string strSQLImpModel = @"SELECT Implements.ImpName,ImpModel.ModID, ImpModel.ImpNumber, ImpModel.Model, ImpModel.MeasuringRange,
               CONVERT(varchar(10), ImpModel.NextDetectTime, 23) AS NextDetectTime,
               CurrentState.CurStateName, DetectType.DetTypeName, DetectResult.DetResultName,ABCRange, Departments.DepName,Persons.PersonName 
               FROM ImpModel INNER JOIN   
               Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN                      
               Persons ON ImpModel.PersonID = Persons.PersonID INNER JOIN 
               DetectType ON ImpModel.DetTypeID = DetectType.DetTypeID INNER JOIN    
               DetectResult ON ImpModel.DetResultID = DetectResult.DetResultID INNER JOIN     
               CurrentState ON ImpModel.CurrentState = CurrentState.CurStateID INNER JOIN        
               DetectIntervalTable ON ImpModel.DetectIntervalValue = DetectIntervalTable.DetectIntervalValue INNER JOIN                                        
               Departments ON ImpModel.DepID = Departments.DepID ";

        private string strWhere = string.Empty;
        private string strSQLImpUpdate = "Update ImpModel Set ";                
              
        private string strOrderImpModel = " ORDER BY ImpModel.ImpNumber";
        private DataTable dt;
        private OleDbDataAdapter adapter;
        public OleDbConnection conn;

        public BatchForm()
        {
            InitializeComponent();
        }
        private void FillCombobox()
        {
            OleDbDataAdapter adapterCom = new OleDbDataAdapter(strSQLDepartment, conn);
            DataTable dtCom = new DataTable();
            adapterCom.Fill(dtCom);
            comboDepart.DisplayMember = "DepName";
            comboDepart.ValueMember = "DepID";
            comboDepart.DataSource = dtCom;
            comboDepart.SelectedIndex = -1;

            DataTable dtCom2 = new DataTable();
            adapterCom.Fill(dtCom2);
            comboNewDepart.DisplayMember = "DepName";
            comboNewDepart.ValueMember = "DepID";
            comboNewDepart.DataSource = dtCom2;
            comboNewDepart.SelectedIndex = -1;

            DataTable dtCom3 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLUser;
            adapterCom.Fill(dtCom3);         
            comboOldUser.DataSource = dtCom3;
            comboOldUser.SelectedIndex = -1;

            DataTable dtCom4 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLUser;
            adapterCom.Fill(dtCom4);
            comboNewUser.DataSource = dtCom4;
            comboNewUser.SelectedIndex = -1;

            DataTable dtCom5 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLImp;
            adapterCom.Fill(dtCom5);
            comboImp.DisplayMember = "ImpName";
            comboImp.ValueMember = "ImpID";
            comboImp.DataSource = dtCom5;
            comboImp.SelectedIndex = -1;

            DataTable dtCom6 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLPerson;
            adapterCom.Fill(dtCom6);
            comboPerson.DataSource = dtCom6;
            comboPerson.SelectedIndex = -1;

            DataTable dtCom7 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLPerson;
            adapterCom.Fill(dtCom7);
            comboNewPerson.DataSource = dtCom7;
            comboNewPerson.SelectedIndex = -1;        
        }
       
        private void BatchForm_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            adapter = new OleDbDataAdapter("", conn);
            dt = new DataTable();
            FillCombobox();      
        }
        private string BulidSQL()
        {
            StringBuilder strSQL = new StringBuilder(" WHERE ");
            if (radioUser.Checked)
            {
                strSQL.Append(" ImpModel.UserID = " + comboOldUser.SelectedValue);                
                if (comboImp.SelectedIndex >= 0)
                    strSQL.Append(" AND ImpModel.ImpID = " + comboImp.SelectedValue);
            }
            else
            {
                if (comboPerson.SelectedIndex >= 0)
                    strSQL.Append(" ImpModel.PersonID = " + comboPerson.SelectedValue);
                else strSQL.Append("1=1");

                if (comboDepart.SelectedIndex > 0)
                    strSQL.Append(" AND ImpModel.DepID = " + comboDepart.SelectedValue);
                if (textImpNum.Text.Trim() != string.Empty)
                {
                    strSQL.Append(" AND ImpNumber LIKE '" + textImpNum.Text.Trim() + "%'");
                }
            }
            strWhere = strSQL.ToString();
            strSQL.Append(strOrderImpModel);
            return strSQLImpModel + strSQL.ToString();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (radioUser.Checked && comboOldUser.SelectedIndex <= 0 || radioPerson.Checked && comboPerson.SelectedIndex < 0 && textImpNum.Text.Trim() == string.Empty)
                MessageBox.Show("原使用者,原确认者或计量编号不得为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dt.Clear();
                adapter.SelectCommand.CommandText = BulidSQL();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                lblCount.Text = dt.Rows.Count.ToString();
            }
        }
       

        private void BatchForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - 120;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            if (radioPerson.Checked && comboNewPerson.SelectedIndex < 0 || radioUser.Checked && comboNewUser.SelectedIndex <= 0)
                MessageBox.Show("现使用者或现确认者不得为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MessageBox.Show("你确定要批量转移吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = conn;
                command2.CommandText = string.Format(strSQLInsertHistory, dateMove.Text) + strWhere;
                command2.ExecuteNonQuery();

                StringBuilder strSQL = new StringBuilder(strSQLImpUpdate);
                if (radioPerson.Checked)
                {
                    strSQL.Append(" PersonID = " + comboNewPerson.SelectedValue);
                    if (comboNewDepart.SelectedIndex > 0)
                        strSQL.Append(" , DepID = " + comboNewDepart.SelectedValue);
                }
                else
                    strSQL.Append(" UserID = " + comboNewUser.SelectedValue);               
                
                strSQL.Append(strWhere);
                command2.CommandText = strSQL.ToString();                
                command2.ExecuteNonQuery();

                dt.Clear();
                dataGridView1.DataSource = dt;
                lblCount.Text = dt.Rows.Count.ToString();
            }
        }        
    }
}
