using System;
using System.Drawing;
using 炸弹人.Global;
using 炸弹人.Properties;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 炸弹
    /// </summary>
    class Bomb : Cell
    {
        public Bomb(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Bomb;
        }

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);

            grp.DrawIcon(Resources.物品_炸弹, Rectangle.Round(grp.Clip.GetBounds(grp)));
        }
    }
}
