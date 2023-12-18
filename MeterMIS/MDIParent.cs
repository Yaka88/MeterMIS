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
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        private const string strImpStat = @"select impName,Model,count(impName) as ImpCount from impmodel INNER JOIN 
                                Implements ON ImpModel.ImpID = Implements.ImpID
                               group by ImpModel.ImpID,Implements.impName,model order by ImpModel.ImpID,model";
        private const string strImpStockStat = @"select ROW_NUMBER() OVER (ORDER BY impmodel.impID) AS [index],
                                ImpDef,impName,count(impName) as quantity from impmodel INNER JOIN 
                                Implements ON ImpModel.ImpID = Implements.ImpID
                                Where CurrentState = 1 OR CurrentState = 2 
                                group by impmodel.impID,Implements.ImpDef,Implements.impName";
    
       

        private const string strBackUP = "BACKUP DATABASE [{0}] TO DISK='{1}.Bak' WITH INIT,PASSWORD = 'bl2160635'";
      
        public MDIParent()
        {
            InitializeComponent();
        }

       
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
      

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void DetectMenuItem_Click(object sender, EventArgs e)
        {
            DetectForm detForm = new DetectForm();
            detForm.MdiParent = this;
            childFormNumber++;
            detForm.IMode = 0;
            detForm.Show();
            detForm.WindowState = FormWindowState.Maximized;
        }

        private void ListMenuItem_Click(object sender, EventArgs e)
        {
            ListForm listImpForm = new ListForm();
            listImpForm.MdiParent = this;
            childFormNumber++;
            listImpForm.Show();
            listImpForm.WindowState = FormWindowState.Maximized;
        }

        private void printMenuItem_Click(object sender, EventArgs e)
        {
            DetectForm printForm = new DetectForm();
            printForm.MdiParent = this;
            childFormNumber++;
            printForm.IMode = 1;
            printForm.Text = printMenuItem.Text;
            printForm.Show();
            printForm.WindowState = FormWindowState.Maximized;            
        }

        private void ImpPrintMenuItem_Click(object sender, EventArgs e)
        {
            ListForm ImpPrintForm = new ListForm();
            ImpPrintForm.MdiParent = this;
            childFormNumber++;            
            ImpPrintForm.IMode = 1; //print
            ImpPrintForm.Text = ImpPrintMenuItem.Text;
            ImpPrintForm.Show();
            ImpPrintForm.WindowState = FormWindowState.Maximized;
        }

        private void BatchMenuItem_Click(object sender, EventArgs e)
        {
            BatchForm batchForm = new BatchForm();
            batchForm.MdiParent = this;
            childFormNumber++;
            batchForm.Show();
            batchForm.WindowState = FormWindowState.Maximized;
        }

        private void ExceptMenuItem_Click(object sender, EventArgs e)
        {
            ExceptForm exceptForm = new ExceptForm();
            exceptForm.MdiParent = this;
            childFormNumber++;
            exceptForm.Show();
            exceptForm.WindowState = FormWindowState.Maximized;
        }
        private void ShowLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);           
            DetectMenuItem.Visible = (License.RoleID != 2);
            SpecMenu.Visible = (License.RoleID != 2);
            StatMenu.Visible = License.RoleID == 0;
            DataMenuItem.Visible = License.RoleID == 0;
            if (License.RoleID == 0 && License.dtExpireDate > DateTime.Now)
            {
                MenuItemYearPlan.Visible = true;              
            }
        }
        private void MDIParent_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void MDIParent_Shown(object sender, EventArgs e)
        {
            PanelMenuItem_Click(sender, e);
        }

        private void PanelMenuItem_Click(object sender, EventArgs e)
        {
            if (License.RoleID != 2)
            {
                TipsForm tipForm = new TipsForm();
                tipForm.MdiParent = this;
                childFormNumber++;
                tipForm.Show();
            }
        }

        private void LoginMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllToolStripMenuItem_Click(sender, e);
            ShowLogin();
            PanelMenuItem_Click(sender, e);
        }
        
        private void ImpStatMenuItem_Click(object sender, EventArgs e)
        {           
            OleDbDataAdapter adapter = new OleDbDataAdapter(strImpStat, License.strConnSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportImpStat.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportStat_Stat", dt));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName),
              new ReportParameter("ReportCode", License.ReportCode2)
            });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

        private void DetectStatMenuItem_Click(object sender, EventArgs e)
        {
            DetectForm DetStatForm = new DetectForm();
            DetStatForm.MdiParent = this;
            childFormNumber++;
            DetStatForm.IMode = 2; //stat
            DetStatForm.Text = DetectStatMenuItem.Text;
            DetStatForm.Show();
            DetStatForm.WindowState = FormWindowState.Maximized;
        }    

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void StockStatMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(strImpStockStat, License.strConnSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            PrintForm printform = new PrintForm();
            printform.reportViewer1.LocalReport.ReportPath = "Print\\ReportStockStat.rdlc";
            printform.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportStat_StoreStats", dt));
            printform.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            { new ReportParameter("CompanyName", License.CompanyName)          
            });
            //this.AddOwnedForm(impform);
            printform.ShowDialog();
        }

        private void ChangePassMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm pass = new PasswordForm();
            pass.ShowDialog();
        }

        private void BackupMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            OleDbCommand command = new OleDbCommand(string.Format(strBackUP , License.DataBaseName ,DateTime.Today.ToShortDateString()), conn);
            command.ExecuteNonQuery(); //backup 
            conn.Close();
            MessageBox.Show("数据库备份成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void basicDataMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllToolStripMenuItem_Click(sender, e);
            BasicDataForm dataForm = new BasicDataForm();
            dataForm.ShowDialog();
        }    

  /*      private void MenuItemYearStat2(object sender, EventArgs e)
        {
            int strYear = License.StartOfMonth.Year - 1;            
            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Format("strYearStat",strYear), License.strConnSQL);
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
        */
        private void MenuItemYearPlan_Click(object sender, EventArgs e)
        {
            DetectForm DetStatForm = new DetectForm();
            DetStatForm.MdiParent = this;
            childFormNumber++;
            DetStatForm.IMode = 3; //yearplan
            DetStatForm.Text = MenuItemYearPlan.Text;
            DetStatForm.Show();
            DetStatForm.WindowState = FormWindowState.Maximized;
        }       
    }
    public class License
    {
         private static string strBaseDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
         public static string BaseDirectory = strBaseDirectory.Substring(0, strBaseDirectory.LastIndexOf('\\') + 1);
        //   private const string strConnFormat = "Provider=Microsoft.JET.OLEDB.4.0;Jet OLEDB:Database Password={0};Data Source=|DataDirectory|\\BlueStar.ydb";
        private static string strConn = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + BaseDirectory +"Meter.ydb;Jet OLEDB:Database Password=";
        public static string strConnSQL = "Provider=SQLOLEDB;Data Source={0},1433;Initial Catalog={1};User ID=Meter;Password={2}";
        public static string CompanyName;
        public static string ReportCode1;
        public static string ReportCode2;
        public static string DataBaseName;
        public static int UserID;
        public static int RoleID;
        public static string UserName;

        public const string strAll = "所有";
        public static string strStartOfMonth, strEndOfMonth, strEndLine;
        public static string strThisMonth, strNextMonth, strLastMonth;
        public static DateTime dtEndline,dtExpireDate, StartOfMonth, EndOfMonth;

        private const string strSQLCategory1 = "SELECT  * FROM  Category1 ORDER BY C1Def";
        private const string strSQLCategory2 = "SELECT  * FROM  Category2 WHERE c1id =";
        private const string strSQLCategory3 = "SELECT  * FROM  Category3 WHERE c2id =";
        private const string strSQLImp = "SELECT  * FROM  Implements WHERE c3id ={0} ORDER BY ImpDef";
        private const string strSQL = "SELECT * FROM ServerInfo WHERE Used = Yes";
        private const string strDateFormat = "yyyyMMdd";
        public const string strSpanFormat = "yyyy-MM";
        private const string strPassword = "bl2160635";
        private bool bIsValid = false;
        private static OleDbConnection connMdb = null;
        public static bool CheckLic()
        {
            string strServerCode;
            string strIP;
            int port;
            connMdb = new OleDbConnection(strConn + strPassword);
            connMdb.Open();
            OleDbCommand command = new OleDbCommand(strSQL, connMdb);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                strServerCode = reader["ServerCode"].ToString();
                strIP = reader["ServerIP"].ToString();
                port = (int)reader["ServerPort"];
                DataBaseName = reader["SQLDatabase"].ToString();
                CompanyName = reader["CompanyName"].ToString();
                ReportCode1 = reader["ReportCode1"].ToString();
                ReportCode2 = reader["ReportCode2"].ToString();
                dtExpireDate = (DateTime)reader["InstallDate"];

                strConnSQL = string.Format(strConnSQL, strIP, DataBaseName, strPassword);
                reader.Close();
            }
            else
            {
                connMdb.Close();
                return false;
            }
            connMdb.Close();
            /*
            string strDate = DateTime.Now.ToString(strDateFormat);

            StringBuilder strMessage = new StringBuilder(strServerCode);
            strMessage.Append(strDate);
            MD5 md5 = MD5.Create();
            byte[] bytePass = md5.ComputeHash(Encoding.ASCII.GetBytes(strMessage.ToString()));
            byte[] data = Encoding.ASCII.GetBytes(strDate);
            try
            {
                TcpClient client = new TcpClient(strIP, port);
                // Translate the passed message into ASCII and store it as a Byte array.                
                NetworkStream stream = client.GetStream();
                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                data = new Byte[bytePass.Length];
                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (SocketException)
            {
                return false;
            }
            for (int i = 0; i < bytePass.Length; i++)
            {
                if (bytePass[i] != data[i])
                    return false;
            }*/
            return true;
        }
        public License()
        {
            bIsValid = CheckLic();
            if (bIsValid)
            {
                if (License.DataBaseName.IndexOf("JLMIS_JG") == -1)
                    dtEndline = DateTime.Today.AddDays(-7);
                else
                    dtEndline = DateTime.Today;
                strEndLine = dtEndline.ToString();
                StartOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                strThisMonth = DateTime.Today.ToString(strSpanFormat);
                strLastMonth = StartOfMonth.AddMonths(-1).ToString(strSpanFormat);
                strStartOfMonth = StartOfMonth.ToString();
                EndOfMonth = StartOfMonth.AddMonths(1);
                strNextMonth = EndOfMonth.ToString(strSpanFormat);
                strEndOfMonth = EndOfMonth.ToString();
             //   strEndOfNextMonth = StartOfMonth.AddMonths(2).ToString();
            }
        }
        public bool isValid
        {
            get { return bIsValid; }
        }
        public static void SetTreeView(TreeView treeView1,OleDbConnection conn )
        {
            treeView1.BeginUpdate();
            TreeNode nodeRoot = new TreeNode(strAll); //root
            treeView1.Nodes.Add(nodeRoot);
            OleDbCommand commandC2, commandC3, commandC4;
            OleDbCommand commandC1 = new OleDbCommand(strSQLCategory1, conn);
            OleDbDataReader readerC2, readerC3, readerC4;
            OleDbDataReader readerC1 = commandC1.ExecuteReader();
            while (readerC1.Read())
            {
                TreeNode nodeC1 = new TreeNode(readerC1["c1name"].ToString());
                nodeC1.Name = readerC1["c1id"].ToString();
                nodeRoot.Nodes.Add(nodeC1);

                commandC2 = new OleDbCommand(strSQLCategory2 + nodeC1.Name, conn);
                readerC2 = commandC2.ExecuteReader();
                while (readerC2.Read())
                {
                    TreeNode nodeC2 = new TreeNode(readerC2["c2name"].ToString());
                    nodeC2.Name = readerC2["c2id"].ToString();
                    nodeC1.Nodes.Add(nodeC2);
                    commandC3 = new OleDbCommand(strSQLCategory3 + nodeC2.Name, conn);
                    readerC3 = commandC3.ExecuteReader();
                    while (readerC3.Read())
                    {
                        TreeNode nodeC3 = new TreeNode(readerC3["c3name"].ToString());
                        nodeC3.Name = readerC3["c3id"].ToString();
                        nodeC2.Nodes.Add(nodeC3);                        
                        commandC4 = new OleDbCommand(string.Format(strSQLImp, nodeC3.Name), conn);
                        readerC4 = commandC4.ExecuteReader();
                        while (readerC4.Read())
                        {
                            TreeNode nodeC4 =  nodeC3.Nodes.Add(readerC4["ImpID"].ToString(), readerC4["ImpName"].ToString());
                            nodeC4.ToolTipText = readerC4["ImpDef"].ToString();
                        }
                        readerC4.Close();

                    }
                    readerC3.Close();
                }
                readerC2.Close();
                nodeC1.Expand();
            }
            readerC1.Close();
            nodeRoot.Expand();
            treeView1.EndUpdate();
        }
        public static void SetGridColor(DataGridView dataGridView1)
        {
            if (License.DataBaseName.IndexOf("JLMIS_XT") != -1)
                return;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string strDate = dataGridView1.Rows[i].Cells["NextDetectTime"].Value.ToString();
                if (strDate != string.Empty)
                {
                    DateTime date = DateTime.Parse(strDate);
                    if (License.DataBaseName.IndexOf("JLMIS_JG") == -1)
                    {
                        if (date <= dtEndline)
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        else if (date < EndOfMonth)
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        else
                        {
                            DateTime Lastdate = DateTime.Parse(dataGridView1.Rows[i].Cells["LastDetectTime"].Value.ToString());
                            if (Lastdate >= StartOfMonth && Lastdate < EndOfMonth)
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (date < EndOfMonth)
                        {
                            if ((bool)dataGridView1.Rows[i].Cells["Printed"].Value)
                            {
                                if (date < dtEndline)
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            else //not print
                            {
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        public static string GetTreeNodeID(TreeView treeView1)
        {
            string strImpID = string.Empty;
            switch (treeView1.SelectedNode.Level)
            {
                case 0:
                    strImpID = "SELECT ImpID FROM Implements";
                    break;
                case 1:
                    strImpID = @"SELECT ImpID FROM Implements AS Implements1 WHERE c3id IN                    
                   (SELECT  c3id FROM Category3 WHERE c2id IN                    
                   (SELECT  c2id FROM Category2 WHERE c1id = " + treeView1.SelectedNode.Name + "))";
                    break;
                case 2:
                    strImpID = @"SELECT ImpID FROM Implements AS Implements1 WHERE c3id IN                    
                   (SELECT  c3id FROM Category3 WHERE c2id = " + treeView1.SelectedNode.Name + ")";
                    break;
                case 3:
                    strImpID = "SELECT ImpID FROM Implements AS Implements1 WHERE c3id = " + treeView1.SelectedNode.Name;
                    break;
                case 4:
                    strImpID = treeView1.SelectedNode.Name;
                    break;
            }
            return strImpID;
        }
    }
}
