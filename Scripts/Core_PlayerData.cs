using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 适时传送非重要玩家数据
/// </summary>
public partial class Core
{
    private PlayerData _playerData;
    
    //上次发送时间
    private long lastSendTimeStamp;

    private long Now;
    
    /// <summary>
    /// 登录拿取玩家数据
    /// </summary>
    /// <param name="loginDatas"></param>
    public void OnLogin(object loginDatas)
    {
        _playerData = new PlayerData(loginDatas);


    }

    private void Updat_PlayerData()
    {
        //todo 间隔x时间 传输玩家数据
        
        
        SendPlayerData();
    }

    private void ReAlive_PlayerData()
    {
        //断线重连时，发一次
        SendPlayerData();
    }
    
    
    private void SendPlayerData()
    {
        //todo 连续两次传输间隔过短
        
        
        if (isAlive)
        {
            HttpReq(ReqType.PlayerData, _playerData);

            lastSendTimeStamp = Now;
        }
    }
}

public class PlayerData
{
    public PlayerData(object obj)
    {
        
    }
}
