using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MeterMIS
{
    public partial class ListForm : Form
    {        

        private string strSQLDepartment = "SELECT  * FROM  Departments Order by DepID";
        private string strSQLPerson = "SELECT  * FROM  Persons Order by PersonName";
        private string strSQLColIndex = "SELECT ColIndex FROM Users WHERE UserID = ";
        private string strSQLUser = "SELECT  * FROM  Users WHERE roleID = 1 Order by UserID";
        private string strSQLState = "SELECT  * FROM  CurrentState Order by CurStateID";
        private string strSQLDetType = "SELECT  * FROM  DetectType Order by DetTypeID";
        private string strSQLDetectPlace = "SELECT * FROM DetectPlace ORDER BY DetectPlaceID";
        private string strSQLSupplier = "SELECT  * FROM  Suppliers Order by SupName ";

        private string strSQLImpModel = @"SELECT ImpModel.ModID,Printed,Implements.ImpName, ImpModel.ImpNumber, ImpModel.Model,Suppliers.SupName, ImpModel.FactoryNumber, ImpModel.MeasuringRange, ImpModel.AccuracyClass, ImpModel.DivisionValue,
               ImpModel.Size, CONVERT(varchar(10), ImpModel.UseTime, 23) AS UseTime, CONVERT(varchar(10), ImpModel.LastDetectTime, 23) AS LastDetectTime, DetectIntervalValue, CONVERT(varchar(10), ImpModel.NextDetectTime, 23) AS NextDetectTime,  
               DetectType.DetTypeName, DetectPlace.DetectPlaceName,DetectResult.DetResultName,ABCRange, CurrentState.CurStateName,ImpModel.UsePlace, Departments.DepName,Persons.PersonName, Users.UserName,Comment 
               FROM ImpModel INNER JOIN
               Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN 
               Suppliers ON ImpModel.SupplierID = Suppliers.SupplierID INNER JOIN               
               DetectResult ON ImpModel.DetResultID = DetectResult.DetResultID INNER JOIN
               DetectType ON ImpModel.DetTypeID = DetectType.DetTypeID INNER JOIN
               DetectPlace ON ImpModel.DetectPlaceID = DetectPlace.DetectPlaceID INNER JOIN              
               CurrentState ON ImpModel.CurrentState = CurrentState.CurStateID INNER JOIN              
               Persons ON ImpModel.PersonID = Persons.PersonID INNER JOIN
               Departments ON ImpModel.DepID = Departments.DepID INNER JOIN
               Users ON ImpModel.UserID = Users.UserID ";
     //    DetectIntervalTable ON ImpModel.DetectIntervalValue = DetectIntervalTable.DetectIntervalValue INNER JOIN
                    //Units ON ImpModel.UnitID = Units.UnitID INNER JOIN  Units.UnitName, ImpModel.UnitPrice,
        // ABCRange ON ImpModel.ABCRangeID = ABCRange.ABCRangeID INNER JOIN
        private string strOrderImpModel = " ORDER BY ImpDef,ImpModel.ImpNumber";
        private string strImpDelete = "Delete From ImpModel Where ModID = {0}";
   
        private string strImpID= string.Empty;
        //private string strImpName = string.Empty;   
        private bool bListVisible = false;
        private bool bFirstLoadFormCol = true;
        private FormColumn formCol;
        private OleDbDataAdapter adapter;
        private DataTable dt;
    
        public OleDbConnection conn;
        public bool IsDirty = false;
        public int IMode = 0;//0 list 1,print 

        public ListForm()
        {
            InitializeComponent();            
        }        
        private void ListForm_Load(object sender, EventArgs e)
        {
            if (IMode == 0)
            {              
                btnPrint.Visible = false;               
            }
            StripMenuDelete.Visible = (License.RoleID == 0);
            conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            License.SetTreeView(treeView1, conn);
            adapter = new OleDbDataAdapter("", conn);            
            dt = new DataTable();
            //cb = new OleDbCommandBuilder(adapter);
            
            FillCombobox();

            if (IMode == 0 && License.RoleID != 2)
            {
                dataGridView1.ContextMenuStrip = contextMenuStrip1;
                OleDbCommand command2 = new OleDbCommand(strSQLColIndex + License.UserID, conn);
                object ob = command2.ExecuteScalar();
                string strColIndex = ob.ToString();
                
                if (strColIndex != null && strColIndex != string.Empty)
                {
                    for (int i = 4; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Visible = strColIndex.Contains(((char)(i + 61)).ToString());
                    }
                }
            }
            else
                dataGridView1.ContextMenuStrip = null;    

        }
        private string BulidSQL()
        {
            strImpID = License.GetTreeNodeID(treeView1);
            StringBuilder strSQL = new StringBuilder(" WHERE ImpModel.ImpID IN (" + strImpID + ")");
            if (comboDepart.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DepID = " + comboDepart.SelectedValue);
            if (comboPerson.SelectedIndex >= 0)
                strSQL.Append(" AND ImpModel.PersonID = " + comboPerson.SelectedValue);
            if (comboUser.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.UserID = " + comboUser.SelectedValue);
            if (comboDetectType.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DetTypeID = " + comboDetectType.SelectedValue);
            if (comboFactory.SelectedIndex >= 0)
                strSQL.Append(" AND ImpModel.SupplierID = " + comboFactory.SelectedValue);
            if (comboDetPlace.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DetectPlaceID = " + comboDetPlace.SelectedValue);
            if (comboABC.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.ABCRange = '" + comboABC.Text + "' ");

            string strtime;
            switch (tabControl1.SelectedIndex)
            {
                case 0: strtime = "UseTime";
                    break;
                case 1: strtime = "LastDetectTime";
                    break;
                default: strtime = "NextDetectTime";
                    break;
            }                
            if (dateFrom.Checked)
            {
                strSQL.Append(" AND " + strtime +" >= '" + dateFrom.Value.ToShortDateString() + "'");
            }
            if (dateTo.Checked)
            {
                strSQL.Append(" AND " + strtime + " <= '" + dateTo.Value.ToShortDateString() + "'");
            }
            if (listState.SelectedIndices.Count != 0)
            {
                strSQL.Append(" AND (");
                foreach (object obj in listState.SelectedItems)
                {
                    strSQL.Append(" CurrentState = " + ((DataRowView)obj)["CurStateID"].ToString() + " OR");
                }
                strSQL.Remove(strSQL.Length - 3, 3);
                strSQL.Append(")");
            }

            if (textImpNum.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND ImpNumber LIKE '" + textImpNum.Text.Trim() + "%'");
            }
            if (textModel.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND Model LIKE '" + textModel.Text.Trim() + "%'");
            }
            if (textFactNum.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND FactoryNumber LIKE '" + textFactNum.Text.Trim() + "%'");
            }
            if (textMeasuring.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND MeasuringRange LIKE '" + textMeasuring.Text.Trim() + "%'");
            }
            strSQL.Append(strOrderImpModel);
            return strSQLImpModel + strSQL.ToString();

        }

      
        private void FillCombobox()
        {
            OleDbDataAdapter adapterCom = new OleDbDataAdapter(strSQLDepartment, conn);
            DataTable dtCom = new DataTable();
            adapterCom.Fill(dtCom);
            comboDepart.DisplayMember = "DepName";
            comboDepart.ValueMember = "DepID";
            comboDepart.DataSource = dtCom;           

            DataTable dtCom2 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetType;
            adapterCom.Fill(dtCom2);
            comboDetectType.DisplayMember = "DetTypeName";
            comboDetectType.ValueMember = "DetTypeID";
            comboDetectType.DataSource = dtCom2;         

           
            DataTable dtCom3 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLUser;
            adapterCom.Fill(dtCom3);
            comboUser.DisplayMember = "UserName";
            comboUser.ValueMember = "UserID";
            comboUser.DataSource = dtCom3;          

            DataTable dtCom4 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLState;
            adapterCom.Fill(dtCom4);
            listState.DisplayMember = "CurStateName";
            listState.ValueMember = "CurStateID";
            listState.DataSource = dtCom4;
            listState.ClearSelected();
            listState.SetSelected(2, true);
            listState.SetSelected(3, true);

            adapterCom.SelectCommand.CommandText = strSQLPerson;
            DataTable dtCom5 = new DataTable();
            adapterCom.Fill(dtCom5);
            comboPerson.DataSource = dtCom5;          

            DataTable dtCom6 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetectPlace;
            adapterCom.Fill(dtCom6);
            comboDetPlace.DisplayMember = "DetectPlaceName";
            comboDetPlace.ValueMember = "DetectPlaceID";
            comboDetPlace.DataSource = dtCom6;           

            DataTable dtCom13 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLSupplier;
            adapterCom.Fill(dtCom13);
            comboFactory.DataSource = dtCom13;

            ClearBox();
        }

        private void ListForm_Resize(object sender, EventArgs e)
        {
            splitContainer1.Width = Width - 16;
            splitContainer1.Height = Height - 40;
            treeView1.Height = splitContainer1.Height;
            groupBox1.Width = splitContainer1.Panel2.Width;
            dataGridView1.Width = groupBox1.Width;
            dataGridView1.Height = splitContainer1.Height - 107;          
        }
        
        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dt.Dispose();
            adapter.Dispose();
            conn.Close();
            GC.Collect();
        }

        private void listState_LostFocus(object sender, EventArgs e)
        {
            listState.Visible = false;
        }

        private void comboState_DropDown(object sender, EventArgs e)
        {
            bListVisible = !bListVisible;
            listState.Visible = bListVisible;
            if (listState.Visible)
                listState.Focus();
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

      
        private void ViewImpForm(int iMode)
        {
            if (dataGridView1.CurrentRow != null)
            {
                IsDirty = false;
                ImpForm impform = new ImpForm();
                impform.iEditMode = iMode;              
               // impform.strImpID = strImpID;
                impform.iModID = (int)dataGridView1.CurrentRow.Cells["ModID"].Value;
                impform.conn = conn;
                this.AddOwnedForm(impform);
                impform.ShowDialog();
                if (IsDirty)
                {
                    int oldint = dataGridView1.CurrentRow.Index;
                    FillGrid();
                    dataGridView1.BindingContext[dt].Position = oldint;
                }
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {               
            if ( dataGridView1.CurrentRow != null)
            {
              //  strImpName = (string)dataGridView1.CurrentRow.Cells["ImpName"].Value;
                ViewImpForm(IMode == 0 && License.RoleID != 2 ? 1 : 0);
            }
        }      
        private void StripMenuView_Click(object sender, EventArgs e)
        {
            ViewImpForm(0);  //view
        }
        private void StripMenuEdit_Click(object sender, EventArgs e)
        {
            ViewImpForm(1);
        }

        private void StripMenuNew_Click(object sender, EventArgs e)
        {
            IsDirty = false;
            ImpForm impform = new ImpForm();
            impform.iEditMode = 2;           
            impform.strImpID = strImpID;
            impform.iModID = 0;
            impform.conn = conn;
            this.AddOwnedForm(impform);
            impform.ShowDialog();
            if (IsDirty)
            {                
                FillGrid();             
            }
        }

        private void StripMenuCopy_Click(object sender, EventArgs e)
        {
            ViewImpForm(2);  //copy
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
        private void ClearBox()
        {
            comboDepart.SelectedIndex = -1;
            comboPerson.SelectedIndex = -1;
            comboUser.SelectedIndex = -1;
            comboDetectType.SelectedIndex = -1;
            comboDetPlace.SelectedIndex = -1;
            comboFactory.SelectedIndex = -1;
            comboABC.SelectedIndex = -1;
            textFactNum.Text = string.Empty;
            textImpNum.Text = string.Empty;
            textModel.Text = string.Empty;
            textMeasuring.Text = string.Empty;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Level != 4 || strImpID == e.Node.Name) return;
           // strImpID = e.Node.Name;
            //strImpName = e.Node.Text; 
            ClearBox();
            FillGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            PrintForm printform = new PrintForm();

            printform.reportViewer1.LocalReport.ReportPath = "Print\\" + License.DataBaseName.Substring(6) + "\\ReportLedger.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportDetect_ReportDetect", dt));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                {           
                    new ReportParameter("DepName", comboDepart.SelectedIndex >0? comboDepart.Text: License.strAll),                
                    new ReportParameter("UserName", comboUser.SelectedIndex >0 ?comboUser.Text:License.strAll),                               
                 new ReportParameter("CompanyName", License.CompanyName),
                  new ReportParameter("ReportCode", License.ReportCode1),                               
                  new ReportParameter("Category",treeView1.SelectedNode.Text)
                });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            treeView1.Width = splitContainer1.Panel1.Width;
            groupBox1.Width = splitContainer1.Panel2.Width;
            dataGridView1.Width = splitContainer1.Panel2.Width;
           
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            License.SetGridColor(dataGridView1);
        }

        private void StripMenuColumn_Click(object sender, EventArgs e)
        {
            if (bFirstLoadFormCol)
            {
                formCol = new FormColumn();
                bFirstLoadFormCol = false;
                this.AddOwnedForm(formCol);
                formCol.LoadItems(dataGridView1);
                formCol.conn = conn;
            }
            formCol.ShowDialog();            
        }
                       
    }
}
