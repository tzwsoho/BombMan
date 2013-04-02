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
        public Flame(int nX, int nY) : base(nX, nY)
        {
            m_nCellType = enCellType.enCellType_Flame;
        }

        override protected void OnDraw()
        {
            
        }
    }
}
