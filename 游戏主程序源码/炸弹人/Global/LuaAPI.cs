using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using LuaInterface;

namespace 炸弹人.Global
{
    class LuaAPI
    {
        static Lua m_LuaVM = null;
        static LuaAPI m_LuaAPI = null;
        static Configuration m_Config = null;

        static string[] arrEventsList = {
            "OnGameBegin",                              // 游戏开始
            "OnPutBomb",                                // 放置炸弹，参数：玩家 ID，炸弹 ID
            "OnExplode",                                // 炸弹爆炸，参数：玩家 ID，炸弹 ID
            "OnWallDestroy",                            // 墙体被炸烂，参数：玩家 ID，炸弹 ID，墙体 ID
            "OnMonsterDie",                             // 怪物被炸死，参数：炸弹 ID，怪物类型，怪物 ID
            "OnPlayerDie",                              // 玩家死亡，参数：玩家 ID，死亡原因(0-怪物杀死，1-炸弹炸死)
            "OnTimeUp"                                  // 时间已到
        };

        static string[] arrAPIList = {
            // 通用
            "ArrangeLayout",                            // 开始关卡时排列本关布局

            // 墙体
            "PutWallToPoint",                           // 将墙体放置在某点
            "DestroyWallAtPoint",                       // 将某点的墙体摧毁

            // 火焰
            "GetFireLength",                            // 获取火焰长度(无限 == 0)
            "SetFireLength",                            // 设置火焰长度(无限 == 0)

            // 炸弹
            "GetLeftBombCount",                         // 获取剩余可放置的炸弹数量
            "GetTotalBombCount",                        // 获取总共可放置的炸弹数量
            "SetTotalBombCount",                        // 设置总共可放置的炸弹数量
            "GetPlayerBombType",                        // 获取玩家放置炸弹类型：0-普通，1-定时炸弹
            "SetPlayerBombType",                        // 设置炸弹类型：0-普通，1-定时炸弹

            // 行走
            "GetMoveSpeed",                             // 获取行走速度
            "SetMoveSpeed",                             // 设置行走速度
            "MoveToPoint"                               // 直接移动至某点(必须为可行走点)
        };

        static public void InitLua()
        {
            if (m_LuaVM == null)
            {
                m_LuaVM = new Lua();
            }

            if (m_LuaAPI == null)
            {
                m_LuaAPI = new LuaAPI();
            }

            if (m_Config == null)
            {
                m_Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            }

            // 注册 C# API
            foreach (string szAPI in arrAPIList)
            {
                m_LuaVM.RegisterFunction(szAPI, m_LuaAPI, m_LuaAPI.GetType().GetMethod(szAPI));
            }

            // 加载配置文件
            if (!m_Config.HasFile)
            {
                m_Config.AppSettings.Settings.Add("LevelCount", "0");
                m_Config.Save();
            }

            try
	        {
                // 获取关卡数量
                int nLevelCount = int.Parse(m_Config.AppSettings.Settings["LevelCount"].Value);

                // 生成函数事件列表
                string szRegString = "";
                foreach (string szFunc in arrEventsList)
                {
                    szRegString += szFunc + "_{0} = " + szFunc + "\n";
                }

                // 注册关卡事件函数
                for (int i = 1; i <= nLevelCount; i++)
			    {
                    string szLevel = m_Config.AppSettings.Settings["Level_" + i.ToString()].Value;
                    string szLuaFile = Application.StartupPath + "\\" + szLevel;
                    if (!File.Exists(szLuaFile))
                    {
                        MessageBox.Show("找不到关卡文件 '" + szLuaFile + "'！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    StreamReader sr = new StreamReader(szLuaFile);
                    string szLuaString = sr.ReadToEnd();
                    sr.Close();

                    string szRegEvents = string.Format(szRegString, i);
                    if (m_LuaVM.LoadString(szRegEvents, null) == null)
                    {
                        MessageBox.Show("加载文件 '" + szLuaFile + "' 失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
			    }
	        }
	        catch (Exception ex)
	        {
        		MessageBox.Show(ex.ToString());
                return;
	        }
        }

        static public void ReleaseLua()
        {
            if (m_LuaVM != null)
            {
                m_LuaVM.Dispose();
                m_LuaVM = null;
            }
        }

        #region 通用

        static public void ArrangeLayout(LuaTable ltLayout)
        {
            return;
        }

        #endregion

        #region 墙体

        static public bool PutWallToPoint(int nWallType)
        {
            return true;
        }

        static public bool DestroyWallAtPoint(int nX, int nY)
        {
            return true;
        }

        #endregion

        #region 火焰

        static public int GetFireLength()
        {
            return -1;
        }

        static public bool SetFireLength(int nLength)
        {
            return true;
        }

        #endregion

        #region 炸弹

        static public int GetLeftBombCount(int nPlayerID)
        {
            return 0;
        }

        static public int GetTotalBombCount(int nPlayerID)
        {
            return 0;
        }

        static public bool SetTotalBombCount(int nPlayerID, int nBombs)
        {
            return true;
        }

        static public int GetPlayerBombType(int nPlayerID)
        {
            return 0;
        }

        static public bool SetPlayerBombType(int nPlayerID)
        {
            return true;
        }

        #endregion

        #region 行走

        static public int GetMoveSpeed(int nPlayerID)
        {
            return 0;
        }

        static public bool SetMoveSpeed(int nPlayerID)
        {
            return true;
        }

        static public bool MoveToPoint(int nPlayerID, int nX, int nY)
        {
            return true;
        }

        #endregion
    }
}
