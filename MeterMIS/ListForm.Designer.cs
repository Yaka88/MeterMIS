namespace MeterMIS
{
    partial class ListForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboABC = new System.Windows.Forms.ComboBox();
            this.comboDetPlace = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboFactory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboDetectType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textMeasuring = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFactNum = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textImpNum = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.comboPerson = new System.Windows.Forms.ComboBox();
            this.comboDepart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUseTime = new System.Windows.Forms.TabPage();
            this.tabLastDetectTime = new System.Windows.Forms.TabPage();
            this.tabNextDetectTime = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuringRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccuracyClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DivisionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDetectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetectIntervalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextDetectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetectPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABCRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.listState = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(160, 530);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.comboABC);
            this.groupBox1.Controls.Add(this.comboDetPlace);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboFactory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboDetectType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.textMeasuring);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textFactNum);
            this.groupBox1.Controls.Add(this.textModel);
            this.groupBox1.Controls.Add(this.textImpNum);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.comboState);
            this.groupBox1.Controls.Add(this.comboUser);
            this.groupBox1.Controls.Add(this.comboPerson);
            this.groupBox1.Controls.Add(this.comboDepart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组合查询";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(456, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 95;
            this.label22.Text = "管理类别:";
            // 
            // comboABC
            // 
            this.comboABC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboABC.FormattingEnabled = true;
            this.comboABC.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C"});
            this.comboABC.Location = new System.Drawing.Point(515, 65);
            this.comboABC.Name = "comboABC";
            this.comboABC.Size = new System.Drawing.Size(53, 21);
            this.comboABC.TabIndex = 94;
            // 
            // comboDetPlace
            // 
            this.comboDetPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetPlace.DropDownWidth = 150;
            this.comboDetPlace.FormattingEnabled = true;
            this.comboDetPlace.Location = new System.Drawing.Point(357, 43);
            this.comboDetPlace.Name = "comboDetPlace";
            this.comboDetPlace.Size = new System.Drawing.Size(93, 21);
            this.comboDetPlace.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(298, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "检定地点:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboFactory
            // 
            this.comboFactory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFactory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFactory.DisplayMember = "SupName";
            this.comboFactory.DropDownWidth = 150;
            this.comboFactory.FormattingEnabled = true;
            this.comboFactory.Location = new System.Drawing.Point(357, 70);
            this.comboFactory.Name = "comboFactory";
            this.comboFactory.Size = new System.Drawing.Size(95, 21);
            this.comboFactory.TabIndex = 78;
            this.comboFactory.ValueMember = "SupplierID";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(299, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "生产厂家:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboDetectType
            // 
            this.comboDetectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetectType.DropDownWidth = 70;
            this.comboDetectType.FormattingEnabled = true;
            this.comboDetectType.Location = new System.Drawing.Point(515, 41);
            this.comboDetectType.Name = "comboDetectType";
            this.comboDetectType.Size = new System.Drawing.Size(53, 21);
            this.comboDetectType.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(456, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "检定类型:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "到";
            // 
            // dateTo
            // 
            this.dateTo.Checked = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(714, 37);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShowCheckBox = true;
            this.dateTo.Size = new System.Drawing.Size(96, 20);
            this.dateTo.TabIndex = 26;
            // 
            // dateFrom
            // 
            this.dateFrom.Checked = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(582, 37);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShowCheckBox = true;
            this.dateFrom.Size = new System.Drawing.Size(96, 20);
            this.dateFrom.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(748, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "打印预览";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textMeasuring
            // 
            this.textMeasuring.Location = new System.Drawing.Point(200, 46);
            this.textMeasuring.Name = "textMeasuring";
            this.textMeasuring.Size = new System.Drawing.Size(93, 20);
            this.textMeasuring.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "测量范围:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(625, 75);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "记录数:";
            // 
            // textFactNum
            // 
            this.textFactNum.Location = new System.Drawing.Point(200, 73);
            this.textFactNum.Name = "textFactNum";
            this.textFactNum.Size = new System.Drawing.Size(93, 20);
            this.textFactNum.TabIndex = 14;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(200, 20);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(93, 20);
            this.textModel.TabIndex = 13;
            // 
            // textImpNum
            // 
            this.textImpNum.Location = new System.Drawing.Point(64, 20);
            this.textImpNum.Name = "textImpNum";
            this.textImpNum.Size = new System.Drawing.Size(73, 20);
            this.textImpNum.TabIndex = 12;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(666, 68);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // comboState
            // 
            this.comboState.DropDownHeight = 1;
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.FormattingEnabled = true;
            this.comboState.IntegralHeight = false;
            this.comboState.Location = new System.Drawing.Point(515, 14);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(53, 21);
            this.comboState.TabIndex = 10;
            this.comboState.DropDown += new System.EventHandler(this.comboState_DropDown);
            // 
            // comboUser
            // 
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(64, 73);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(73, 21);
            this.comboUser.TabIndex = 9;
            // 
            // comboPerson
            // 
            this.comboPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPerson.DisplayMember = "PersonName";
            this.comboPerson.FormattingEnabled = true;
            this.comboPerson.Location = new System.Drawing.Point(64, 46);
            this.comboPerson.Name = "comboPerson";
            this.comboPerson.Size = new System.Drawing.Size(73, 21);
            this.comboPerson.TabIndex = 8;
            this.comboPerson.ValueMember = "PersonID";
            // 
            // comboDepart
            // 
            this.comboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepart.DropDownWidth = 120;
            this.comboDepart.FormattingEnabled = true;
            this.comboDepart.Location = new System.Drawing.Point(357, 17);
            this.comboDepart.Name = "comboDepart";
            this.comboDepart.Size = new System.Drawing.Size(95, 21);
            this.comboDepart.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "出厂编号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "规格型号:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "计量编号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "使用状态:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认者:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用者:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用部门:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUseTime);
            this.tabControl1.Controls.Add(this.tabLastDetectTime);
            this.tabControl1.Controls.Add(this.tabNextDetectTime);
            this.tabControl1.Location = new System.Drawing.Point(573, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 50);
            this.tabControl1.TabIndex = 31;
            // 
            // tabUseTime
            // 
            this.tabUseTime.Location = new System.Drawing.Point(4, 22);
            this.tabUseTime.Name = "tabUseTime";
            this.tabUseTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabUseTime.Size = new System.Drawing.Size(249, 24);
            this.tabUseTime.TabIndex = 0;
            this.tabUseTime.Text = "启用日期";
            this.tabUseTime.UseVisualStyleBackColor = true;
            // 
            // tabLastDetectTime
            // 
            this.tabLastDetectTime.Location = new System.Drawing.Point(4, 22);
            this.tabLastDetectTime.Name = "tabLastDetectTime";
            this.tabLastDetectTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastDetectTime.Size = new System.Drawing.Size(249, 24);
            this.tabLastDetectTime.TabIndex = 1;
            this.tabLastDetectTime.Text = "上次确认日期";
            this.tabLastDetectTime.UseVisualStyleBackColor = true;
            // 
            // tabNextDetectTime
            // 
            this.tabNextDetectTime.Location = new System.Drawing.Point(4, 22);
            this.tabNextDetectTime.Name = "tabNextDetectTime";
            this.tabNextDetectTime.Size = new System.Drawing.Size(249, 24);
            this.tabNextDetectTime.TabIndex = 2;
            this.tabNextDetectTime.Text = "下次确认日期";
            this.tabNextDetectTime.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.ModID,
            this.Printed,
            this.Model,
            this.SupName,
            this.FactoryNumber,
            this.MeasuringRange,
            this.AccuracyClass,
            this.DivisionValue,
            this.size,
            this.UseTime,
            this.LastDetectTime,
            this.DetectIntervalName,
            this.NextDetectTime,
            this.DetTypeName,
            this.DetectPlaceName,
            this.DetResultName,
            this.ABCRange,
            this.CurStateName,
            this.UsePlace,
            this.DepName,
            this.PersonName,
            this.UserName,
            this.Comment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
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
            this.dataGridView1.Size = new System.Drawing.Size(830, 423);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // ModID
            // 
            this.ModID.DataPropertyName = "ModID";
            this.ModID.HeaderText = "器具ID";
            this.ModID.Name = "ModID";
            this.ModID.ReadOnly = true;
            this.ModID.Visible = false;
            // 
            // Printed
            // 
            this.Printed.DataPropertyName = "Printed";
            this.Printed.HeaderText = "Printed";
            this.Printed.Name = "Printed";
            this.Printed.ReadOnly = true;
            this.Printed.Visible = false;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "规格型号";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "生产厂家";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // FactoryNumber
            // 
            this.FactoryNumber.DataPropertyName = "FactoryNumber";
            this.FactoryNumber.HeaderText = "出厂编号";
            this.FactoryNumber.Name = "FactoryNumber";
            this.FactoryNumber.ReadOnly = true;
            // 
            // MeasuringRange
            // 
            this.MeasuringRange.DataPropertyName = "MeasuringRange";
            this.MeasuringRange.HeaderText = "测量范围";
            this.MeasuringRange.Name = "MeasuringRange";
            this.MeasuringRange.ReadOnly = true;
            // 
            // AccuracyClass
            // 
            this.AccuracyClass.DataPropertyName = "AccuracyClass";
            this.AccuracyClass.FillWeight = 90F;
            this.AccuracyClass.HeaderText = "准确度/ 最大允许误差";
            this.AccuracyClass.Name = "AccuracyClass";
            this.AccuracyClass.ReadOnly = true;
            this.AccuracyClass.Width = 90;
            // 
            // DivisionValue
            // 
            this.DivisionValue.DataPropertyName = "DivisionValue";
            this.DivisionValue.HeaderText = "分度值";
            this.DivisionValue.Name = "DivisionValue";
            this.DivisionValue.ReadOnly = true;
            this.DivisionValue.Width = 60;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "实测尺寸";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 80;
            // 
            // UseTime
            // 
            this.UseTime.DataPropertyName = "UseTime";
            this.UseTime.HeaderText = "启用日期";
            this.UseTime.Name = "UseTime";
            this.UseTime.ReadOnly = true;
            this.UseTime.Width = 80;
            // 
            // LastDetectTime
            // 
            this.LastDetectTime.DataPropertyName = "LastDetectTime";
            this.LastDetectTime.HeaderText = "上次确认日期";
            this.LastDetectTime.Name = "LastDetectTime";
            this.LastDetectTime.ReadOnly = true;
            this.LastDetectTime.Width = 80;
            // 
            // DetectIntervalName
            // 
            this.DetectIntervalName.DataPropertyName = "DetectIntervalValue";
            this.DetectIntervalName.HeaderText = "确认间隔(月)";
            this.DetectIntervalName.Name = "DetectIntervalName";
            this.DetectIntervalName.ReadOnly = true;
            this.DetectIntervalName.Width = 70;
            // 
            // NextDetectTime
            // 
            this.NextDetectTime.DataPropertyName = "NextDetectTime";
            this.NextDetectTime.HeaderText = "下次确认日期";
            this.NextDetectTime.Name = "NextDetectTime";
            this.NextDetectTime.ReadOnly = true;
            this.NextDetectTime.Width = 80;
            // 
            // DetTypeName
            // 
            this.DetTypeName.DataPropertyName = "DetTypeName";
            this.DetTypeName.HeaderText = "检定类型";
            this.DetTypeName.Name = "DetTypeName";
            this.DetTypeName.ReadOnly = true;
            this.DetTypeName.Width = 60;
            // 
            // DetectPlaceName
            // 
            this.DetectPlaceName.DataPropertyName = "DetectPlaceName";
            this.DetectPlaceName.HeaderText = "检定地点";
            this.DetectPlaceName.Name = "DetectPlaceName";
            this.DetectPlaceName.ReadOnly = true;
            this.DetectPlaceName.Width = 60;
            // 
            // DetResultName
            // 
            this.DetResultName.DataPropertyName = "DetResultName";
            this.DetResultName.HeaderText = "检定结果";
            this.DetResultName.Name = "DetResultName";
            this.DetResultName.ReadOnly = true;
            this.DetResultName.Width = 60;
            // 
            // ABCRange
            // 
            this.ABCRange.DataPropertyName = "ABCRange";
            this.ABCRange.HeaderText = "管理类别";
            this.ABCRange.Name = "ABCRange";
            this.ABCRange.ReadOnly = true;
            this.ABCRange.Width = 60;
            // 
            // CurStateName
            // 
            this.CurStateName.DataPropertyName = "CurStateName";
            this.CurStateName.HeaderText = "使用状态";
            this.CurStateName.Name = "CurStateName";
            this.CurStateName.ReadOnly = true;
            this.CurStateName.Width = 60;
            // 
            // UsePlace
            // 
            this.UsePlace.DataPropertyName = "UsePlace";
            this.UsePlace.HeaderText = "使用地点";
            this.UsePlace.Name = "UsePlace";
            this.UsePlace.ReadOnly = true;
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
            this.PersonName.Width = 60;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "确认者";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 60;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 52;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuView,
            this.StripMenuEdit,
            this.StripMenuNew,
            this.StripMenuCopy,
            this.StripMenuDelete,
            this.StripMenuColumn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 136);
            // 
            // StripMenuView
            // 
            this.StripMenuView.Name = "StripMenuView";
            this.StripMenuView.Size = new System.Drawing.Size(136, 22);
            this.StripMenuView.Text = "查看";
            this.StripMenuView.Click += new System.EventHandler(this.StripMenuView_Click);
            // 
            // StripMenuEdit
            // 
            this.StripMenuEdit.Name = "StripMenuEdit";
            this.StripMenuEdit.Size = new System.Drawing.Size(136, 22);
            this.StripMenuEdit.Text = "修改";
            this.StripMenuEdit.Click += new System.EventHandler(this.StripMenuEdit_Click);
            // 
            // StripMenuNew
            // 
            this.StripMenuNew.Name = "StripMenuNew";
            this.StripMenuNew.Size = new System.Drawing.Size(136, 22);
            this.StripMenuNew.Text = "新增";
            this.StripMenuNew.Click += new System.EventHandler(this.StripMenuNew_Click);
            // 
            // StripMenuCopy
            // 
            this.StripMenuCopy.Name = "StripMenuCopy";
            this.StripMenuCopy.Size = new System.Drawing.Size(136, 22);
            this.StripMenuCopy.Text = "复制";
            this.StripMenuCopy.Click += new System.EventHandler(this.StripMenuCopy_Click);
            // 
            // StripMenuDelete
            // 
            this.StripMenuDelete.Name = "StripMenuDelete";
            this.StripMenuDelete.Size = new System.Drawing.Size(136, 22);
            this.StripMenuDelete.Text = "删除";
            this.StripMenuDelete.Click += new System.EventHandler(this.StripMenuDelete_Click);
            // 
            // StripMenuColumn
            // 
            this.StripMenuColumn.Name = "StripMenuColumn";
            this.StripMenuColumn.Size = new System.Drawing.Size(136, 22);
            this.StripMenuColumn.Text = "自定义列";
            this.StripMenuColumn.Click += new System.EventHandler(this.StripMenuColumn_Click);
            // 
            // listState
            // 
            this.listState.FormattingEnabled = true;
            this.listState.Location = new System.Drawing.Point(515, 35);
            this.listState.Name = "listState";
            this.listState.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listState.Size = new System.Drawing.Size(53, 173);
            this.listState.TabIndex = 3;
            this.listState.Visible = false;
            this.listState.LostFocus += new System.EventHandler(this.listState_LostFocus);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listState);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 530);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListForm";
            this.Text = "量具管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.Resize += new System.EventHandler(this.ListForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.ComboBox comboPerson;
        private System.Windows.Forms.ComboBox comboDepart;
        private System.Windows.Forms.ListBox listState;
        private System.Windows.Forms.TextBox textFactNum;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textImpNum;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem StripMenuView;
        private System.Windows.Forms.ToolStripMenuItem StripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem StripMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem StripMenuDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textMeasuring;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboDetectType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUseTime;
        private System.Windows.Forms.TabPage tabLastDetectTime;
        private System.Windows.Forms.TabPage tabNextDetectTime;
        private System.Windows.Forms.ComboBox comboFactory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboDetPlace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboABC;
        private System.Windows.Forms.ToolStripMenuItem StripMenuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuringRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccuracyClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn DivisionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDetectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetectIntervalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextDetectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetectPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABCRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}