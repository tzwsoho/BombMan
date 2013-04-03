using System;
using System.Collections;
using System.Collections.Generic;
using 炸弹人.Elements;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 当前关卡地图
    /// </summary>
    class Map
    {
        // 所有格子
        private List<Cell> m_AllCells = new List<Cell>();
        public List<Cell> Cells
        {
            get
            {
                return m_AllCells;
            }
        }

        // 当前可视格子
        private List<Cell> m_VisibleCells = new List<Cell>();
        public List<Cell> VisibleCells
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
    }
}
