using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using 炸弹人.Elements;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 当前关卡逻辑地图
    /// </summary>
    class Map
    {
        #region 属性

        // 所有格子
        private Dictionary<LogicCoord, Cell> m_AllCells = new Dictionary<LogicCoord, Cell>();
        public Dictionary<LogicCoord, Cell> Cells
        {
            get
            {
                return m_AllCells;
            }
        }

        // 当前可视格子
        private Dictionary<LogicCoord, Cell> m_VisibleCells = new Dictionary<LogicCoord, Cell>();
        public Dictionary<LogicCoord, Cell> VisibleCells
        {
            get
            {
                return m_VisibleCells;
            }
        }

        // 可视区的地图宽度(单位：格)
        private int m_nVisibleWidth = 2;
        public int VisibleWidth
        {
            get
            {
                return m_nVisibleWidth;
            }

            set
            {
                if (value < 2)
                    throw new ArgumentException("错误的地图显示宽度值");

                m_nVisibleWidth = value;
            }
        }

        // 可视区的地图高度(单位：格)
        private int m_nVisibleHeight = 2;
        public int VisibleHeight
        {
            get
            {
                return m_nVisibleHeight;
            }

            set
            {
                if (value < 2)
                    throw new ArgumentException("错误的地图显示高度值");

                m_nVisibleHeight = value;
            }
        }

        // 地图宽度(单位：格)
        private int m_nWidth = 2;
        public int Width
        {
            get
            {
                return m_nWidth;
            }

            set
            {
                if (value < 2)
                    throw new ArgumentException("错误的地图宽度值");

                m_nWidth = value;
                m_nHeight = (m_AllCells.Count - 1) / m_nWidth + 1;
            }
        }

        // 地图高度(单位：格)
        private int m_nHeight = 0;
        public int Height
        {
            get
            {
                return m_nHeight;
            }
        }

        #endregion

        #region 事件

        public bool OnMove(Cell cell)
        {
            switch (cell.CellType)
            {
                case enCellType.enCellType_Player: // 玩家

                    break;

                case enCellType.enCellType_Monster: // 怪物

                    break;

                default: // 其它格子没有移动事件
                    return false;
            }

            return true;
        }

        #endregion

        #region UI 相关函数

        static public void OnDraw(Panel pnlSrc)
        {
            Graphics grp = Graphics.FromHwnd(pnlSrc.Handle);
            grp.CopyFromScreen(0, 0, 640, 480, pnlSrc.Size);


        }

        #endregion
    }
}
