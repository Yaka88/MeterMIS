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
    public partial class TipsForm : Form
    {
        private string strSQLDepartment = "SELECT  * FROM  Departments Order by DepID";
        private string[] strTab = new string[5] { "本月未打印({0})","本月已检定({0})", "本月已过期({0})", "本月待检定({0})", "异常({0})" };
        private string strSQLImpModel = @"SELECT Implements.ImpName,ImpModel.ModID, ImpModel.ImpNumber, ImpModel.Model, ImpModel.MeasuringRange,
               CONVERT(varchar(10), ImpModel.LastDetectTime, 23) AS LastDetectTime,  CONVERT(varchar(10), ImpModel.NextDetectTime, 23) AS NextDetectTime,
               Departments.DepName, Persons.PersonName
               FROM ImpModel INNER JOIN   
               Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN                      
               Persons ON ImpModel.PersonID = Persons.PersonID INNER JOIN              
               Departments ON ImpModel.DepID = Departments.DepID Where ";
        private string strSQLState = "(Currentstate = 1 OR Currentstate = 2 OR Currentstate = 103 OR Currentstate = 108 OR Currentstate = 110) AND ";                
        private string strOrderImpModel = " ORDER BY ImpModel.NextDetectTime, ImpModel.ImpNumber";
                
        public OleDbConnection conn;
        private OleDbDataAdapter adapter;
        DataTable[] dt;

        public TipsForm()
        {
            InitializeComponent();
        }

        private void TipsForm_Load(object sender, EventArgs e)
        {           
            conn = new OleDbConnection(License.strConnSQL);
            conn.Open();            
            dt =  new DataTable[5];

            adapter = new OleDbDataAdapter(strSQLDepartment, conn);
            DataTable dtCom = new DataTable();
            adapter.Fill(dtCom);
            comboDepart.DisplayMember = "DepName";
            comboDepart.ValueMember = "DepID";
            comboDepart.DataSource = dtCom;
            //comboDepart.SelectedIndex = -1;
         
            if(License.RoleID == 1)
                strSQLImpModel += "ImpModel.UserID =" + License.UserID + " AND ";
            FillGrid(GridNoPrint, 0, strSQLState + "Printed <> 1 AND convert(nchar(7),NextDetectTime,23) = '" + License.strThisMonth + "'");
            FillGrid(GridDetected, 1, "convert(nchar(7),LastDetecttime,23) = '" + License.strThisMonth + "'");
            FillGrid(GridOverdue, 2, strSQLState + "NextDetectTime >= '" + License.strStartOfMonth + "' AND NextDetectTime <= '" + License.strEndLine + "'");
            FillGrid(GridDetect, 3, strSQLState + "NextDetectTime > '" + License.strEndLine + "' AND NextDetectTime < '" + License.strEndOfMonth + "'");
            FillGrid(GridException, 4,strSQLState + "NextDetectTime < '" + License.strStartOfMonth + "'");
            
            RefreshBar();
            Text += License.UserName;
        }
        private void RefreshBar()
        {
            progressBar1.Maximum = GridDetected.RowCount + GridOverdue.RowCount + GridDetect.RowCount;            
            lblMax.Text = progressBar1.Maximum.ToString();
            progressBar1.Value = GridDetected.RowCount;
        }
        private void FillGrid(DataGridView grid,int index, string strWhere)
        {
            adapter.SelectCommand.CommandText = strSQLImpModel + strWhere + strOrderImpModel;
            dt[index] = new DataTable();
            adapter.Fill(dt[index]);
            grid.DataSource = dt[index].DefaultView;
            tabControl1.TabPages[index].Text = string.Format(strTab[index], grid.RowCount);
        }
        private void TipsForm_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = Width - 20;
            tabControl1.Height = Height - 110;
            GridDetected.Width = Width - 28;
            GridDetected.Height = Height - 136;
            GridOverdue.Size = GridDetected.Size;                        ;
            GridDetect.Size = GridDetected.Size;
            GridException.Size = GridDetected.Size;
            GridNoPrint.Size = GridDetected.Size;
        }

        private void comboDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridDetected.DataSource == null) return;
            string filter = string.Empty;
            if(comboDepart.SelectedIndex > 0)                
                filter = "DepName = '" + comboDepart.Text + "'";

            DataView dv = (DataView)GridDetected.DataSource;
            dv.RowFilter = filter;
            tabControl1.TabPages[1].Text = string.Format(strTab[1], GridDetected.RowCount);
            dv = (DataView)GridOverdue.DataSource;
            dv.RowFilter = filter;
            tabControl1.TabPages[2].Text = string.Format(strTab[2], GridOverdue.RowCount);
            dv = (DataView)GridDetect.DataSource;
            dv.RowFilter = filter;
            tabControl1.TabPages[3].Text = string.Format(strTab[3], GridDetect.RowCount);
            dv = (DataView)GridException.DataSource;
            dv.RowFilter = filter;
            tabControl1.TabPages[4].Text = string.Format(strTab[4], GridException.RowCount);
            dv = (DataView)GridNoPrint.DataSource;
            dv.RowFilter = filter;
            tabControl1.TabPages[0].Text = string.Format(strTab[0], GridNoPrint.RowCount);

            RefreshBar();
        }
        private void ViewImpForm(DataGridView grid)
        {
            if (grid.CurrentRow != null)
            {               
                ImpForm impform = new ImpForm();
                impform.iEditMode = 0;
                // impform.strImpID = strImpID;
                impform.iModID = (int)grid.CurrentRow.Cells[1].Value;
                impform.conn = conn;
                this.AddOwnedForm(impform);
                impform.ShowDialog();                
            }
        }
        private void GridDetected_DoubleClick(object sender, EventArgs e)
        {
            ViewImpForm(GridDetected);
        }

        private void GridDetect_DoubleClick(object sender, EventArgs e)
        {
            ViewImpForm(GridDetect);
        }

        private void GridException_DoubleClick(object sender, EventArgs e)
        {
            ViewImpForm(GridException);
        }

        private void GridOverdue_DoubleClick(object sender, EventArgs e)
        {
            ViewImpForm(GridOverdue);
        }

        private void GridNoPrint_DoubleClick(object sender, EventArgs e)
        {
            ViewImpForm(GridNoPrint);
        }
    }
}
