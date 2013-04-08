using System;
using System.Runtime.InteropServices;

namespace 炸弹人.Global
{
    // 格子类型
    enum enCellType
    {
        enCellType_None,                    // 没有放置元素
        enCellType_Unused,                  // 没有使用
        enCellType_Wall,                    // 墙体
        enCellType_Bomb,                    // 炸弹
        enCellType_Item,                    // 物品
        enCellType_Flame,                   // 火焰
        enCellType_Player,                  // 玩家
        enCellType_Monster,                 // 怪物
    }

    // 墙体类型
    enum enWallType
    {
        enWallType_Block,                   // 不可炸毁，不可穿越
        enWallType_Brick,                   // 可以炸毁，不可穿越(通常状态)
        enWallType_Exit,                    // 关卡出口
        //enWallType_Depression,              // 洼地(穿越时减速，不可炸毁)
    }

    // 炸弹类型
    enum enBombType
    {
        enBombType_Normal,                  // 普通炸弹
        enBombType_Remote,                  // 遥控炸弹
    }

    // 移动方向
    enum enFace
    {
        enFace_Stop,                        // 静止
        enFace_Up,                          // 向上移动
        enFace_Right,                       // 向右移动
        enFace_Down,                        // 向下移动
        enFace_Left,                        // 向左移动
    }

    // 逻辑坐标
    struct LogicCoord
    {
        public int m_nX;                    // X 坐标
        public int m_nY;                    // Y 坐标

        public LogicCoord(int nX, int nY)
        {
            m_nX = nX;
            m_nY = nY;
        }
    }

    // 显示坐标
    struct ShowCoord
    {
        public float m_fX;                  // X 坐标
        public float m_fY;                  // Y 坐标

        public ShowCoord(float fX, float fY)
        {
            m_fX = fX;
            m_fY = fY;
        }
    }

    // 显示尺寸
    struct ShowSize
    {
        public float m_fWidth;              // 宽度
        public float m_fHeight;             // 高度

        public ShowSize(float fWidth, float fHeight)
        {
            m_fWidth = fWidth;
            m_fHeight = fHeight;
        }
    }

    // 玩家和怪物通用属性
    class CommonAttribute
    {
        public float m_nSpeed;                      // 行走速度
        public int m_nHP;                           // 当前血量
        public int m_nHPMax;                        // 最大血量值
        public bool m_bCanThroughBrick;             // 是否可穿墙
        public bool m_bCanThroughBombs;             // 是否可穿越炸弹
        public enFace m_nFace;                      // 移动方向

        public CommonAttribute()
        {
            m_nSpeed = 1.0f;
            m_nHP = 1;
            m_nHPMax = 1;
            m_bCanThroughBrick = false;
            m_bCanThroughBombs = false;
            m_nFace = enFace.enFace_Stop;
        }

        public CommonAttribute(float nSpeed, int nHP, bool bThroughBrick, bool bThroughBombs)
        {
            m_nSpeed = nSpeed;
            m_nHP = nHP;
            m_nHPMax = nHP;
            m_bCanThroughBrick = bThroughBrick;
            m_bCanThroughBombs = bThroughBombs;
            m_nFace = enFace.enFace_Stop;
        }
    }

    // 玩家属性
    class PlayerAttribute : CommonAttribute
    {
        public int m_nFlameLength;                  // 炸弹火焰长度(0 为无限长)
        public int m_nBombs;                        // 可放置的炸弹数量
        public int m_nPutBombs;                     // 已放置的炸弹数量
        public bool m_bIsRemoteBomb;                // 玩家是否拥有遥控炸弹
        public int m_nAmor;                         // 当前护甲值
        public int m_nLife;                         // 当前剩余生命

        public PlayerAttribute() : base()
        {
            m_nFlameLength = 1;
            m_nBombs = 1;
            m_nPutBombs = 0;
            m_bIsRemoteBomb = false;
            m_nAmor = 0;
            m_nLife = 3;
        }

        public PlayerAttribute(float nSpeed, int nHP) : this()
        {
            m_nSpeed = nSpeed;
            m_nHP = nHP;
            m_nHPMax = nHP;
        }
    }
}
