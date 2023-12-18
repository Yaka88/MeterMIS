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
    public partial class DetectForm : Form
    {             
        private string strSQLDepartment = "SELECT  * FROM  Departments Order by DepID";
        private string strSQLPerson = "SELECT  * FROM  Persons Order by PersonName ";
        private string strSQLUser = "SELECT  * FROM  Users WHERE roleID = 1 Order by UserID";
        private string strSQLState = "SELECT  * FROM  CurrentState Order by CurStateID";
        private string strSQLDetType = "SELECT  * FROM  DetectType Order by DetTypeID";
        private string strSQLDetResult = "SELECT  * FROM  DetectResult Order by DetResultID";
        private string strSQLAlterViewByModel = @"Alter View ImpModelView AS SELECT ImpID {2}, CurrentState AS StateID, DetResultID,
                (CASE WHEN CONVERT(nchar(7), LastDetectTime, 23) = '{0}' THEN 1 ELSE 0 END) AS Detected 
                FROM ImpModel  {1} 
                AND (CONVERT(nchar(7), LastDetectTime, 23) = '{0}' OR
                (CONVERT(nchar(7), NextDetectTime, 23) = '{0}' AND 
                (CurrentState = 1 OR CurrentState = 2 OR CurrentState = 103 OR CurrentState = 108 OR CurrentState = 110)
			    ))
                UNION ALL
                SELECT DetectHistory.ImpID {2}, StateID,DetectHistory.DetResultID,1 AS Detected 
                FROM DetectHistory 
                INNER JOIN ImpModel ON ImpModel.ModID = DetectHistory.ModID 
                {1} AND (StateID <> 107 AND CONVERT(nchar(7),DetectHistory.LastDetectTime, 23) = '{0}') ";
   /*     private string strSQLAlterView = @"Alter View ImpModelView AS SELECT ImpID,CurrentState AS StateID, DetResultID,
                (CASE WHEN CONVERT(nchar(7), LastDetectTime, 23) = '{0}' THEN 1 ELSE 0 END) AS Detected 
                FROM ImpModel  {1} 
                AND (CONVERT(nchar(7), LastDetectTime, 23) = '{0}' OR
                (CONVERT(nchar(7), NextDetectTime, 23) = '{0}' AND 
                (CurrentState = 1 OR CurrentState = 2 OR CurrentState = 103 OR CurrentState = 108 OR CurrentState = 110)
			    ))
                UNION ALL
                SELECT DetectHistory2.ImpID,StateID,DetectHistory2.DetResultID,1 AS Detected FROM
                (SELECT * FROM DetectHistory  {1} 
                AND (StateID <> 107 AND CONVERT(nchar(7),LastDetectTime, 23) = '{0}'))
                AS DetectHistory2 ";      */
        private string strSQLAlterMonthView = @"Alter View ImpModelView AS 
                SELECT C2id,DepID, CurStateName, DetResultID,
                (CASE WHEN CONVERT(nchar(7), LastDetectTime, 23) = '{0}' THEN 1 ELSE 0 END) AS Detected 
                FROM ImpModel INNER JOIN              
                CurrentState ON ImpModel.CurrentState = CurrentState.CurStateID INNER JOIN
                Implements ON Implements.ImpID = ImpModel.ImpID INNER JOIN
                Category3 ON Implements.c3id = Category3.c3id
                WHERE (CONVERT(nchar(7), LastDetectTime, 23) = '{0}' OR
                (CONVERT(nchar(7), NextDetectTime, 23) = '{0}' AND 
                (CurrentState = 1 OR CurrentState = 2 OR CurrentState = 103 OR CurrentState = 108 OR CurrentState = 110)
			    ))
                UNION ALL
                SELECT C2id,DepID,CurStateName,DetResultID,1 AS Detected
                FROM DetectHistory INNER JOIN              
                CurrentState ON DetectHistory.StateID = CurrentState.CurStateID INNER JOIN
                Implements ON Implements.ImpID = DetectHistory.ImpID INNER JOIN
                Category3 ON Implements.c3id = Category3.c3id
                WHERE (StateID <> 107 AND CONVERT(nchar(7), LastDetectTime, 23) = '{0}')";
        private string strSQLMonthStat = @"select statetable.*,detecttable.*,C2name,DepName,
                        case when detected + undetect <> 0 then cast(detected * 100.00/(detected+ undetect) as decimal(5,2)) end as DetectRate,                        
                        case when detected <> 0 then cast(valid * 100.00/detected as decimal(5,2)) end as ValidRate
                        FROM
                        ((select c2id,Depid,count(case when CurStateName <> '新增' then 1 end) as PlanDetect,
                        sum(case when CurStateName <> '遗失' then Detected else 0 end) as detected,
                        count(case when Detected = 0 then 1 end) as undetect,                       
                        sum(case when DetResultID <> 2 And CurStateName <> '报废' And  CurStateName <> '维修' AND CurStateName <> '遗失' then Detected else 0 end) as valid
                        from impmodelview
                        group by c2id,Depid) AS detecttable                        
                        left join (select * from
                        (select c2id,Depid,CurStateName from ImpModelView where Detected =1) as ImpModelView2 
                        pivot (count(CurStateName) for CurStateName in ({0})) as pvt)
                        AS statetable ON detecttable.c2id = statetable.c2id and detecttable.Depid =statetable.Depid)
                        INNER JOIN Category2 ON detecttable.c2id = Category2.c2id
				        INNER JOIN Departments ON detecttable.DepID = Departments.DepID ";
        private string strSQLDetectStatByModel = @"select detecttable.*,ImpName,
                        case when detected + undetect <> 0 then cast(detected * 100.00/(detected+ undetect) as decimal(5,2)) end as DetectRate,                        
                        case when detected <> 0 then cast(valid * 100.00/detected as decimal(5,2)) end as ValidRate
                         {0} FROM
                        ((select impid,Model,count(case when StateID <> 2 then 1 end) as PlanDetect,
                        sum(case when StateID <> 104 then Detected else 0 end) as detected,  
                        count(case when Detected = 0 then 1 end) as undetect,                     
                        sum(case when DetResultID <> 2 And StateID <> 106 AND StateID <> 103 AND StateID <> 104 then Detected else 0 end) as valid
                        from impmodelview
                        group by impid,Model) AS detecttable                        
                        left join (select * from
                        (select impid,Model,StateID from ImpModelView where Detected =1) as ImpModelView2 
                        pivot (count(StateID) for StateID in 
                        ([1],[2],[103],[104],[105],[106],[107],[108],[109],[110])) as pvt)
                        AS statetable ON detecttable.impid = statetable.impid AND (detecttable.Model = statetable.Model OR detecttable.Model is null And statetable.Model is null ))
                        INNER JOIN
                        Implements ON detecttable.ImpID = Implements.ImpID ORDER BY detecttable.ImpID,detecttable.Model ";

        private string strSQLDetectStat = @"select detecttable.*,ImpName,
                        case when detected + undetect <> 0 then cast(detected * 100.00/(detected+ undetect) as decimal(5,2)) end as DetectRate,                        
                        case when detected <> 0 then cast(valid * 100.00/detected as decimal(5,2)) end as ValidRate
                         {0} FROM
                        ((select impid,count(case when StateID <> 2 then 1 end) as PlanDetect,
                        sum(case when StateID <> 104 then Detected else 0 end) as detected,
                        count(case when Detected = 0 then 1 end) as undetect,                         
                        sum(case when DetResultID <> 2 And StateID <> 106 AND StateID <> 103 AND StateID <> 104 then Detected else 0 end) as valid
                        from impmodelview
                        group by impid) AS detecttable                        
                        left join (select * from
                        (select impid,StateID from ImpModelView where Detected =1) as ImpModelView2 
                        pivot (count(StateID) for StateID in 
                        ([1],[2],[103],[104],[105],[106],[107],[108],[109],[110])) as pvt)
                        AS statetable ON detecttable.impid = statetable.impid )
                        INNER JOIN
                        Implements ON detecttable.ImpID = Implements.ImpID ORDER BY detecttable.ImpID ";
        //private string strSQLMonthPlan = @"SELECT * FROM  //for new test
        //(select ImpModel.impID,impName,Model,DepName from impmodel INNER JOIN
          //  Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN 
            //Departments ON ImpModel.DepID = Departments.DepID ";
        private string strSQLMonthPlan = @"SELECT ImpId,ImpName,Model,{0} As Amount, {1} FROM 
            (select ImpModel.impID,impName,Model,DepID from impmodel INNER JOIN
            Implements ON ImpModel.ImpID = Implements.ImpID ";
        //private string strSQLDepNamePivot = ") AS impmodel2 PIVOT (count(DepName) for DepName in ({0})) as pvt order by impid,Model";
        private string strSQLDepNamePivot = ") AS impmodel2 PIVOT (count(DepID) for DepID in ({0})) as pvt order by impid,Model"; //for new test

        private string strSQLImpModel = @"SELECT Implements.ImpName,ImpModel.ModID, ImpModel.ImpNumber, ImpModel.Model, ImpModel.MeasuringRange,
               CONVERT(varchar(10), ImpModel.LastDetectTime, 23) AS LastDetectTime, DetectIntervalValue, CONVERT(varchar(10), ImpModel.NextDetectTime, 23) AS NextDetectTime,
               DetResultID, DetectType.DetTypeName, CurrentState,ABCRange, Persons.PersonName, ImpModel.UsePlace,DepName, SupName, size,DetectPlaceName,Printed,Comment
               FROM ImpModel INNER JOIN   
               Suppliers ON ImpModel.SupplierID = Suppliers.SupplierID INNER JOIN  
               Implements ON ImpModel.ImpID = Implements.ImpID INNER JOIN                      
               DetectType ON ImpModel.DetTypeID = DetectType.DetTypeID INNER JOIN 
               DetectPlace ON ImpModel.DetectPlaceID = DetectPlace.DetectPlaceID INNER JOIN     
               Departments ON ImpModel.DepID = Departments.DepID INNER JOIN                             
               Persons ON ImpModel.PersonID = Persons.PersonID INNER JOIN             
               Users ON ImpModel.UserID = Users.UserID ";
        //DetectIntervalTable ON ImpModel.DetectIntervalValue = DetectIntervalTable.DetectIntervalValue INNER JOIN                         
        private string strSQLPrintUpdate = "Update ImpModel Set Printed = 1 ";
        private string strSQLInsertHistory = "Insert into DetectHistory select ModID,ImpID,LastDetectTime,DetResultID,currentstate as stateID,DepID,PersonID,UserID from ImpModel ";
        private string strSQLImpUpdate = @"Update ImpModel Set         
                LastDetectTime='{3}', NextDetectTime = DateAdd(Month,DetectIntervalValue,'{3}'),
                DetResultID= {1}, CurrentState = {2}, Printed = 0 ,[size] = '{4}', Comment = '{5}' 
                Where ImpModel.ModID = {0} ";

        private string strWhere = string.Empty;
        private string strOrderImpModel = " ORDER BY ImpModel.NextDetectTime, ImpModel.PersonID,ImpModel.ImpNumber";
        private string strOrderImpModel2 = " ORDER BY ImpDef,ImpModel.NextDetectTime,ImpModel.ImpNumber";

        private const string strYearStat = @"Select * From
                    (Select ImpID,ImpName,detectintervalvalue,
                    sum(JAN) as JanP, sum(FEB) as FebP,sum(mar) as MarP, sum(Apr) as AprP,
                    sum(May) as MayP, sum(Jun) as JunP,sum(JUL) as JulP, Sum(Aug) as AUGP,
                    sum(SEP) as SepP, Sum(OCT) as octP,sum(Nov) as NovP,sum([Dec]) as DecP
                    from YearPlan                    
                    where PlanYear = {0} {1} 
                    group by impID,ImpName,detectintervalvalue) as t1
                    left join
                    (select ImpID,DetectIntervalValue,
                    [1] as JAN,[2] as FEB,[3] as MAR,[4] as APR,[5] as MAY,[6] as JUN,
                    [7] as JUL,[8] as AUG,[9] as SEP,[10] as OCT,[11] as NOV,[12] as [DEC]
                    from
                    (SELECT ImpID,DetectIntervalValue,DATEPART(mm,lastdetecttime) as DetMonth
                    from impmodel where DATEPART(yyyy,lastdetecttime) = '{0}' and DetectIntervalValue > 0 {2} 
                    union all
                    select detectHistory.ImpID,DetectIntervalValue,DATEPART(mm,detectHistory.lastdetecttime) as DetMonth
                    from detectHistory 
                    inner join impmodel on impmodel.modid = detectHistory.modid
                    where StateID <> 107 and DATEPART(yyyy,detectHistory.lastdetecttime) = '{0}' and DetectIntervalValue > 0 {2})
                    as StatView
                    PIVOT (count(Detmonth) for Detmonth in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])) as pvt) as t2
                    on t1.impid = t2.impid and t1.detectintervalvalue = t2.detectintervalvalue
                    order by t1.impid,t1.detectintervalvalue";

        private const string strYearPlanSQL = @"Select * from YearPlan                      
                        Where PlanYear = ";
        private const string strYearPlanInsert = @"Insert Into YearPlan Select {0} as Planyear,depName,pvt.ImpID,model,DetectintervalValue,
                                [1]+[2]+[3]+[4]+[5]+[6]+[7]+[8]+[9]+[10]+[11]+[12] as quantity,
                                [1] as JAN,[2] as FEB,[3] as MAR,[4] as APR,[5] as MAY,[6] as JUN,
                                [7] as JUL,[8] as AUG,[9] as SEP,[10] as OCT,[11] as NOV,[12] as [DEC],ImpName from
                                (select depID,ImpID,Model,DetectintervalValue,
                                DATEPART(mm,nextdetecttime) as Detmonth from impmodel 
                        where (CurrentState = 1 OR CurrentState = 2 OR CurrentState = 103 OR CurrentState = 108 OR CurrentState = 110)
                        and DetectintervalValue > 0 and impmodel.impid is not null 
                        and DATEPART(yyyy,nextdetecttime) = '{0}')
                        as monthview
                        PIVOT (count(Detmonth) for Detmonth in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])) as pvt   
                        inner join departments on departments.depid = pvt.depid
                        inner join Implements on Implements.ImpID = pvt.impid                    
                        order by pvt.depid,pvt.impid ";

        private string strImpID = string.Empty;
        private string strImpName = string.Empty;
        private string strSpan = string.Empty;        
    
        private bool bListVisible = false;
        private DataGridViewCell currentCell;
        private OleDbDataAdapter adapter;
        private DataTable dt;
  
        public OleDbConnection conn;
        public int IMode = 0;//0 detect 1,print,2 stat  ,3 yearplan

        public DetectForm()
        {
            InitializeComponent();          
        }
        private void SetGridColumns()
        {
            dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImpNameS, 
            this.ModelS,
            this.PlanDetect,
            this.Detected,
            this.Undetect,
            this.DetectRate,                   
            this.State1,
            this.State2,
            this.State103,
            this.State104,
            this.State105,
            this.state106,
            this.state107,
            this.state108,
            this.state109,
            this.state110,   
            this.Valid,   
            this.ValidRate});
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ImpNameS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ModelS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void DetectForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (IMode == 0)
            {
               // comboUser.Visible = false;
               // label3.Visible = false;
                dataGridView1.ContextMenuStrip = contextMenuStrip1;
                dataGridView1.Controls.Add(dateTimePicker1);
            }
            else
            {
                btnDetect.Visible = false;                           
                CurStateName.ReadOnly = true;
                DetResultName.ReadOnly = true;
                if (IMode >= 2)  //stat  
                {
                    label4.Visible = false;
                    label2.Visible = false;
                    label8.Visible = false;
                    textImpNum.Visible = false;
                    comboPerson.Visible = false;
                    comboState.Visible = false;
                    ListDetectTime.Visible = false;
                    if (IMode == 2)
                    {
                        btnMonthReport.Visible = true;
                        btnPrint.Visible = true;
                        tabControl1.TabPages.Remove(tabDate);
                        tabControl1.TabPages.Remove(tabABCRange);
                        SetGridColumns();
                    }
                    else
                    {
                        tabControl1.Visible = false;                    
                        btnQuery.Visible = false;
                        label5.Visible = false;
                        lblCount.Visible = false;
                    }
                }
                else
                {
                    btnMonthPlan.Visible = true;
                    btnPrint.Visible = true;
                }
            }
            
         
            conn = new OleDbConnection(License.strConnSQL );
            conn.Open();
            License.SetTreeView(treeView1, conn);
            adapter = new OleDbDataAdapter("", conn);
            dt = new DataTable();

            FillCombobox();         
        }
    
        private string BuildWhereSQL()
        {
            strImpID = License.GetTreeNodeID(treeView1);
            StringBuilder strSQL = new StringBuilder(string.Format(" WHERE ImpModel.ImpID IN ({0}) ", strImpID));

            if (comboDepart.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DepID = " + comboDepart.SelectedValue);
            if (comboPerson.SelectedIndex >= 0)
                strSQL.Append(" AND ImpModel.PersonID = " + comboPerson.SelectedValue);
           
                if (comboUser.SelectedIndex > 0)
                    strSQL.Append(" AND ImpModel.UserID = " + comboUser.SelectedValue);
            
            if (checkedListABC.CheckedItems.Count == 1 || checkedListABC.CheckedItems.Count == 2)
            {
                strSQL.Append(" AND (");
                foreach (object obj in checkedListABC.CheckedItems)
                {
                    strSQL.Append(" ABCRange = '" + obj.ToString() + "' OR");
                }
                strSQL.Remove(strSQL.Length - 3, 3);
                strSQL.Append(")");
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

            if (comboDetectType.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DetTypeID = " + comboDetectType.SelectedValue);
            if (textImpNum.Text.Trim() != string.Empty)
            {
                strSQL.Append(" AND ImpNumber LIKE '" + textImpNum.Text.Trim() + "%'");
            }
            if (tabControl1.SelectedIndex == 1)
            {
                strSQL.Append(" AND (NextDetectTime >= '" + dateFrom.Value.ToString() + "' AND NextDetectTime < '" + dateTo.Value.ToString() + "') ");
                strSpan = dateFrom.Value.ToString(License.strSpanFormat);
            }
            else if (ListDetectTime.CheckedIndices.Count != 0)
            {
                strSQL.Append(" AND (");
                if (ListDetectTime.CheckedIndices.Contains(0)) // last mouth
                {
                    strSQL.Append(" NextDetectTime < '" + License.strStartOfMonth + "' OR");
                    strSpan = License.strLastMonth;
                }
                if (ListDetectTime.CheckedIndices.Contains(1)) // this mouth
                {
                    strSQL.Append(" convert(nchar(7),NextDetectTime,23) = '" + License.strThisMonth + "' OR");
                    strSpan = License.strThisMonth;
                }
                if (ListDetectTime.CheckedIndices.Contains(2)) // next mouth
                {
                    strSQL.Append(" convert(nchar(7),NextDetectTime,23) = '" + License.strNextMonth + "' OR");
                    strSpan = License.strNextMonth;
                }
                strSQL.Remove(strSQL.Length - 3, 3);
                strSQL.Append(")");
            }
            strWhere = strSQL.ToString();
            return strWhere;
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



            DataTable dtCom3 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLUser;
            adapterCom.Fill(dtCom3);
            comboUser.DisplayMember = "UserName";
            comboUser.ValueMember = "UserID";
            comboUser.DataSource = dtCom3;
            if (IMode == 0) //detect 
                comboUser.SelectedValue = License.UserID;
            else
                comboUser.SelectedIndex = -1;

            DataTable dtCom4 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLState;
            adapterCom.Fill(dtCom4);

            listState.DisplayMember = "CurStateName";
            listState.ValueMember = "CurStateID";
            listState.DataSource = dtCom4;
            listState.ClearSelected();
            listState.SetSelected(2, true);
            listState.SetSelected(3, true);
            listState.SetSelected(4, true);
            listState.SetSelected(9, true);
            listState.SetSelected(11, true);
            if (IMode < 2)
            {
                DataTable dtCom14 = new DataTable();
                adapterCom.Fill(dtCom14);
                CurStateName.DisplayMember = "CurStateName";
                CurStateName.ValueMember = "CurStateID";
                CurStateName.DataSource = dtCom14;             

                DataTable dtCom5 = new DataTable();
                adapterCom.SelectCommand.CommandText = strSQLDetResult;
                adapterCom.Fill(dtCom5);
                DetResultName.DisplayMember = "DetResultName";
                DetResultName.ValueMember = "DetResultID";
                DetResultName.DataSource = dtCom5;

                adapterCom.SelectCommand.CommandText = strSQLPerson;
                DataTable dtCom6 = new DataTable();
                adapterCom.Fill(dtCom6);
                comboPerson.DataSource = dtCom6;
                comboPerson.SelectedIndex = -1;

                checkedListABC.SetItemChecked(0, true);
                checkedListABC.SetItemChecked(1, true);
                checkedListABC.SetItemChecked(2, true);

                ListDetectTime.SetItemChecked(0, true);
                ListDetectTime.SetItemChecked(1, true);

                dateFrom.Value = License.StartOfMonth;
                dateTo.Value = License.EndOfMonth;
            }
            else
            {
                MonthPicker.Value = License.StartOfMonth;
            }

            DataTable dtCom2 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetType;
            adapterCom.Fill(dtCom2);
            comboDetectType.DisplayMember = "DetTypeName";
            comboDetectType.ValueMember = "DetTypeID";
            comboDetectType.DataSource = dtCom2;
            comboDetectType.SelectedIndex = -1;            
        }

        private void DetectForm_Resize(object sender, EventArgs e)
        {
            splitContainer1.Width = Width - 16;
            splitContainer1.Height = Height - 40;
            treeView1.Height = splitContainer1.Height;
            groupBox1.Width = splitContainer1.Panel2.Width;
            dataGridView1.Width = groupBox1.Width;
            dataGridView1.Height = splitContainer1.Height - 77;
          
        }

        private void DetectForm_FormClosing(object sender, FormClosingEventArgs e)
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
      
        private string BuildStatSQL()
        {
            strImpID = License.GetTreeNodeID(treeView1);
            StringBuilder strSQL = new StringBuilder(string.Format(" WHERE ImpModel.ImpID IN ({0}) ", strImpID));

            if (comboDepart.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.DepID = " + comboDepart.SelectedValue);
            if (comboDetectType.SelectedIndex > 0)
                strSQL.Append(" AND DetTypeID = " + comboDetectType.SelectedValue);
            if (comboUser.SelectedIndex > 0)
                strSQL.Append(" AND ImpModel.UserID = " + comboUser.SelectedValue);

            strSpan = MonthPicker.Text;

            OleDbCommand command = new OleDbCommand(string.Format(strSQLAlterViewByModel, strSpan, strSQL.ToString(),chkByModel.Checked? ",Model":""), conn);
            command.ExecuteNonQuery(); //alter view 
        
            StringBuilder strPivot = new StringBuilder();            
            for (int i = 2; i < listState.Items.Count; i++)//form 2
            {
                DataRowView dr = (DataRowView)listState.Items[i];
                strPivot.Append(" ,["+dr["CurStateID"]+"] AS "+dr["CurStateName"]);                                
            }
            //strPivot.Remove(strPivot.Length - 1, 1);
            return string.Format(chkByModel.Checked ?strSQLDetectStatByModel:strSQLDetectStat, strPivot);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {          
            dt.Clear();
            if (IMode == 2)
            {
                ModelS.Visible = chkByModel.Checked;
                adapter.SelectCommand.CommandText = BuildStatSQL();
                adapter.Fill(dt);
            }
            else
            {
                adapter.SelectCommand.CommandText = strSQLImpModel + BuildWhereSQL() +
                    (License.DataBaseName == "JLMIS_XT" ? strOrderImpModel2 : strOrderImpModel);
                adapter.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ModID"] };
            }
            dataGridView1.DataSource = dt;
            lblCount.Text = dt.Rows.Count.ToString();          
        }

        
        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            if (MessageBox.Show("你确定要批量检定录入吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {                
                OleDbCommand command2 = new OleDbCommand(strSQLInsertHistory + strWhere, conn);
                command2.ExecuteNonQuery();
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    int state = (int)dt.Rows[i]["CurrentState"];
                    command2.CommandText = string.Format(strSQLImpUpdate, dt.Rows[i]["ModID"], dt.Rows[i]["DetResultID"], state == 2 ? 1 : state, dt.Rows[i]["NextDetectTime"], dt.Rows[i]["size"].ToString().Replace("'", "''"),dt.Rows[i]["Comment"].ToString().Replace("'", "''"));
                    command2.ExecuteNonQuery();
                }
                dt.Clear();
                dataGridView1.DataSource = dt;
                lblCount.Text = dt.Rows.Count.ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            PrintForm printform = new PrintForm();
            if (IMode == 2)
            {
                printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportDetectStat.rdlc";
                printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DetectStats_DetectStats", dt));
                printform.reportViewer1.LocalReport.SetParameters(new ReportParameter("ShowModel", chkByModel.Checked.ToString()));
            }
            else
            {
                printform.reportViewer1.LocalReport.ReportPath = "Print\\" + License.DataBaseName.Substring(6) + "\\ReportDetect.rdlc";
                printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportDetect_ReportDetect", dt));
                printform.reportViewer1.LocalReport.SetParameters(new ReportParameter("DetType", comboDetectType.SelectedIndex > 0 ? comboDetectType.Text : License.strAll));
            }
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName),
                new ReportParameter("ReportCode", License.ReportCode2),
                new ReportParameter("Span",strSpan+"月份"),
                new ReportParameter("DepName", comboDepart.SelectedIndex >0? comboDepart.Text: License.strAll),                
                new ReportParameter("UserName", comboUser.SelectedIndex >0 ?comboUser.Text:License.strAll),              
                new ReportParameter("Category",treeView1.SelectedNode.Text)
            });

            //this.AddOwnedForm(impform);
            printform.ShowDialog();
            if (IMode == 1 && MessageBox.Show("请确定是否已经成功打印周检通知单?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                OleDbCommand command2 = new OleDbCommand(strSQLPrintUpdate + strWhere, conn);
                command2.ExecuteNonQuery();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            treeView1.Width = splitContainer1.Panel1.Width;
            groupBox1.Width = splitContainer1.Panel2.Width;
            dataGridView1.Width = splitContainer1.Panel2.Width;         
        }

        
        
        private void SingleMenu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int intmodId = (int)dataGridView1.CurrentRow.Cells["ModID"].Value;
                OleDbCommand command2 = new OleDbCommand(strSQLInsertHistory + " Where ModID = " + intmodId.ToString(), conn);
                command2.ExecuteNonQuery();
                DataRow dr = dt.Rows.Find(intmodId);
                int state = (int)dr["CurrentState"];
                command2.CommandText = string.Format(strSQLImpUpdate, intmodId, dr["DetResultID"], state == 2 ? 1 : state, dr["NextDetectTime"], dr["size"].ToString().Replace("'", "''"), dr["Comment"].ToString().Replace("'", "''"));
                command2.ExecuteNonQuery();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                dt.Rows.Remove(dr);
                lblCount.Text = dataGridView1.Rows.Count.ToString();
            }
        }

        private void DirectMenu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {              
                ImpForm impform = new ImpForm();
                impform.iEditMode = 0;               
               // impform.strImpID = strImpID;
                impform.iModID = (int)dataGridView1.CurrentRow.Cells["ModID"].Value;
                impform.conn = conn;
                this.AddOwnedForm(impform);
                impform.ShowDialog();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;
            if (IMode == 1)
            {
                DirectMenu_Click(sender, e);
            }
            else if (IMode == 0 && dataGridView1.Columns[e.ColumnIndex].Name == "NextDetectTime")
            {
                Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                dateTimePicker1.Top = rect.Top;
                dateTimePicker1.Left = rect.Left;
                dateTimePicker1.Height = rect.Height;
                dateTimePicker1.Width = rect.Width;
                dateTimePicker1.Text = dataGridView1.CurrentCell.Value.ToString();
                currentCell = dataGridView1.CurrentCell;
                dateTimePicker1.Visible = true;
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            currentCell.Value = dateTimePicker1.Text;
            dateTimePicker1.Visible = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dateTimePicker1.Visible = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (IMode != 2)
                License.SetGridColor(dataGridView1);
        }

        private void btnMonthReport_Click(object sender, EventArgs e)
        {
            strSpan = MonthPicker.Text;          
            OleDbCommand command = new OleDbCommand(string.Format(strSQLAlterMonthView, strSpan), conn);
            command.ExecuteNonQuery(); //alter view 
        
            StringBuilder strPivot = new StringBuilder();            
            for (int i = 2; i < listState.Items.Count; i++)//form 2
            {
                DataRowView dr = (DataRowView)listState.Items[i];
                strPivot.Append(dr["CurStateName"]);
                strPivot.Append(",");
            }
            strPivot.Remove(strPivot.Length - 1, 1);
            adapter.SelectCommand.CommandText = string.Format(strSQLMonthStat, strPivot);
            DataTable dtMonth = new DataTable();
            adapter.Fill(dtMonth);

            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportMonthStat.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DetectStats_DetectStats", dtMonth));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName),
                new ReportParameter("ReportCode", License.ReportCode2),
                new ReportParameter("Span",strSpan+"月份")
            });

            //this.AddOwnedForm(impform);
            printform.ShowDialog();

        }

        private void btnMonthPlan_Click(object sender, EventArgs e)
        {
            StringBuilder strPivot = new StringBuilder();
            StringBuilder strAmount = new StringBuilder();
            StringBuilder strColName = new StringBuilder();
            string ColName = string.Empty;
            for (int i = 1; i < comboDepart.Items.Count; i++)
            {
                DataRowView dr = (DataRowView)comboDepart.Items[i];
                ColName = "[" + dr["DepID"] +"]";
                strPivot.Append(ColName);//for new test DEpname    
                strPivot.Append(",");
                strAmount.Append(ColName);
                strAmount.Append("+");
                strColName.Append(ColName);
                strColName.Append(" AS DEP" + i + ",");
            }
            strPivot.Remove(strPivot.Length - 1, 1);
            strAmount.Remove(strAmount.Length - 1, 1);
            strColName.Remove(strColName.Length - 1, 1);            

            DataTable dtMonth = new DataTable();
            adapter.SelectCommand.CommandText = string.Format(strSQLMonthPlan,strAmount,strColName) + BuildWhereSQL() + string.Format(strSQLDepNamePivot, strPivot);
            adapter.Fill(dtMonth);
            PrintForm printform = new PrintForm();

            // printform.reportViewer1.LocalReport.ReportPath = "Print\\" + License.DataBaseName.Substring(6) + "\\ReportDepImpStat.rdlc";
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportMonthPlan.rdlc"; // for new test
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportStat_DepStats", dtMonth));

            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                { new ReportParameter("CompanyName", License.CompanyName),
                  new ReportParameter("ReportCode", License.ReportCode1),                               
                  new ReportParameter("Category",treeView1.SelectedNode.Text),
                  new ReportParameter("Span",strSpan+"月份"),
                  new ReportParameter("DepCount",(comboDepart.Items.Count-1).ToString()), //for new test
                  new ReportParameter("DetType",comboDetectType.SelectedIndex > 0 ? comboDetectType.Text : License.strAll)                  
                });            
            string strDepname = string.Empty;
            for (int j = 1; j <= 15; j++) //for new test
            {
                if (j < comboDepart.Items.Count)
                    strDepname = ((DataRowView)comboDepart.Items[j])["DepName"].ToString();
                else
                    strDepname = string.Empty;
                printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                { new ReportParameter("DEP" + j.ToString(), strDepname) });
            }
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

        private void btnYearPlan_Click(object sender, EventArgs e)
        {
            int strYear = License.StartOfMonth.Year;
            OleDbConnection conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(strYearPlanSQL + strYear, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                OleDbCommand command = new OleDbCommand(string.Format(strYearPlanInsert, strYear), conn);
                command.ExecuteNonQuery();
                OleDbCommandBuilder cb;
                cb = new OleDbCommandBuilder(adapter);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int k = (int)dt.Rows[i]["DetectIntervalValue"];
                    if (k <= 6)
                    {
                        for (int j = 1 + k; j <= 12; j++)
                        {
                            dt.Rows[i][j + 6] = (int)dt.Rows[i][j + 6] + (int)dt.Rows[i][j - k + 6];//offset 6 for col index
                        }
                    }
                }
                adapter.Update(dt);
            }
            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportYearPlan.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportStat_YearStats", dt));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName),
                new ReportParameter("ReportCode", License.ReportCode1),
                new ReportParameter("Span", strYear.ToString())
            });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

        private void btnYearStat_Click(object sender, EventArgs e)
        {
            strImpID = License.GetTreeNodeID(treeView1);
            StringBuilder strSQLHis = new StringBuilder(string.Format(" AND ImpModel.ImpID IN ({0}) ", strImpID));
            StringBuilder strSQLYear = new StringBuilder(string.Format(" AND ImpID IN ({0}) ", strImpID));
            if (comboDepart.SelectedIndex > 0)
            {
                strSQLHis.Append(" AND ImpModel.DepID = " + comboDepart.SelectedValue);
                strSQLYear.Append(" AND DepName = '" + comboDepart.Text +"'");
            }
            if (comboDetectType.SelectedIndex > 0)
            {
                strSQLHis.Append(" AND DetTypeID = " + comboDetectType.SelectedValue);
                strSQLYear.Append(" AND ImpID IN ( SELECT Distinct ImpID From ImpModel Where DetTypeID =" + comboDetectType.SelectedValue + ")");               
            }
          //  if (comboUser.SelectedIndex > 0)
            //    strSQL.Append(" AND UserID = " + comboUser.SelectedValue);



            int strYear = License.StartOfMonth.Year;
            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Format(strYearStat, strYear,strSQLYear,strSQLHis), License.strConnSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportYearStat.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportStat_YearStats", dt));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName),
                new ReportParameter("ReportCode", License.ReportCode1),
                new ReportParameter("Span", strYear.ToString())
            });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }
      
    }
}
