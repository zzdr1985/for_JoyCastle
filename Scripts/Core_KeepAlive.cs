using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 玩家在线状态 重连事件
/// </summary>
public partial class Core
{
    /// <summary>
    /// 在线flag
    /// </summary>
    private bool isAlive = false;

    /// <summary>
    /// 心跳间隔时间查看玩家是否在线
    /// </summary>
    void Updat_Heart()
    {
        bool preFlag = isAlive;
        
        
        //todo 心跳间隔时间查看玩家是否在线



        //重连
        if (!preFlag && isAlive)
        {
            ReAlive();
        }
    }

    private void ReAlive()
    {
        ReAlive_PlayerData();


    }
}
