using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 地图上的一格
    /// 所有元素类的基类
    /// </summary>
    class Cell
    {
        #region 属性

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
                if (!Enum.IsDefined(typeof(enCellType), value))
                    throw new ArgumentException("错误的格子类型");

                m_nCellType = value;
            }
        }

        // 当前格子坐标
        protected LogicCoord m_CurCoord = new LogicCoord();
        public LogicCoord CurCoord
        {
            get
            {
                return m_CurCoord;
            }

            set
            {
                if (value.m_nX <= 0)
                    throw new ArgumentException("非法的 X 坐标");

                if (value.m_nY <= 0)
                    throw new ArgumentException("非法的 Y 坐标");

                m_CurCoord = value;
            }
        }

        // 原格子坐标
        protected LogicCoord m_PrevCoord = new LogicCoord();
        public LogicCoord PrevCoord
        {
            get
            {
                return m_PrevCoord;
            }

            set
            {
                if (value.m_nX <= 0)
                    throw new ArgumentException("非法的 X 坐标");

                if (value.m_nY <= 0)
                    throw new ArgumentException("非法的 Y 坐标");

                m_PrevCoord = value;
            }
        }

        // 当前显示的坐标
        protected ShowCoord m_ShowCoord = new ShowCoord();
        public ShowCoord ShowCoord
        {
            get
            {
                return m_ShowCoord;
            }
        }

        // 当前显示的格子大小
        protected ShowSize m_ShowSize = new ShowSize();
        public ShowSize ShowSize
        {
            get
            {
                return m_ShowSize;
            }
        }

        #endregion

        public Cell(LogicCoord coord)
        {
            CurCoord = coord;

            m_nCellType = enCellType.enCellType_Unused;
        }

        #region 事件

        // 作图
        virtual protected void OnDraw(Graphics grp)
        {
            grp.SetClip(new RectangleF(m_ShowCoord.m_fX, m_ShowCoord.m_fY, m_ShowSize.m_fWidth, m_ShowSize.m_fHeight));
        }

        #endregion
    }
}
