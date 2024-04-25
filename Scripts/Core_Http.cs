using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// http
/// </summary>
public partial class Core
{
    private Resp HttpReq(ReqType reqType , object oooo)
    {
        Resp resp = new Resp();
        return resp;
    }
}

public enum ReqType
{
    None,
    //联网操作
    Normal,
    //定时传输玩家数据
    PlayerData,
    //对重要操作的流程校验
    Operation
}



public class Req
{
    
}

public class Resp
{
    private bool IsOk;
    private int errcode;
}