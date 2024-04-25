using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;




/// <summary>
///玩家操作记录 发送
/// </summary>
public partial class Core
{
    private List<VeriData> veriDatas = new List<VeriData>();
    private StringBuilder sb;
    
    
    /// <summary>
    /// 添加操作
    /// </summary>
    private void AddOperation()
    {
        VeriData veriData = new VeriData();
        veriDatas.Add(veriData);
    }

    
    /// <summary>
    /// 适时发给服务器，如某局内游戏完成时
    /// </summary>
    private void SendVeri()
    {
        GenerrateContent();
        HttpReq(ReqType.Operation, sb);
    }

    private void GenerrateContent()
    {
        //todo 生成与服务器交互的结构
        sb.Clear();
        sb.Append(string.Empty);
        
        
        veriDatas.Clear();
    }
    
}

public class VeriData
{
    private int SerialId;



}
