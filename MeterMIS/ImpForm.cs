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
    public partial class ImpForm : Form
    {
        public int iEditMode = 0; //0  Readonly, 1   Edit , 2, New.  3, back use  
        public string strImpID = string.Empty;
        public int iModID = 0;
        public const string sNull = "null";        
        
        public OleDbConnection conn;             
       
        private string strSQLMeaRange = "SELECT * FROM DicValue WHERE ValueType = '测量范围' ORDER BY ValueID";
        private string strSQLAccuracy = "SELECT * FROM DicValue WHERE ValueType = '准确度' ORDER BY ValueID";
        private string strSQLDivision = "SELECT * FROM DicValue WHERE ValueType = '分度值' ORDER BY ValueID";
        private string strSQLDetectInterval = "SELECT * FROM DetectIntervalTable ORDER BY DetectIntervalValue";
        private string strSQLDetectResult = "SELECT * FROM DetectResult ORDER BY DetResultID";
        private string strSQLDetectPlace = "SELECT * FROM DetectPlace ORDER BY DetectPlaceID";
        private string strSQLDetectType = "SELECT * FROM DetectType ORDER BY DetTypeID";
        private string strSQLImp = "SELECT  * FROM  Implements Order by ImpName";

        private string strSQLDepartment = "SELECT  * FROM  Departments Order by DepID";
        private string strSQLPerson = "SELECT  * FROM  Persons  Order by PersonName";
        private string strSQLSupplier = "SELECT  * FROM  Suppliers Order by SupName ";
        private string strSQLUser = "SELECT  * FROM  Users WHERE roleID = 1 Order by UserID";
        private string strSQLState = "SELECT  * FROM  CurrentState Order by CurStateID";
        private string strSQLImpHistory = @"Select CONVERT(varchar(10),LastDetectTime, 23) AS LastDetectTime,
               DetResultName,CurStateName,DepName,PersonName,UserName from DetectHistory INNER JOIN               
               DetectResult ON DetectHistory.DetResultID = DetectResult.DetResultID INNER JOIN                              
               CurrentState ON DetectHistory.StateID = CurrentState.CurStateID INNER JOIN              
               Persons ON DetectHistory.PersonID = Persons.PersonID INNER JOIN
               Departments ON DetectHistory.DepID = Departments.DepID INNER JOIN
               Users ON DetectHistory.UserID = Users.UserID 
               Where ModID = {0}";

        private string strSQLUpdateCheck = "Update impmodel set printed = printed where impnumber = '{0}'";
        private string strSQLInsertPerson = "Insert into Persons (PersonName) VALUES ('{0}')";
        private string strSQLInsertHistory = "Insert into DetectHistory select ModID,ImpID,LastDetectTime,DetResultID,currentstate as stateID,DepID,PersonID,UserID from ImpModel Where ModID = {0}";
        private string strSQLImpModel = "Select * from ImpModel Where ImpModel.ModID = {0} ";
        private string strSQLImpUpdate = @"Update ImpModel Set ImpID = {0},ImpNumber = '{1}', Model = '{2}',FactoryNumber = '{3}',SupplierID = {4},
                MeasuringRange='{5}',AccuracyClass='{6}',DivisionValue='{7}',[Size]='{8}',
                UseTime = '{9}',LastDetectTime='{10}',DetectIntervalValue = {11},NextDetectTime = {12},
                DetectPlaceID = {13},DetTypeID = {14},DetResultID= {15}, CurrentState = {16},
                PersonID = {17},UsePlace = '{18}',DepID = {19},UserID = {20},
                ABCRange = '{21}',Comment = '{22}' Where ImpModel.ModID = ";
        private string strSQLImpInsert = @"Insert Into ImpModel (ImpID,ImpNumber,Model,FactoryNumber,SupplierID,
                MeasuringRange,AccuracyClass,DivisionValue,[Size],
                UseTime,LastDetectTime,DetectIntervalValue,NextDetectTime,
                DetectPlaceID,DetTypeID,DetResultID, CurrentState,
                PersonID,UsePlace,DepID,UserID,
                ABCRange,Comment) Values({0},'{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}',
                '{9}','{10}',{11},{12},{13},{14},{15},{16},{17},'{18}',{19},{20},'{21}','{22}')";

        public ImpForm()
        {
            InitializeComponent();
        }
        private void FillCombobox()
        {
            OleDbDataAdapter adapterCom = new OleDbDataAdapter(strSQLMeaRange, conn);
            DataTable dtCom = new DataTable();
            adapterCom.Fill(dtCom);
            comboMeaRange.DisplayMember = "ValueText";   
            comboMeaRange.DataSource = dtCom;                   
           // comboMeaRange.SelectedIndex = -1;

            DataTable dtCom3 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLAccuracy;
            adapterCom.Fill(dtCom3);
            comboAccuracy.DisplayMember = "ValueText";           
            comboAccuracy.DataSource = dtCom3;
            
            DataTable dtCom4 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDivision;
            adapterCom.Fill(dtCom4);
            comboDivision.DisplayMember = "ValueText";
            comboDivision.DataSource = dtCom4;
            
            DataTable dtCom5 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetectInterval;
            adapterCom.Fill(dtCom5);
            comboDetInterval.DisplayMember = "DetectIntervalName";
            comboDetInterval.ValueMember = "DetectIntervalValue";
            comboDetInterval.DataSource = dtCom5;
           
            DataTable dtCom6 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetectPlace;
            adapterCom.Fill(dtCom6);
            comboDetPlace.DisplayMember = "DetectPlaceName";
            comboDetPlace.ValueMember = "DetectPlaceID";
            comboDetPlace.DataSource = dtCom6;
            
            DataTable dtCom7 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetectResult;
            adapterCom.Fill(dtCom7);
            comboDetResult.DisplayMember = "DetResultName";
            comboDetResult.ValueMember = "DetResultID";
            comboDetResult.DataSource = dtCom7;

            DataTable dtCom8 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDetectType;
            adapterCom.Fill(dtCom8);
            comboDetType.DisplayMember = "DetTypeName";
            comboDetType.ValueMember = "DetTypeID";
            comboDetType.DataSource = dtCom8;

            DataTable dtCom9 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLUser;
            adapterCom.Fill(dtCom9);
            comboUser.DisplayMember = "UserName";
            comboUser.ValueMember = "UserID";
            comboUser.DataSource = dtCom9;
           
          //  comboUser.SelectedIndex = -1;

            DataTable dtCom10 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLDepartment;
            adapterCom.Fill(dtCom10);
            comboDepart.DisplayMember = "DepName";
            comboDepart.ValueMember = "DepID";           
            comboDepart.DataSource = dtCom10;
                        

            DataTable dtCom11 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLState;
            adapterCom.Fill(dtCom11);
            comboState.DisplayMember = "CurStateName";
            comboState.ValueMember = "CurStateID";  
            comboState.DataSource = dtCom11;

            DataTable dtCom12 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLPerson;
            adapterCom.Fill(dtCom12);
            comboPerson.DataSource = dtCom12;            

            DataTable dtCom13 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLSupplier;
            adapterCom.Fill(dtCom13);
            comboFactory.DataSource = dtCom13;

            DataTable dtCom14 = new DataTable();
            adapterCom.SelectCommand.CommandText = strSQLImp;
            adapterCom.Fill(dtCom14);
            comboImp.DisplayMember = "ImpName";
            comboImp.ValueMember = "ImpID";
            comboImp.DataSource = dtCom14;

            if (iEditMode == 0)
            {
                DataTable dt = new DataTable();
                adapterCom.SelectCommand.CommandText = string.Format(strSQLImpHistory, iModID);
                adapterCom.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }       
        private void ImpForm_Load(object sender, EventArgs e)
        {           
           // groupBox1.Text  = strImpName;
            string strMode = string.Empty;
            if (License.RoleID == 0)
                comboState.Enabled = true;
            switch (iEditMode)
            {
                case 0: strMode = "-查看";
                    btnSave.Visible = false;                                
                    groupBox1.Enabled = false;
                    btnPrint.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView1.AutoGenerateColumns = false;
                    label23.Visible = true;
                    Height = 600;
                    break;
                case 1: strMode = "-修改";                                  
                    break;                
                case 2: strMode = "-新增";
                    btnClear.Visible = true;
                    btnNew.Visible = true;
                    break;
                case 3: strMode = "-启用";
                    break;
            }
            this.Text += strMode;
            
            FillCombobox();

            if (iModID == 0)
            {
                ClearControl();
                return;
            }

            OleDbCommand command = new OleDbCommand(string.Format(strSQLImpModel,iModID), conn);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textImpNum.Text = reader["ImpNumber"].ToString();
                textModel.Text = reader["Model"].ToString();
                comboFactory.SelectedValue = reader["SupplierID"];
                textFactNum.Text = reader["FactoryNumber"].ToString();
                comboMeaRange.Text = reader["MeasuringRange"].ToString();
                comboAccuracy.Text = reader["AccuracyClass"].ToString();
                comboDivision.Text = reader["DivisionValue"].ToString();
                textSize.Text = reader["size"].ToString();
                if (iEditMode == 2 && License.DataBaseName.IndexOf("JLMIS_XT") == -1) //new 
                {
                    dateUseDate.Value = DateTime.Now.Date;
                    dateLastDate.Value = DateTime.Now.Date;
                    comboState.SelectedValue = 2;
                }
                else
                {

                    dateUseDate.Value = (DateTime)reader["UseTime"];
                    dateLastDate.Value = (DateTime)reader["LastDetectTime"];
                    if (iEditMode == 3)
                        comboState.SelectedValue = 1;
                    else
                        comboState.SelectedValue = reader["CurrentState"];
                }
                comboDetInterval.SelectedValue = reader["DetectIntervalValue"];
                if ((int)comboDetInterval.SelectedValue == 0)
                    dateNextDate.Visible = false;
                else
                    dateNextDate.Value = (DateTime)reader["NextDetectTime"];

                comboDetPlace.SelectedValue = reader["DetectPlaceID"];
                comboDetResult.SelectedValue = reader["DetResultID"];
                comboDetType.SelectedValue = reader["DetTypeID"];
                comboUser.SelectedValue = reader["UserID"];
                comboPerson.SelectedValue = reader["PersonID"];
                textUsePlace.Text = reader["UsePlace"].ToString();
                comboDepart.SelectedValue = reader["DepID"];
                comboImp.SelectedValue = reader["ImpID"];
                comboABC.Text = reader["ABCRange"].ToString();
                textComment.Text = reader["Comment"].ToString();
            }
            reader.Close();       
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();           
        }
        private void ClearControl()
        {
            textImpNum.Text = string.Empty;
            textModel.Text = string.Empty;
            comboFactory.SelectedIndex = -1;
            textFactNum.Text = string.Empty;
            comboMeaRange.Text = string.Empty;
            comboAccuracy.Text = string.Empty;
            comboDivision.Text = string.Empty;
            textSize.Text = string.Empty;
            dateUseDate.Value = DateTime.Now.Date;
            dateLastDate.Value = DateTime.Now.Date;
            comboDetInterval.SelectedIndex = 0;
            dateNextDate.Visible = false;

            comboDetPlace.SelectedIndex = 0;
            comboDetResult.SelectedIndex = 0;
            comboDetType.SelectedIndex = 0;
            comboUser.SelectedIndex = 0;
            comboPerson.SelectedIndex = -1;
            textUsePlace.Text = string.Empty;
            comboDepart.SelectedIndex = 0;
            comboState.SelectedValue = 2;
            comboABC.SelectedIndex = 1;
            textComment.Text = string.Empty;
            int intImpID;
            if (int.TryParse(strImpID, out intImpID))
                comboImp.SelectedValue = intImpID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                if (iEditMode == 1 || iEditMode == 3) 
                    UpdateRecord(strSQLImpUpdate + iModID.ToString());
                else
                    UpdateRecord(strSQLImpInsert);

                GC.Collect();
                this.Close();
            }
        }
        private void UpdateRecord(string strSQL)
        {
            if (iEditMode == 3)
            {
                OleDbCommand command2 = new OleDbCommand(string.Format(strSQLInsertHistory, iModID), conn);
                command2.ExecuteNonQuery();
                ((ExceptForm)this.Owner).IsDirty = true;
            }
            else
                ((ListForm)this.Owner).IsDirty = true;
            string strUpdate = string.Format(strSQL, comboImp.SelectedValue, textImpNum.Text, textModel.Text.Replace("'","''"), textFactNum.Text, comboFactory.SelectedValue,
                   comboMeaRange.Text.Replace("'", "''"), comboAccuracy.Text.Replace("'", "''"), comboDivision.Text.Replace("'", "''"), textSize.Text.Replace("'", "''"),
                   dateUseDate.Value, dateLastDate.Value, comboDetInterval.SelectedValue, ((int)comboDetInterval.SelectedValue == 0 ? sNull : "'" + dateNextDate.Value + "'"),
                   comboDetPlace.SelectedValue, comboDetType.SelectedValue, comboDetResult.SelectedValue, comboState.SelectedValue,
                   comboPerson.SelectedValue, textUsePlace.Text, comboDepart.SelectedValue, comboUser.SelectedValue,
                   comboABC.Text, textComment.Text.Replace("'", "''"));
            OleDbCommand command1 = new OleDbCommand(strUpdate, conn);
            command1.ExecuteNonQuery();            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void comboDetInterval_TextChanged(object sender, EventArgs e)
        {
            int Interval = (int)comboDetInterval.SelectedValue;
            if (Interval == 0)
            {
                dateNextDate.Visible = false;
                comboState.SelectedValue  = 1;                
            }
            else
            {
                dateNextDate.Visible = true;
                dateNextDate.Value = dateLastDate.Value.AddMonths(Interval);
            }
        }

        private void dateLastDate_ValueChanged(object sender, EventArgs e)
        {
            int Interval = (int)comboDetInterval.SelectedValue;
            if (Interval != 0)
            {
                dateNextDate.Value = dateLastDate.Value.AddMonths(Interval);
            }
        }
        private bool CheckControl()
        {
            string strName = comboPerson.Text.Trim();                     
            if (comboPerson.SelectedIndex == -1 && strName != string.Empty)
            {
                if (MessageBox.Show("请确认是否要添加新的使用者(" + strName + ")?", "保存记录", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strSQLInsertPerson, strName), conn);
                    command2.ExecuteNonQuery();
                    OleDbDataAdapter adapterCom = new OleDbDataAdapter(strSQLPerson, conn);
                    DataTable dtCom = new DataTable();
                    adapterCom.Fill(dtCom);
                    comboPerson.DataSource = dtCom;
                    comboPerson.Text = strName;         
                }
                else return false;
            }
            if (comboImp.SelectedIndex == -1 || textImpNum.Text.Trim() == string.Empty || comboFactory.SelectedIndex == -1 || comboPerson.SelectedIndex == -1)
            {
                MessageBox.Show("量具名称,计量编号,生产厂家,使用者不得为空!", "保存记录", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (iEditMode == 2)
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strSQLUpdateCheck, textImpNum.Text.Trim()), conn);
                    int intcount = command2.ExecuteNonQuery();
                    if(intcount > 0)
                    {
                        return (MessageBox.Show("数据库中已经存在" + intcount + "条相同计量编号的量具,请确认是否要添加新的量具?", "保存记录", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK);
                    }
                }
                return true;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                UpdateRecord(strSQLImpInsert); 
                MessageBox.Show("新增记录保存成功!","保存记录",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportImpHistory.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportDetect_ReportDetect", dataGridView1.DataSource));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                {           
                    new ReportParameter("CompanyName", License.CompanyName),
                    new ReportParameter("ReportCode", License.ReportCode1),                                                
                    new ReportParameter("ImpName", comboImp.Text),                                                
                    new ReportParameter("ImpNumber", textImpNum.Text),
                    new ReportParameter("Model", textModel.Text),
                    new ReportParameter("SupplierName", comboFactory.Text),
                    new ReportParameter("FactoryNumber", textFactNum.Text),
                    new ReportParameter("MeasuringRange", comboMeaRange.Text),
                    new ReportParameter("DivisionValue", comboDivision.Text),
                    new ReportParameter("AccuracyClass", comboAccuracy.Text),
                    new ReportParameter("Size",textSize.Text),
                    new ReportParameter("UseTime",dateUseDate.Text),
                    new ReportParameter("LastDetectTime",dateLastDate.Text),
                    new ReportParameter("DetectIntervalName",comboDetInterval.Text),
                    new ReportParameter("NextDetectTime",dateNextDate.Visible ? dateNextDate.Text:string.Empty),
                    new ReportParameter("DetectPlaceName",comboDetPlace.Text),
                    new ReportParameter("DetTypeName",comboDetType.Text),
                    new ReportParameter("DetResultName",comboDetResult.Text),
                    new ReportParameter("PersonName", comboPerson.Text),                
                    new ReportParameter("UsePlace", textUsePlace.Text),                
                    new ReportParameter("CurStateName", comboState.Text),                
                    new ReportParameter("DepName", comboDepart.Text),                
                    new ReportParameter("UserName", comboUser.Text),
                    new ReportParameter("ABCRange", comboABC.Text),
                    new ReportParameter("Comment", textComment.Text)

                });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

       
    }
}
