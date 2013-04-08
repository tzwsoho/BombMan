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
        #region 属性

        // 各项属性
        private CommonAttribute m_Attribute = new CommonAttribute();
        public CommonAttribute Attribute
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

                m_Attribute = value;
            }
        }

        // 上次移动 AI 时间
        private long m_tLastAI = 0;
        public long LastAI
        {
            get
            {
                return m_tLastAI;
            }
        }

        #endregion

        #region 构造函数

        public Monster(LogicCoord coord) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Monster;
        }

        public Monster(LogicCoord coord, float nSpeed, int nHP) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Monster;

            Attribute = new CommonAttribute(nSpeed, nHP, false, false);
        }

        public Monster(LogicCoord coord, float nSpeed, int nHP, bool bCanThroughBrick, bool bCanThroughBombs) : base(coord)
        {
            m_nCellType = enCellType.enCellType_Monster;

            Attribute = new CommonAttribute(nSpeed, nHP, bCanThroughBrick, bCanThroughBombs);
        }

        #endregion

        #region 事件

        // 怪物移动 AI
        public void MonsterMove()
        {
            const long MONSTER_AI_INTERVAL = 2 * TimeSpan.TicksPerSecond; // 每 2 秒刷新一次 AI
            
            long nNow = DateTime.Now.Ticks;
            if (nNow - m_tLastAI > MONSTER_AI_INTERVAL)
            {
                m_tLastAI = nNow;

                Array arrFaces = Enum.GetValues(typeof(enFace));
                enFace? nFace = arrFaces.GetValue(new Random().Next(arrFaces.Length)) as enFace?;
                if (nFace == null)
                    return;

                m_Attribute.m_nFace = (enFace)nFace;
            }


        }

        override protected void OnDraw(Graphics grp)
        {
            base.OnDraw(grp);


        }

        #endregion
    }
}
