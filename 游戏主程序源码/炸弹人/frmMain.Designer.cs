namespace 炸弹人
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miOne = new System.Windows.Forms.ToolStripMenuItem();
            this.miTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGame,
            this.miAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(592, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miGame
            // 
            this.miGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOne,
            this.miTwo,
            this.toolStripSeparator1,
            this.miExit});
            this.miGame.Name = "miGame";
            this.miGame.Size = new System.Drawing.Size(59, 20);
            this.miGame.Text = "游戏(&G)";
            // 
            // miOne
            // 
            this.miOne.Image = global::炸弹人.Properties.Resources.玩家1;
            this.miOne.Name = "miOne";
            this.miOne.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.miOne.Size = new System.Drawing.Size(153, 22);
            this.miOne.Text = "单人游戏(&S)";
            this.miOne.Click += new System.EventHandler(this.miOne_Click);
            // 
            // miTwo
            // 
            this.miTwo.Image = global::炸弹人.Properties.Resources.玩家2;
            this.miTwo.Name = "miTwo";
            this.miTwo.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miTwo.Size = new System.Drawing.Size(153, 22);
            this.miTwo.Text = "双人游戏(&D)";
            this.miTwo.Click += new System.EventHandler(this.miTwo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.miExit.Size = new System.Drawing.Size(153, 22);
            this.miExit.Text = "退出(&E)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(77, 20);
            this.miAbout.Text = "关于...(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(167, 17);
            this.lblStatus.Text = "F2 - 单人游戏/F3 - 双人游戏";
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 24);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(592, 379);
            this.pnlBack.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 425);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "炸弹人 -- TZWSOHO";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miGame;
        private System.Windows.Forms.ToolStripMenuItem miOne;
        private System.Windows.Forms.ToolStripMenuItem miTwo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pnlBack;
    }
}

