namespace MeterMIS
{
    partial class ExceptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboStateQ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textImpNum = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuringRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABCRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuLost = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.textMemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDeal = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboStateQ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textImpNum);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // comboStateQ
            // 
            this.comboStateQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStateQ.FormattingEnabled = true;
            this.comboStateQ.Location = new System.Drawing.Point(67, 42);
            this.comboStateQ.Name = "comboStateQ";
            this.comboStateQ.Size = new System.Drawing.Size(90, 21);
            this.comboStateQ.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "使用状态:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCount.Location = new System.Drawing.Point(266, 20);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(218, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "记录数:";
            // 
            // textImpNum
            // 
            this.textImpNum.Location = new System.Drawing.Point(63, 17);
            this.textImpNum.Name = "textImpNum";
            this.textImpNum.Size = new System.Drawing.Size(90, 20);
            this.textImpNum.TabIndex = 12;
            // 
            // btnQuery
            // 
            this.btnQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuery.Location = new System.Drawing.Point(219, 41);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "计量编号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImpName,
            this.ImpNumber,
            this.Model,
            this.ModID,
            this.MeasuringRange,
            this.UseTime,
            this.DepName,
            this.PersonName,
            this.DetTypeName,
            this.DetResultName,
            this.ABCRange,
            this.LastDealTime,
            this.Comment});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 360);
            this.dataGridView1.TabIndex = 19;
            // 
            // ImpName
            // 
            this.ImpName.DataPropertyName = "ImpName";
            this.ImpName.Frozen = true;
            this.ImpName.HeaderText = "量具名称";
            this.ImpName.Name = "ImpName";
            this.ImpName.ReadOnly = true;
            // 
            // ImpNumber
            // 
            this.ImpNumber.DataPropertyName = "ImpNumber";
            this.ImpNumber.Frozen = true;
            this.ImpNumber.HeaderText = "计量编号";
            this.ImpNumber.Name = "ImpNumber";
            this.ImpNumber.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "规格型号";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // ModID
            // 
            this.ModID.DataPropertyName = "ModID";
            this.ModID.HeaderText = "器具ID";
            this.ModID.Name = "ModID";
            this.ModID.ReadOnly = true;
            this.ModID.Visible = false;
            // 
            // MeasuringRange
            // 
            this.MeasuringRange.DataPropertyName = "MeasuringRange";
            this.MeasuringRange.HeaderText = "测量范围";
            this.MeasuringRange.Name = "MeasuringRange";
            this.MeasuringRange.ReadOnly = true;
            this.MeasuringRange.Width = 80;
            // 
            // UseTime
            // 
            this.UseTime.DataPropertyName = "UseTime";
            this.UseTime.HeaderText = "启用日期";
            this.UseTime.Name = "UseTime";
            this.UseTime.ReadOnly = true;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "使用部门";
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "使用者";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // DetTypeName
            // 
            this.DetTypeName.DataPropertyName = "DetTypeName";
            this.DetTypeName.HeaderText = "检定类型";
            this.DetTypeName.Name = "DetTypeName";
            this.DetTypeName.ReadOnly = true;
            this.DetTypeName.Width = 60;
            // 
            // DetResultName
            // 
            this.DetResultName.DataPropertyName = "DetResultName";
            this.DetResultName.HeaderText = "检定结果";
            this.DetResultName.Name = "DetResultName";
            this.DetResultName.ReadOnly = true;
            this.DetResultName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetResultName.Width = 66;
            // 
            // ABCRange
            // 
            this.ABCRange.DataPropertyName = "ABCRange";
            this.ABCRange.HeaderText = "管理类别";
            this.ABCRange.Name = "ABCRange";
            this.ABCRange.ReadOnly = true;
            this.ABCRange.Width = 60;
            // 
            // LastDealTime
            // 
            this.LastDealTime.DataPropertyName = "LastDealTime";
            this.LastDealTime.HeaderText = "处理日期";
            this.LastDealTime.Name = "LastDealTime";
            this.LastDealTime.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuView,
            this.StripMenuEdit,
            this.StripMenuLost,
            this.StripMenuSave,
            this.StripMenuBreak,
            this.StripMenuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 136);
            // 
            // StripMenuView
            // 
            this.StripMenuView.Name = "StripMenuView";
            this.StripMenuView.Size = new System.Drawing.Size(106, 22);
            this.StripMenuView.Text = "查看";
            this.StripMenuView.Click += new System.EventHandler(this.StripMenuView_Click);
            // 
            // StripMenuEdit
            // 
            this.StripMenuEdit.Name = "StripMenuEdit";
            this.StripMenuEdit.Size = new System.Drawing.Size(106, 22);
            this.StripMenuEdit.Text = "启用";
            this.StripMenuEdit.Click += new System.EventHandler(this.StripMenuEdit_Click);
            // 
            // StripMenuLost
            // 
            this.StripMenuLost.Name = "StripMenuLost";
            this.StripMenuLost.Size = new System.Drawing.Size(106, 22);
            this.StripMenuLost.Text = "遗失";
            this.StripMenuLost.Click += new System.EventHandler(this.StripMenuLost_Click);
            // 
            // StripMenuSave
            // 
            this.StripMenuSave.Name = "StripMenuSave";
            this.StripMenuSave.Size = new System.Drawing.Size(106, 22);
            this.StripMenuSave.Text = "封存";
            this.StripMenuSave.Click += new System.EventHandler(this.StripMenuSave_Click);
            // 
            // StripMenuBreak
            // 
            this.StripMenuBreak.Name = "StripMenuBreak";
            this.StripMenuBreak.Size = new System.Drawing.Size(106, 22);
            this.StripMenuBreak.Text = "报废";
            this.StripMenuBreak.Click += new System.EventHandler(this.StripMenuBreak_Click);
            // 
            // StripMenuDelete
            // 
            this.StripMenuDelete.Name = "StripMenuDelete";
            this.StripMenuDelete.Size = new System.Drawing.Size(106, 22);
            this.StripMenuDelete.Text = "删除";
            this.StripMenuDelete.Click += new System.EventHandler(this.StripMenuDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.textMemo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateDeal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboState);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(411, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 70);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处理结果";
            // 
            // btnProcess
            // 
            this.btnProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcess.Location = new System.Drawing.Point(194, 43);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 28;
            this.btnProcess.Text = "确认入库";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textMemo
            // 
            this.textMemo.Location = new System.Drawing.Point(229, 14);
            this.textMemo.Name = "textMemo";
            this.textMemo.Size = new System.Drawing.Size(120, 20);
            this.textMemo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(191, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "备注:";
            // 
            // dateDeal
            // 
            this.dateDeal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeal.Location = new System.Drawing.Point(75, 45);
            this.dateDeal.Name = "dateDeal";
            this.dateDeal.Size = new System.Drawing.Size(90, 20);
            this.dateDeal.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(14, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "处理日期:";
            // 
            // comboState
            // 
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(73, 12);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(90, 21);
            this.comboState.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "使用状态:";
            // 
            // ExceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExceptForm";
            this.Text = "量具异常处理";
            this.Load += new System.EventHandler(this.ExceptForm_Load);
            this.Resize += new System.EventHandler(this.ExceptForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textImpNum;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuView;
        private System.Windows.Forms.ToolStripMenuItem StripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuringRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABCRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.ToolStripMenuItem StripMenuLost;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem StripMenuBreak;
        private System.Windows.Forms.ComboBox comboStateQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDeal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Label label1;
    }
}