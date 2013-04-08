using System;
using System.Collections.Generic;
using 炸弹人.Elements;

namespace 炸弹人.Global
{
    /// <summary>
    /// 游戏逻辑处理
    /// </summary>
    class GameLogic
    {
        // 当前关卡全图
        public Map m_Map;

        /// <summary>
        /// 初始化关卡地图
        /// </summary>
        public void InitMap(string szMap, int nWidth)
        {
            m_Map = new Map();

            int i = 0;
            while (i < szMap.Length)
            {
                Cell cell = null;
                if (szMap[i] == '0') // 可行走区域
                {
                    cell = new Cell(new LogicCoord(i % nWidth, i / nWidth));
                    cell.CellType = enCellType.enCellType_None;
                }
                else if (szMap[i] == '1') // 墙体
                {
                    cell = new Wall(new LogicCoord(i % nWidth, i / nWidth));
                }
                else if (szMap[i] == '2') // 怪物
                {
                    cell = new Monster(new LogicCoord(i % nWidth, i / nWidth));
                }

                m_Map.Cells.Add(cell.CurCoord, cell);
            }

            m_Map.Width = nWidth;
        }
    }
}
