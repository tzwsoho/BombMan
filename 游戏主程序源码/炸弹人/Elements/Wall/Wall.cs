using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 砖块
    /// </summary>
    class Wall : Cell
    {
        public Wall(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Wall;
        }

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);


        }
    }
}
