using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 重要数据
/// </summary>
public partial class Core
{
    private Resp ImportantHandle(object oooo)
    {
        return HttpReq(ReqType.Normal, oooo);
    }
}
