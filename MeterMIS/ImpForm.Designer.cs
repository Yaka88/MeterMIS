namespace MeterMIS
{
    partial class ImpForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboImp = new System.Windows.Forms.ComboBox();
            this.dateUseDate = new System.Windows.Forms.DateTimePicker();
            this.textComment = new System.Windows.Forms.TextBox();
            this.comboABC = new System.Windows.Forms.ComboBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textUsePlace = new System.Windows.Forms.TextBox();
            this.comboDepart = new System.Windows.Forms.ComboBox();
            this.comboPerson = new System.Windows.Forms.ComboBox();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.comboDetType = new System.Windows.Forms.ComboBox();
            this.comboDetResult = new System.Windows.Forms.ComboBox();
            this.comboDetPlace = new System.Windows.Forms.ComboBox();
            this.comboDetInterval = new System.Windows.Forms.ComboBox();
            this.dateNextDate = new System.Windows.Forms.DateTimePicker();
            this.dateLastDate = new System.Windows.Forms.DateTimePicker();
            this.textSize = new System.Windows.Forms.TextBox();
            this.comboDivision = new System.Windows.Forms.ComboBox();
            this.comboAccuracy = new System.Windows.Forms.ComboBox();
            this.comboMeaRange = new System.Windows.Forms.ComboBox();
            this.comboFactory = new System.Windows.Forms.ComboBox();
            this.textFactNum = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textImpNum = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastDetectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(444, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "保存再关闭";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 23);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(276, 259);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 23);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "保存再新增";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboImp);
            this.groupBox1.Controls.Add(this.dateUseDate);
            this.groupBox1.Controls.Add(this.textComment);
            this.groupBox1.Controls.Add(this.comboABC);
            this.groupBox1.Controls.Add(this.comboState);
            this.groupBox1.Controls.Add(this.textUsePlace);
            this.groupBox1.Controls.Add(this.comboDepart);
            this.groupBox1.Controls.Add(this.comboPerson);
            this.groupBox1.Controls.Add(this.comboUser);
            this.groupBox1.Controls.Add(this.comboDetType);
            this.groupBox1.Controls.Add(this.comboDetResult);
            this.groupBox1.Controls.Add(this.comboDetPlace);
            this.groupBox1.Controls.Add(this.comboDetInterval);
            this.groupBox1.Controls.Add(this.dateNextDate);
            this.groupBox1.Controls.Add(this.dateLastDate);
            this.groupBox1.Controls.Add(this.textSize);
            this.groupBox1.Controls.Add(this.comboDivision);
            this.groupBox1.Controls.Add(this.comboAccuracy);
            this.groupBox1.Controls.Add(this.comboMeaRange);
            this.groupBox1.Controls.Add(this.comboFactory);
            this.groupBox1.Controls.Add(this.textFactNum);
            this.groupBox1.Controls.Add(this.textModel);
            this.groupBox1.Controls.Add(this.textImpNum);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 248);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "量具名称";
            // 
            // comboImp
            // 
            this.comboImp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboImp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboImp.FormattingEnabled = true;
            this.comboImp.Location = new System.Drawing.Point(83, 7);
            this.comboImp.Name = "comboImp";
            this.comboImp.Size = new System.Drawing.Size(157, 21);
            this.comboImp.TabIndex = 95;
            // 
            // dateUseDate
            // 
            this.dateUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUseDate.Location = new System.Drawing.Point(671, 106);
            this.dateUseDate.Name = "dateUseDate";
            this.dateUseDate.Size = new System.Drawing.Size(83, 20);
            this.dateUseDate.TabIndex = 81;
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(325, 212);
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(429, 20);
            this.textComment.TabIndex = 94;
            // 
            // comboABC
            // 
            this.comboABC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboABC.FormattingEnabled = true;
            this.comboABC.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboABC.Location = new System.Drawing.Point(491, 43);
            this.comboABC.Name = "comboABC";
            this.comboABC.Size = new System.Drawing.Size(80, 21);
            this.comboABC.TabIndex = 93;
            // 
            // comboState
            // 
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.Enabled = false;
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(491, 106);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(80, 21);
            this.comboState.TabIndex = 92;
            // 
            // textUsePlace
            // 
            this.textUsePlace.Location = new System.Drawing.Point(325, 178);
            this.textUsePlace.Name = "textUsePlace";
            this.textUsePlace.Size = new System.Drawing.Size(100, 20);
            this.textUsePlace.TabIndex = 91;
            // 
            // comboDepart
            // 
            this.comboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepart.FormattingEnabled = true;
            this.comboDepart.Location = new System.Drawing.Point(325, 140);
            this.comboDepart.Name = "comboDepart";
            this.comboDepart.Size = new System.Drawing.Size(100, 21);
            this.comboDepart.TabIndex = 90;
            // 
            // comboPerson
            // 
            this.comboPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPerson.DisplayMember = "PersonName";
            this.comboPerson.FormattingEnabled = true;
            this.comboPerson.Location = new System.Drawing.Point(325, 43);
            this.comboPerson.Name = "comboPerson";
            this.comboPerson.Size = new System.Drawing.Size(100, 21);
            this.comboPerson.TabIndex = 89;
            this.comboPerson.ValueMember = "PersonID";
            // 
            // comboUser
            // 
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(325, 74);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(100, 21);
            this.comboUser.TabIndex = 88;
            // 
            // comboDetType
            // 
            this.comboDetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetType.FormattingEnabled = true;
            this.comboDetType.Location = new System.Drawing.Point(491, 73);
            this.comboDetType.Name = "comboDetType";
            this.comboDetType.Size = new System.Drawing.Size(80, 21);
            this.comboDetType.TabIndex = 87;
            // 
            // comboDetResult
            // 
            this.comboDetResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetResult.FormattingEnabled = true;
            this.comboDetResult.Location = new System.Drawing.Point(491, 140);
            this.comboDetResult.Name = "comboDetResult";
            this.comboDetResult.Size = new System.Drawing.Size(80, 21);
            this.comboDetResult.TabIndex = 86;
            // 
            // comboDetPlace
            // 
            this.comboDetPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetPlace.DropDownWidth = 150;
            this.comboDetPlace.FormattingEnabled = true;
            this.comboDetPlace.Location = new System.Drawing.Point(325, 105);
            this.comboDetPlace.Name = "comboDetPlace";
            this.comboDetPlace.Size = new System.Drawing.Size(100, 21);
            this.comboDetPlace.TabIndex = 85;
            // 
            // comboDetInterval
            // 
            this.comboDetInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDetInterval.FormattingEnabled = true;
            this.comboDetInterval.Location = new System.Drawing.Point(491, 176);
            this.comboDetInterval.Name = "comboDetInterval";
            this.comboDetInterval.Size = new System.Drawing.Size(80, 21);
            this.comboDetInterval.TabIndex = 84;
            this.comboDetInterval.TextChanged += new System.EventHandler(this.comboDetInterval_TextChanged);
            // 
            // dateNextDate
            // 
            this.dateNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNextDate.Location = new System.Drawing.Point(671, 178);
            this.dateNextDate.Name = "dateNextDate";
            this.dateNextDate.Size = new System.Drawing.Size(83, 20);
            this.dateNextDate.TabIndex = 83;
            // 
            // dateLastDate
            // 
            this.dateLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLastDate.Location = new System.Drawing.Point(670, 143);
            this.dateLastDate.Name = "dateLastDate";
            this.dateLastDate.Size = new System.Drawing.Size(83, 20);
            this.dateLastDate.TabIndex = 82;
            this.dateLastDate.ValueChanged += new System.EventHandler(this.dateLastDate_ValueChanged);
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(82, 179);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(157, 20);
            this.textSize.TabIndex = 80;
            // 
            // comboDivision
            // 
            this.comboDivision.FormattingEnabled = true;
            this.comboDivision.Location = new System.Drawing.Point(671, 73);
            this.comboDivision.Name = "comboDivision";
            this.comboDivision.Size = new System.Drawing.Size(83, 21);
            this.comboDivision.TabIndex = 79;
            // 
            // comboAccuracy
            // 
            this.comboAccuracy.FormattingEnabled = true;
            this.comboAccuracy.Location = new System.Drawing.Point(671, 39);
            this.comboAccuracy.Name = "comboAccuracy";
            this.comboAccuracy.Size = new System.Drawing.Size(83, 21);
            this.comboAccuracy.TabIndex = 78;
            // 
            // comboMeaRange
            // 
            this.comboMeaRange.FormattingEnabled = true;
            this.comboMeaRange.Location = new System.Drawing.Point(83, 105);
            this.comboMeaRange.Name = "comboMeaRange";
            this.comboMeaRange.Size = new System.Drawing.Size(157, 21);
            this.comboMeaRange.TabIndex = 77;
            // 
            // comboFactory
            // 
            this.comboFactory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFactory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFactory.DisplayMember = "SupName";
            this.comboFactory.DropDownWidth = 150;
            this.comboFactory.FormattingEnabled = true;
            this.comboFactory.Location = new System.Drawing.Point(82, 211);
            this.comboFactory.Name = "comboFactory";
            this.comboFactory.Size = new System.Drawing.Size(158, 21);
            this.comboFactory.TabIndex = 76;
            this.comboFactory.ValueMember = "SupplierID";
            // 
            // textFactNum
            // 
            this.textFactNum.Location = new System.Drawing.Point(82, 143);
            this.textFactNum.Name = "textFactNum";
            this.textFactNum.Size = new System.Drawing.Size(157, 20);
            this.textFactNum.TabIndex = 75;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(83, 74);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(157, 20);
            this.textModel.TabIndex = 74;
            // 
            // textImpNum
            // 
            this.textImpNum.Location = new System.Drawing.Point(82, 40);
            this.textImpNum.Name = "textImpNum";
            this.textImpNum.Size = new System.Drawing.Size(157, 20);
            this.textImpNum.TabIndex = 73;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(269, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 94;
            this.label21.Text = "备注:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(19, 220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 93;
            this.label22.Text = "生产厂家:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(583, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 92;
            this.label17.Text = "下次确认日期:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(439, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 91;
            this.label18.Text = "确认间隔:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(269, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 90;
            this.label19.Text = "使用地点:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(20, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 89;
            this.label20.Text = "实测尺寸:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(583, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "上次确认日期:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(439, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "检定结果:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(269, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "使用部门:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(20, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "出厂编号:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(585, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "启用日期:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(439, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "使用状态:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(267, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "检定地点:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(19, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "测量范围:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(587, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "分度值:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(439, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "检定类型:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(269, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "确认者:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "规格型号:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(586, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "准确度:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(439, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "管理类别:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(269, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "使用者:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "计量编号:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 95;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastDetectTime,
            this.DetResultName,
            this.CurStateName,
            this.DepName,
            this.PersonID,
            this.UserID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.615385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(47, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 245);
            this.dataGridView1.TabIndex = 96;
            this.dataGridView1.Visible = false;
            // 
            // LastDetectTime
            // 
            this.LastDetectTime.DataPropertyName = "LastDetectTime";
            this.LastDetectTime.HeaderText = "确认日期";
            this.LastDetectTime.Name = "LastDetectTime";
            this.LastDetectTime.ReadOnly = true;
            // 
            // DetResultName
            // 
            this.DetResultName.DataPropertyName = "DetResultName";
            this.DetResultName.HeaderText = "检定结果";
            this.DetResultName.Name = "DetResultName";
            this.DetResultName.ReadOnly = true;
            // 
            // CurStateName
            // 
            this.CurStateName.DataPropertyName = "CurStateName";
            this.CurStateName.HeaderText = "使用状态";
            this.CurStateName.Name = "CurStateName";
            this.CurStateName.ReadOnly = true;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "使用部门";
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonName";
            this.PersonID.HeaderText = "使用者";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserName";
            this.UserID.HeaderText = "确认者";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(47, 284);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 97;
            this.label23.Text = "历史检定记录";
            this.label23.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(444, 259);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 98;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ImpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 360);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "量具详细表单";
            this.Load += new System.EventHandler(this.ImpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.ComboBox comboABC;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.TextBox textUsePlace;
        private System.Windows.Forms.ComboBox comboDepart;
        private System.Windows.Forms.ComboBox comboPerson;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.ComboBox comboDetType;
        private System.Windows.Forms.ComboBox comboDetResult;
        private System.Windows.Forms.ComboBox comboDetPlace;
        private System.Windows.Forms.ComboBox comboDetInterval;
        private System.Windows.Forms.DateTimePicker dateNextDate;
        private System.Windows.Forms.DateTimePicker dateLastDate;
        private System.Windows.Forms.DateTimePicker dateUseDate;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.ComboBox comboDivision;
        private System.Windows.Forms.ComboBox comboAccuracy;
        private System.Windows.Forms.ComboBox comboMeaRange;
        private System.Windows.Forms.ComboBox comboFactory;
        private System.Windows.Forms.TextBox textFactNum;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textImpNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDetectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.ComboBox comboImp;
        private System.Windows.Forms.Button btnPrint;
    }
}