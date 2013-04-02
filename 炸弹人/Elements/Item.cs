using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 物品
    /// </summary>
    class Item : Cell
    {
        public Item(int nX, int nY) : base(nX, nY)
        {
            m_nCellType = enCellType.enCellType_Item;
        }

        override protected void OnDraw()
        {

        }
    }
}
