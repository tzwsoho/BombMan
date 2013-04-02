using System;
using System.Drawing;
using 炸弹人.Global;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 玩家
    /// </summary>
    class Player : Cell
    {
        public Player(int nX, int nY) : base(nX, nY)
        {
            m_nCellType = enCellType.enCellType_Player;
        }

        override protected void OnDraw()
        {

        }
    }
}
