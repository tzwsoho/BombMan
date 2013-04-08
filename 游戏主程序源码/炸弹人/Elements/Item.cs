using System;
using System.Drawing;
using 炸弹人.Global;
using 炸弹人.Properties;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 物品
    /// </summary>
    class Item : Cell
    {
        public Item(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Item;
        }

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);

            Image imgItem = Resources.ResourceManager.GetObject("") as Image;
        }
    }
}
