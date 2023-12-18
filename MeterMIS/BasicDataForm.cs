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
    public partial class BasicDataForm : Form
    {
        private OleDbDataAdapter adapter;
        private OleDbConnection conn;
        private DataTable dt;
        private OleDbCommandBuilder cb;
        private string[] strSQL = new string[8]
        {"SELECT PersonID,PersonName FROM Persons Order BY PersonName",
            "SELECT DepID,DepName FROM Departments ORDER BY DepID",
            "SELECT SupplierID,SupName FROM Suppliers order by SupName ",           
            "SELECT DetectPlaceID,DetectPlaceName FROM DetectPlace order by DetectPlaceName",
            "SELECT DetResultID,DetResultName FROM DetectResult order by DetResultID",
            "SELECT UserID,UserName,RoleID FROM Users ORDER BY UserID",
             "SELECT ImpID,ImpDef,ImpName FROM Implements order by ImpDef ",
            "SELECT * FROM DicValue WHERE ValueType = '{0}' ORDER BY ValueText",                     
        };
        private string[] strTreeLevel = new string[4]
        {"Update Category1 set C1Name = '{0}' Where C1id = {1}",
            "Update Category2 set C2Name = '{0}' Where C2id = {1}",
            "Update Category3 set C3Name = '{0}' Where C3id = {1}",
            "Update Implements set ImpName = '{0}' Where ImpId = {1}"            
        };
        private string[] strTreeLevelInsert = new string[4]
        {"Insert Into Category1 (C1Name) Values ('{1}')",
            "Insert Into Category2 (C1Id,C2Name) Values ({0},'{1}')",
            "Insert Into Category3 (C2Id,C3Name) Values ({0},'{1}')",            
            "Insert Into Implements (C3Id,ImpName) Values ({0},'{1}')"            
        };
        private string[] strTreeLevelDel = new string[4]
        {"Delete from Category1 Where C1id = {0}",
            "Delete from Category2 Where C2id = {0}",
            "Delete from Category3 Where C3id = {0}",            
            "Delete from Implements Where ImpId = {0}"            
        };
        public BasicDataForm()
        {
            InitializeComponent();
        }

        private void BasicDataForm_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(License.strConnSQL);
            conn.Open();
            adapter = new OleDbDataAdapter("",conn);
            dt = new DataTable();
            License.SetTreeView(treeView1, conn);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            else if (listBox1.SelectedIndex == 7)
            {
                treeView1.Visible = true;
                dataGridView1.Visible = false;                
            }
            else
            {
                dataGridView1.Visible = true;
                treeView1.Visible = false;
                dataGridView1.DataSource = null;
                dt.Dispose();
                dt = new DataTable();
                adapter.SelectCommand.CommandText = listBox1.SelectedIndex < 7 ? strSQL[listBox1.SelectedIndex] : string.Format(strSQL[7], listBox1.Text);
                cb = new OleDbCommandBuilder(adapter);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = listBox1.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            adapter.Update(dt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dt.Dispose();
            adapter.Dispose();
            Close();
            conn.Close();
            GC.Collect();
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Level == 0) return;
            treeView1.SelectedNode.BeginEdit();
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Name.IndexOf('N') == 0) //new 
            {
                if (e.Label == null || e.Label == string.Empty)
                    e.Node.Remove();
                else
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strTreeLevelInsert[e.Node.Level - 1],e.Node.Name.Substring(1),e.Label), conn);
                    command2.ExecuteNonQuery();
                    
                }
            }
            else
            {
                if (e.Label == null || e.Label == string.Empty)
                    e.CancelEdit = true;
                else
                {
                    OleDbCommand command2 = new OleDbCommand(string.Format(strTreeLevel[e.Node.Level - 1], e.Label, e.Node.Name), conn);
                    command2.ExecuteNonQuery();
                }
            }
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 4) return;
            TreeNode newNote = treeView1.SelectedNode.Nodes.Add("N" + treeView1.SelectedNode.Name, "");
            newNote.BeginEdit();
        }

        private void DelMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除当前类别吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                OleDbCommand command2 = new OleDbCommand(string.Format(strTreeLevelDel[treeView1.SelectedNode.Level - 1], treeView1.SelectedNode.Name), conn);
                if (command2.ExecuteNonQuery() == 1)
                {
                    treeView1.SelectedNode.Remove();
                }
            }
        }
    }
}
