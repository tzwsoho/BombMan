using System;
using System.Windows.Forms;

namespace 炸弹人地图编辑器
{
    public partial class frmAttributes : Form
    {
        public frmAttributes()
        {
            InitializeComponent();
        }

        #region 属性

        // 地图宽度
        private int m_nWidth;
        public int Width
        {
            get
            {
                return m_nWidth;
            }
        }

        // 地图高度
        private int m_nHeight;
        public int Height
        {
            get
            {
                return m_nHeight;
            }
        }

        #endregion

        #region 控件事件

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            m_nWidth = (int)nudWidth.Value;
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            m_nHeight = (int)nudHeight.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
