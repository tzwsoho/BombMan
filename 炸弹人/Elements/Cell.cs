using System;
using System.Drawing;
using 炸弹人格子;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 地图上的一格
    /// 所有元素类的基类
    /// </summary>
    class Cell
    {
        // 格子对应的 Block 控件
        protected Block m_Block = new Block();

        // 格子类型
        protected enCellType m_nCellType;
        public enCellType CellType
        {
            get
            {
                return m_nCellType;
            }

            set
            {
                if (!Enum.IsDefined(enCellType.enCellType_None.GetType(), value))
                    throw new ArgumentException("错误的格子类型");

                m_nCellType = value;
            }
        }

        // 格子 X 坐标
        protected int m_nX = 0;
        public int X
        {
            get
            {
                return m_nX;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("非法的 X 坐标");

                m_nX = value;
            }
        }

        // 格子 X 坐标
        protected int m_nY = 0;
        public int Y
        {
            get
            {
                return m_nY;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("非法的 Y 坐标");

                m_nY = value;
            }
        }

        public Cell(int nX, int nY)
        {
            X = nX;
            Y = nY;

            m_nCellType = enCellType.enCellType_Unused;
        }

        // 作图
        virtual protected void OnDraw()
        {
            Graphics grp = Graphics.FromHwnd(m_Block.Handle);
            grp.Clear(m_Block.BackColor);
            grp.Dispose();
        }
    }
}
