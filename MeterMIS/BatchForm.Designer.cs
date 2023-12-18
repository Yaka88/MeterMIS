namespace MeterMIS
{
    partial class BatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioPerson = new System.Windows.Forms.RadioButton();
            this.comboOldUser = new System.Windows.Forms.ComboBox();
            this.comboImp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textImpNum = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.comboPerson = new System.Windows.Forms.ComboBox();
            this.comboDepart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateMove = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboNewUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboNewPerson = new System.Windows.Forms.ComboBox();
            this.comboNewDepart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuringRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextDetectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABCRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUser);
            this.groupBox1.Controls.Add(this.radioPerson);
            this.groupBox1.Controls.Add(this.comboOldUser);
            this.groupBox1.Controls.Add(this.comboImp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textImpNum);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.comboPerson);
            this.groupBox1.Controls.Add(this.comboDepart);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(0, 42);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(73, 17);
            this.radioUser.TabIndex = 22;
            this.radioUser.Text = "按确认者";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioPerson
            // 
            this.radioPerson.AutoSize = true;
            this.radioPerson.Checked = true;
            this.radioPerson.Location = new System.Drawing.Point(0, 17);
            this.radioPerson.Name = "radioPerson";
            this.radioPerson.Size = new System.Drawing.Size(73, 17);
            this.radioPerson.TabIndex = 21;
            this.radioPerson.TabStop = true;
            this.radioPerson.Text = "按使用者";
            this.radioPerson.UseVisualStyleBackColor = true;
            // 
            // comboOldUser
            // 
            this.comboOldUser.DisplayMember = "UserName";
            this.comboOldUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOldUser.FormattingEnabled = true;
            this.comboOldUser.Location = new System.Drawing.Point(77, 41);
            this.comboOldUser.Name = "comboOldUser";
            this.comboOldUser.Size = new System.Drawing.Size(73, 21);
            this.comboOldUser.TabIndex = 20;
            this.comboOldUser.ValueMember = "UserID";
            // 
            // comboImp
            // 
            this.comboImp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboImp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboImp.FormattingEnabled = true;
            this.comboImp.Location = new System.Drawing.Point(208, 41);
            this.comboImp.Name = "comboImp";
            this.comboImp.Size = new System.Drawing.Size(99, 21);
            this.comboImp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(152, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "量具名称:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCount.Location = new System.Drawing.Point(352, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(310, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "记录数:";
            // 
            // textImpNum
            // 
            this.textImpNum.Location = new System.Drawing.Point(379, 17);
            this.textImpNum.Name = "textImpNum";
            this.textImpNum.Size = new System.Drawing.Size(81, 20);
            this.textImpNum.TabIndex = 12;
            // 
            // btnQuery
            // 
            this.btnQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuery.Location = new System.Drawing.Point(385, 39);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // comboPerson
            // 
            this.comboPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPerson.DisplayMember = "PersonName";
            this.comboPerson.FormattingEnabled = true;
            this.comboPerson.Location = new System.Drawing.Point(77, 17);
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
            this.comboDepart.Location = new System.Drawing.Point(208, 17);
            this.comboDepart.Name = "comboDepart";
            this.comboDepart.Size = new System.Drawing.Size(99, 21);
            this.comboDepart.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(310, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "计量编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用部门:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateMove);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboNewUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.comboNewPerson);
            this.groupBox2.Controls.Add(this.comboNewDepart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(475, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 70);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待转移";
            // 
            // dateMove
            // 
            this.dateMove.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMove.Location = new System.Drawing.Point(227, 41);
            this.dateMove.Name = "dateMove";
            this.dateMove.Size = new System.Drawing.Size(90, 20);
            this.dateMove.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(158, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "转移日期:";
            // 
            // comboNewUser
            // 
            this.comboNewUser.DisplayMember = "UserName";
            this.comboNewUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNewUser.FormattingEnabled = true;
            this.comboNewUser.IntegralHeight = false;
            this.comboNewUser.Location = new System.Drawing.Point(64, 41);
            this.comboNewUser.Name = "comboNewUser";
            this.comboNewUser.Size = new System.Drawing.Size(90, 21);
            this.comboNewUser.TabIndex = 13;
            this.comboNewUser.ValueMember = "UserID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "现确认者:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(318, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "批量转移";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboNewPerson
            // 
            this.comboNewPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboNewPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboNewPerson.DisplayMember = "PersonName";
            this.comboNewPerson.FormattingEnabled = true;
            this.comboNewPerson.Location = new System.Drawing.Point(64, 16);
            this.comboNewPerson.Name = "comboNewPerson";
            this.comboNewPerson.Size = new System.Drawing.Size(90, 21);
            this.comboNewPerson.TabIndex = 8;
            this.comboNewPerson.ValueMember = "PersonID";
            // 
            // comboNewDepart
            // 
            this.comboNewDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNewDepart.DropDownWidth = 120;
            this.comboNewDepart.FormattingEnabled = true;
            this.comboNewDepart.IntegralHeight = false;
            this.comboNewDepart.Location = new System.Drawing.Point(227, 16);
            this.comboNewDepart.Name = "comboNewDepart";
            this.comboNewDepart.Size = new System.Drawing.Size(90, 21);
            this.comboNewDepart.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(158, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "现使用部门:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(5, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "现使用者:";
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
            this.NextDetectTime,
            this.DepName,
            this.PersonName,
            this.DetTypeName,
            this.DetResultName,
            this.ABCRange,
            this.CurStateName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
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
            this.dataGridView1.Size = new System.Drawing.Size(880, 360);
            this.dataGridView1.TabIndex = 18;
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
            // NextDetectTime
            // 
            this.NextDetectTime.DataPropertyName = "NextDetectTime";
            this.NextDetectTime.HeaderText = "下次确认日期";
            this.NextDetectTime.Name = "NextDetectTime";
            this.NextDetectTime.ReadOnly = true;
            this.NextDetectTime.Width = 80;
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
            // CurStateName
            // 
            this.CurStateName.DataPropertyName = "CurStateName";
            this.CurStateName.HeaderText = "使用状态";
            this.CurStateName.Name = "CurStateName";
            this.CurStateName.ReadOnly = true;
            this.CurStateName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurStateName.Width = 60;
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BatchForm";
            this.Text = "批量转移";
            this.Load += new System.EventHandler(this.BatchForm_Load);
            this.Resize += new System.EventHandler(this.BatchForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textImpNum;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox comboPerson;
        private System.Windows.Forms.ComboBox comboDepart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboNewPerson;
        private System.Windows.Forms.ComboBox comboNewDepart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboOldUser;
        private System.Windows.Forms.ComboBox comboImp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNewUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateMove;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuringRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextDetectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABCRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurStateName;
    }
}