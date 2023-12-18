namespace MeterMIS
{
    partial class MDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImpPrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExceptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ImpStatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectStatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockStatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemYearPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageMenu,
            this.SpecMenu,
            this.StatMenu,
            this.windowsMenu,
            this.DataMenuItem,
            this.toolsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ManageMenu
            // 
            this.ManageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListMenuItem,
            this.DetectMenuItem,
            this.toolStripSeparator3,
            this.ImpPrintMenuItem,
            this.printMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.ManageMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.ManageMenu.Name = "ManageMenu";
            this.ManageMenu.Size = new System.Drawing.Size(80, 21);
            this.ManageMenu.Text = "日常管理";
            // 
            // ListMenuItem
            // 
            this.ListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListMenuItem.Image")));
            this.ListMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ListMenuItem.Name = "ListMenuItem";
            this.ListMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ListMenuItem.Text = "量具管理";
            this.ListMenuItem.Click += new System.EventHandler(this.ListMenuItem_Click);
            // 
            // DetectMenuItem
            // 
            this.DetectMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DetectMenuItem.Image")));
            this.DetectMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.DetectMenuItem.Name = "DetectMenuItem";
            this.DetectMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DetectMenuItem.Text = "检定录入";
            this.DetectMenuItem.Click += new System.EventHandler(this.DetectMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // ImpPrintMenuItem
            // 
            this.ImpPrintMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ImpPrintMenuItem.Image")));
            this.ImpPrintMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ImpPrintMenuItem.Name = "ImpPrintMenuItem";
            this.ImpPrintMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ImpPrintMenuItem.Text = "台账打印";
            this.ImpPrintMenuItem.Click += new System.EventHandler(this.ImpPrintMenuItem_Click);
            // 
            // printMenuItem
            // 
            this.printMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printMenuItem.Image")));
            this.printMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.Size = new System.Drawing.Size(136, 22);
            this.printMenuItem.Text = "周检打印";
            this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // SpecMenu
            // 
            this.SpecMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PanelMenuItem,
            this.ExceptMenuItem,
            this.BatchMenuItem});
            this.SpecMenu.Name = "SpecMenu";
            this.SpecMenu.Size = new System.Drawing.Size(80, 21);
            this.SpecMenu.Text = "日常事务";
            // 
            // PanelMenuItem
            // 
            this.PanelMenuItem.Name = "PanelMenuItem";
            this.PanelMenuItem.Size = new System.Drawing.Size(136, 22);
            this.PanelMenuItem.Text = "工作台";
            this.PanelMenuItem.Click += new System.EventHandler(this.PanelMenuItem_Click);
            // 
            // ExceptMenuItem
            // 
            this.ExceptMenuItem.Name = "ExceptMenuItem";
            this.ExceptMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExceptMenuItem.Text = "异常处理";
            this.ExceptMenuItem.Click += new System.EventHandler(this.ExceptMenuItem_Click);
            // 
            // BatchMenuItem
            // 
            this.BatchMenuItem.Name = "BatchMenuItem";
            this.BatchMenuItem.Size = new System.Drawing.Size(136, 22);
            this.BatchMenuItem.Text = "批量转移";
            this.BatchMenuItem.Click += new System.EventHandler(this.BatchMenuItem_Click);
            // 
            // StatMenu
            // 
            this.StatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImpStatMenuItem,
            this.DetectStatMenuItem,
            this.StockStatMenuItem,
            this.MenuItemYearPlan});
            this.StatMenu.Name = "StatMenu";
            this.StatMenu.Size = new System.Drawing.Size(50, 21);
            this.StatMenu.Text = "统计";
            // 
            // ImpStatMenuItem
            // 
            this.ImpStatMenuItem.Name = "ImpStatMenuItem";
            this.ImpStatMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ImpStatMenuItem.Text = "量具统计";
            this.ImpStatMenuItem.Click += new System.EventHandler(this.ImpStatMenuItem_Click);
            // 
            // DetectStatMenuItem
            // 
            this.DetectStatMenuItem.Name = "DetectStatMenuItem";
            this.DetectStatMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DetectStatMenuItem.Text = "周检汇总";
            this.DetectStatMenuItem.Click += new System.EventHandler(this.DetectStatMenuItem_Click);
            // 
            // StockStatMenuItem
            // 
            this.StockStatMenuItem.Name = "StockStatMenuItem";
            this.StockStatMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StockStatMenuItem.Text = "库存盘点";
            this.StockStatMenuItem.Click += new System.EventHandler(this.StockStatMenuItem_Click);
            // 
            // MenuItemYearPlan
            // 
            this.MenuItemYearPlan.Name = "MenuItemYearPlan";
            this.MenuItemYearPlan.Size = new System.Drawing.Size(152, 22);
            this.MenuItemYearPlan.Text = "年度计划";
            this.MenuItemYearPlan.Visible = false;
            this.MenuItemYearPlan.Click += new System.EventHandler(this.MenuItemYearPlan_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(50, 21);
            this.windowsMenu.Text = "窗口";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cascadeToolStripMenuItem.Text = "层叠";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // DataMenuItem
            // 
            this.DataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupMenuItem,
            this.basicDataMenuItem});
            this.DataMenuItem.Name = "DataMenuItem";
            this.DataMenuItem.Size = new System.Drawing.Size(80, 21);
            this.DataMenuItem.Text = "数据维护";
            // 
            // BackupMenuItem
            // 
            this.BackupMenuItem.Name = "BackupMenuItem";
            this.BackupMenuItem.Size = new System.Drawing.Size(166, 22);
            this.BackupMenuItem.Text = "备份数据";
            this.BackupMenuItem.Click += new System.EventHandler(this.BackupMenuItem_Click);
            // 
            // basicDataMenuItem
            // 
            this.basicDataMenuItem.Name = "basicDataMenuItem";
            this.basicDataMenuItem.Size = new System.Drawing.Size(166, 22);
            this.basicDataMenuItem.Text = "基础数据维护";
            this.basicDataMenuItem.Click += new System.EventHandler(this.basicDataMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.LoginMenuItem,
            this.ChangePassMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(50, 21);
            this.toolsMenu.Text = "系统";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AboutMenuItem.Text = "关于本系统";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(151, 22);
            this.LoginMenuItem.Text = "重新登陆";
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // ChangePassMenuItem
            // 
            this.ChangePassMenuItem.Name = "ChangePassMenuItem";
            this.ChangePassMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ChangePassMenuItem.Text = "修改密码";
            this.ChangePassMenuItem.Click += new System.EventHandler(this.ChangePassMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 680);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.Text = "计量器具管理系统";
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.Shown += new System.EventHandler(this.MDIParent_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageMenu;
        private System.Windows.Forms.ToolStripMenuItem ListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImpPrintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecMenu;
        private System.Windows.Forms.ToolStripMenuItem PanelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExceptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImpStatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetectStatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockStatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemYearPlan;
    }
}



