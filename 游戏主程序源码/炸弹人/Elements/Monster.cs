using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 怪物
    /// </summary>
    class Monster : Cell
    {
        public Monster(int nX, int nY) : base(nX, nY)
        {
            m_nCellType = enCellType.enCellType_Monster;
        }

        override protected void OnDraw()
        {

        }
    }
}
