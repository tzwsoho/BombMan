namespace 炸弹人地图编辑器
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("指针");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("出生点");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("墙");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("砖");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("出口");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("洼地");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("墙体", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("火焰");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("炸弹");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("鞋子");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("护甲");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("穿越炸弹");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("穿越墙体");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("遥控炸弹");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("生命");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("无敌");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("物品", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("怪物1");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("怪物2");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("怪物3");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("怪物4");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("怪物5");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("怪物6");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("怪物7");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("怪物8");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("怪物9");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("怪物", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miMap = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvwTools = new System.Windows.Forms.TreeView();
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.ppgAttribute = new System.Windows.Forms.PropertyGrid();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMap,
            this.miAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(724, 24);
            this.mnuMain.TabIndex = 0;
            // 
            // miMap
            // 
            this.miMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.miMap.Name = "miMap";
            this.miMap.Size = new System.Drawing.Size(59, 20);
            this.miMap.Text = "地图(&M)";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(189, 22);
            this.miNew.Text = "新建(&N)";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(189, 22);
            this.miOpen.Text = "打开(&O)";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Enabled = false;
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(189, 22);
            this.miSave.Text = "保存(&S)";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Enabled = false;
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.miSaveAs.Size = new System.Drawing.Size(189, 22);
            this.miSaveAs.Text = "另存为(&A)";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.miExit.Size = new System.Drawing.Size(189, 22);
            this.miExit.Text = "退出(&E)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(77, 20);
            this.miAbout.Text = "关于(&A)...";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 17);
            this.lblStatus.Text = "就绪...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(724, 490);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvwTools);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ppgAttribute);
            this.splitContainer2.Size = new System.Drawing.Size(241, 490);
            this.splitContainer2.SplitterDistance = 310;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvwTools
            // 
            this.tvwTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwTools.HideSelection = false;
            this.tvwTools.ImageIndex = 0;
            this.tvwTools.ImageList = this.imgIcons;
            this.tvwTools.Location = new System.Drawing.Point(0, 0);
            this.tvwTools.Name = "tvwTools";
            treeNode1.ImageKey = "指针.ico";
            treeNode1.Name = "指针";
            treeNode1.SelectedImageKey = "指针.ico";
            treeNode1.Text = "指针";
            treeNode2.Name = "出生点";
            treeNode2.Text = "出生点";
            treeNode3.ImageKey = "墙体_墙.ico";
            treeNode3.Name = "墙";
            treeNode3.SelectedImageKey = "墙体_墙.ico";
            treeNode3.Text = "墙";
            treeNode3.ToolTipText = "不可炸毁，不可穿越";
            treeNode4.ImageKey = "墙体_砖块.ico";
            treeNode4.Name = "砖";
            treeNode4.SelectedImageKey = "墙体_砖块.ico";
            treeNode4.Text = "砖";
            treeNode4.ToolTipText = "可炸毁，不可穿越(通常状态)";
            treeNode5.ImageKey = "墙体_出口.ico";
            treeNode5.Name = "出口";
            treeNode5.SelectedImageKey = "墙体_出口.ico";
            treeNode5.Text = "出口";
            treeNode6.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode6.Name = "洼地";
            treeNode6.Text = "洼地";
            treeNode6.ToolTipText = "穿越时减速，不可炸毁，可以穿越";
            treeNode7.ImageKey = "墙体.ico";
            treeNode7.Name = "墙体";
            treeNode7.SelectedImageKey = "墙体.ico";
            treeNode7.Text = "墙体";
            treeNode8.ImageKey = "物品_火焰.ico";
            treeNode8.Name = "火焰";
            treeNode8.SelectedImageKey = "物品_火焰.ico";
            treeNode8.Text = "火焰";
            treeNode8.ToolTipText = "火焰长度 + 1";
            treeNode9.ImageKey = "物品_炸弹.ico";
            treeNode9.Name = "炸弹";
            treeNode9.SelectedImageKey = "物品_炸弹.ico";
            treeNode9.Text = "炸弹";
            treeNode9.ToolTipText = "可放置炸弹数量 + 1";
            treeNode10.ImageKey = "物品_鞋子.ico";
            treeNode10.Name = "鞋子";
            treeNode10.SelectedImageKey = "物品_鞋子.ico";
            treeNode10.Text = "鞋子";
            treeNode10.ToolTipText = "行走速度增加";
            treeNode11.Name = "护甲";
            treeNode11.Text = "护甲";
            treeNode11.ToolTipText = "可免疫一次死亡";
            treeNode12.ImageKey = "物品_穿炸弹.ico";
            treeNode12.Name = "穿越炸弹";
            treeNode12.SelectedImageKey = "物品_穿炸弹.ico";
            treeNode12.Text = "穿越炸弹";
            treeNode12.ToolTipText = "玩家可以穿越炸弹行走";
            treeNode13.ImageKey = "物品_穿墙.ico";
            treeNode13.Name = "穿越墙体";
            treeNode13.SelectedImageKey = "物品_穿墙.ico";
            treeNode13.Text = "穿越墙体";
            treeNode13.ToolTipText = "玩家可以穿越砖块行走";
            treeNode14.ImageKey = "物品_遥控炸弹.ico";
            treeNode14.Name = "遥控炸弹";
            treeNode14.SelectedImageKey = "物品_遥控炸弹.ico";
            treeNode14.Text = "遥控炸弹";
            treeNode14.ToolTipText = "玩家可以在放置炸弹后按放置顺序手动引爆";
            treeNode15.Name = "生命";
            treeNode15.Text = "生命";
            treeNode15.ToolTipText = "玩家生命数量 + 1";
            treeNode16.Name = "无敌";
            treeNode16.Text = "无敌";
            treeNode16.ToolTipText = "玩家本局无敌状态";
            treeNode17.ImageKey = "物品.ico";
            treeNode17.Name = "物品";
            treeNode17.SelectedImageKey = "物品.ico";
            treeNode17.Text = "物品";
            treeNode18.Name = "怪物1";
            treeNode18.Text = "怪物1";
            treeNode18.ToolTipText = "普通怪物";
            treeNode19.Name = "怪物2";
            treeNode19.Text = "怪物2";
            treeNode19.ToolTipText = "行进速度快";
            treeNode20.Name = "怪物3";
            treeNode20.Text = "怪物3";
            treeNode20.ToolTipText = "可穿越炸弹";
            treeNode21.Name = "怪物4";
            treeNode21.Text = "怪物4";
            treeNode21.ToolTipText = "可穿越砖块";
            treeNode22.Name = "怪物5";
            treeNode22.Text = "怪物5";
            treeNode22.ToolTipText = "行进速度快，可穿越砖块和炸弹";
            treeNode23.Name = "怪物6";
            treeNode23.Text = "怪物6";
            treeNode23.ToolTipText = "行进速度快，会自动复活一次";
            treeNode24.Name = "怪物7";
            treeNode24.Text = "怪物7";
            treeNode24.ToolTipText = "行进速度快，可穿越砖块和炸弹，会自动复活一次";
            treeNode25.Name = "怪物8";
            treeNode25.Text = "怪物8";
            treeNode25.ToolTipText = "行进速度快，炸死会掉落物品";
            treeNode26.Name = "怪物9";
            treeNode26.Text = "怪物9";
            treeNode26.ToolTipText = "行进速度快，可穿越砖块和炸弹，会自动复活一次，炸死会掉落物品";
            treeNode27.ImageKey = "怪物.ico";
            treeNode27.Name = "怪物";
            treeNode27.SelectedImageKey = "怪物.ico";
            treeNode27.Text = "怪物";
            this.tvwTools.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode17,
            treeNode27});
            this.tvwTools.SelectedImageIndex = 0;
            this.tvwTools.ShowNodeToolTips = true;
            this.tvwTools.Size = new System.Drawing.Size(241, 310);
            this.tvwTools.TabIndex = 0;
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "指针.ico");
            this.imgIcons.Images.SetKeyName(1, "墙体.ico");
            this.imgIcons.Images.SetKeyName(2, "物品.ico");
            this.imgIcons.Images.SetKeyName(3, "怪物.ico");
            this.imgIcons.Images.SetKeyName(4, "墙体_出口.ico");
            this.imgIcons.Images.SetKeyName(5, "墙体_墙.ico");
            this.imgIcons.Images.SetKeyName(6, "墙体_砖块.ico");
            this.imgIcons.Images.SetKeyName(7, "物品_火焰.ico");
            this.imgIcons.Images.SetKeyName(8, "物品_穿墙.ico");
            this.imgIcons.Images.SetKeyName(9, "物品_穿炸弹.ico");
            this.imgIcons.Images.SetKeyName(10, "物品_鞋子.ico");
            this.imgIcons.Images.SetKeyName(11, "物品_遥控炸弹.ico");
            this.imgIcons.Images.SetKeyName(12, "物品_炸弹.ico");
            // 
            // ppgAttribute
            // 
            this.ppgAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppgAttribute.Location = new System.Drawing.Point(0, 0);
            this.ppgAttribute.Name = "ppgAttribute";
            this.ppgAttribute.Size = new System.Drawing.Size(241, 176);
            this.ppgAttribute.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 536);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "炸弹人地图编辑器 -- TZWSOHO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miMap;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvwTools;
        private System.Windows.Forms.PropertyGrid ppgAttribute;
        private System.Windows.Forms.ImageList imgIcons;
    }
}

