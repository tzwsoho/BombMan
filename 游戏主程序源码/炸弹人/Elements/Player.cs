using System;
using System.Drawing;
using 炸弹人.Global;
using 炸弹人.Properties;

namespace 炸弹人.Elements
{
    /// <summary>
    /// 玩家
    /// </summary>
    class Player : Cell
    {
        #region 属性

        // 各项属性
        private PlayerAttribute m_Attribute = new PlayerAttribute();
        public PlayerAttribute Attribute
        {
            get
            {
                return m_Attribute;
            }

            set
            {
                if (value.m_nSpeed <= 0)
                    throw new ArgumentException("速度数值有误");

                if (value.m_nHP > value.m_nHPMax)
                    throw new ArgumentException("最大血量值不能小于当前血量值");

                if ((value.m_nHP <= 0) ||
                    (value.m_nHPMax <= 0))
                    throw new ArgumentException("血量值有误");

                if (value.m_nFlameLength < 0)
                    throw new ArgumentException("火焰长度值有误");

                if (value.m_nPutBombs > value.m_nBombs)
                    throw new ArgumentException("已放置炸弹数不能超过可放置炸弹数");

                if (value.m_nAmor < 0)
                    throw new ArgumentException("护甲值有误");

                if (value.m_nLife < 0)
                    throw new ArgumentException("剩余生命值有误");

                m_Attribute = value;
            }
        }

        #endregion

        #region 构造函数

        public Player(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Player;
        }

        public Player(LogicCoord coord, float nSpeed, int nHP) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Player;

            Attribute = new PlayerAttribute(nSpeed, nHP);
        }

        #endregion

        #region 事件

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);

        }

        #endregion
    }
}
