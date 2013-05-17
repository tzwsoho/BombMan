using System;
using System.Windows.Forms;

namespace 炸弹人地图编辑器
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region 过程

        private void InitMap(int nWidth, int nHeight)
        {
            
        }

        #endregion

        #region 控件事件

        private void frmMain_Load(object sender, EventArgs e)
        {
            tvwTools.ExpandAll();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            frmAttributes frmAttr = new frmAttributes();
            if (frmAttr.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {

        }

        private void miSave_Click(object sender, EventArgs e)
        {

        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            const string szAbout = "炸弹人地图编辑器\n\n制作人：TZWSOHO\n" +
                                   "制作日期：2013-04-03\n\n" +
                                   "源码可用 Git 在以下地址下载：\n" +
                                   "https://github.com/tzwsoho/BombMan.git";
            MessageBox.Show(szAbout, "关于炸弹人地图编辑器 ...");
        }

        #endregion
    }
}
