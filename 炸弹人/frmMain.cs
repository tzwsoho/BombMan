using System;
using System.Windows.Forms;
using 炸弹人.Global;

namespace 炸弹人
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            LuaAPI.InitLua();
        }

        private void miOne_Click(object sender, EventArgs e)
        {

        }

        private void miTwo_Click(object sender, EventArgs e)
        {

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("炸弹人\n\n制作人：TZWSOHO\n制作日期：2013-04-02\n\n本游戏采用 C# + Lua 脚本设计，源码可用 Git 在以下地址下载：\n", "关于炸弹人 ...");
        }
    }
}
