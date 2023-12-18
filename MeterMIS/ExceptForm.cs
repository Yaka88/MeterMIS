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
    public partial class ExceptForm : Form
    {
        private string strSQLImpModel = @"SELECT Implements.ImpName,ImpModel.ModID, ImpModel.ImpNumber, ImpModel.Model, ImpModel.MeasuringRange,               
               CONVERT(varchar(10), ImpModel.UseTime, 23) AS UseTime,
               DetectType.DetTypeName, DetectResult.DetResultName,ABCRange, Departments.DepName,Persons.PersonName,Comment,
               CONVERT(varchar(10), ImpModel.LastDetectTime, 23) AS LastDealTime 
               FROM ImpModel INNER JOIN   
               Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN                      
               DetectType ON ImpModel.DetTypeID = DetectType.DetTypeID INNER JOIN    
               DetectResult ON ImpModel.DetResultID = DetectResult.DetResultID INNER JOIN     
               Persons ON ImpModel.PersonID = Persons.PersonID INNER JOIN                                  
               Departments ON ImpModel.DepID = Departments.DepID 
               Where CurrentState = ";

        private string strSQLState = "SELECT  * FROM  CurrentState Where CurStateID >0 Order by CurStateID";
        private string strImpDelete = "Delete From ImpModel Where ModID = {0}";
        private string strSQLInsertHistory = "Insert into DetectHistory select ModID,ImpID,LastDetectTime,DetResultID,currentstate as stateID,DepID,PersonID,UserID from ImpModel ";
        private string strSQLImpUpdate = @"Update ImpModel Set         
                LastDetectTime='{1}', NextDetectTime = DateAdd(Month,DetectIntervalValue,'{1}'),
                CurrentState = {2}, Printed = 0, Comment = '{3}'  
                Where ImpModel.ModID = {0} ";


        public bool IsDirty = false;

        private string strOrderImpModel = " ORDER BY ImpModel.ImpNumber";
        private DataTable dt;
        private OleDbDataAdapter adapter;
        public OleDbConnection conn;
        public ExceptForm()
        {
            InitializeComponent();
        }

        private void ExceptForm_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            adapter = new OleDbDataAdapter("", conn);
            dt = new DataTable();  
            OleDbDataAdapter adapterCom = new OleDbDataAdapter(strSQLState, conn);
            DataTable dtCom = new DataTable();
            adapterCom.Fill(dtCom);
            comboState.DisplayMember = "CurStateName";
            comboState.ValueMember = "CurStateID";
            comboState.DataSource = dtCom;
            DataTable dtComQ = new DataTable();
            adapterCom.Fill(dtComQ);
            comboStateQ.DisplayMember = "CurStateName";
            comboStateQ.ValueMember = "CurStateID";
            comboStateQ.DataSource = dtComQ;         
        }
        private string BulidSQL()
        {
            StringBuilder strSQL = new StringBuilder(strSQLImpModel);
            strSQL.Append(comboStateQ.SelectedValue.ToString());
            if (textImpNum.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND ImpNumber LIKE '" + textImpNum.Text.Trim() + "%'");
            }
            strSQL.Append(strOrderImpModel);
            return strSQL.ToString();
        }
        private void FillGrid()
        {
            dt.Clear();
            adapter.SelectCommand.CommandText = BulidSQL();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            lblCount.Text = dt.Rows.Count.ToString();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void ExceptForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - 120;
        }
        private void ViewImpForm(int iMode)
        {
            if (dataGridView1.CurrentRow != null)
            {
                IsDirty = false;
                ImpForm impform = new ImpForm();
                impform.iEditMode = iMode;                
                impform.iModID = (int)dataGridView1.CurrentRow.Cells["ModID"].Value;
                impform.conn = conn;
                this.AddOwnedForm(impform);
                impform.ShowDialog();

                if (IsDirty)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    lblCount.Text = dataGridView1.Rows.Count.ToString();
                }
            }
        }
        private void StripMenuView_Click(object sender, EventArgs e)
        {
            ViewImpForm(0);//view
        }

        private void StripMenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除记录吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strImpDelete, dr.Cells["ModID"].Value), conn);
                    command2.ExecuteNonQuery();
                    dataGridView1.Rows.Remove(dr);
                }
                lblCount.Text = dataGridView1.Rows.Count.ToString();
            }
        }

        private void StripMenuEdit_Click(object sender, EventArgs e)
        {
            ViewImpForm(3);//backUse
        }
        private void ChangeState(int intStateID)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int intmodId = (int)dataGridView1.CurrentRow.Cells["ModID"].Value;
                OleDbCommand command2 = new OleDbCommand(strSQLInsertHistory + " Where ModID = " + intmodId.ToString(), conn);
                command2.ExecuteNonQuery();
              
                command2.CommandText = string.Format(strSQLImpUpdate, intmodId,dateDeal.Text,intStateID,textMemo.Text);
                command2.ExecuteNonQuery();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);              
                lblCount.Text = dataGridView1.Rows.Count.ToString();
            }
        }
        private void StripMenuLost_Click(object sender, EventArgs e)
        {
            ChangeState(104);
        }

        private void StripMenuBreak_Click(object sender, EventArgs e)
        {
            ChangeState(106);
        }

        private void StripMenuSave_Click(object sender, EventArgs e)
        {
            ChangeState(105);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ChangeState((int)comboState.SelectedValue);
        }       
    }
}
