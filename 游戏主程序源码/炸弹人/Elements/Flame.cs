using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 火焰
    /// </summary>
    class Flame : Cell
    {
        public Flame(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Flame;
        }

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);

           
        }
    }
}
