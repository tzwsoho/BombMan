using System;

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
}
