using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 炸弹
    /// </summary>
    class Bomb : Cell
    {
        public Bomb(int nX, int nY) : base(nX, nY)
        {
            m_nCellType = enCellType.enCellType_Bomb;
        }

        override protected void OnDraw()
        {

        }
    }
}
