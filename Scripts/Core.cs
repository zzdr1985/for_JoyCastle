using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 题
/*
JoyCastle 资深前端岗位测试题

感谢您关注乐城堡科技！如下是资深前端岗位的笔试题，测试时间两天之内。如无不便，请您使用 github.com 提交答案，回复 git 代码库地址即可。

现要为一款休闲游戏开发网络层框架。请结合你的经历分析：

1）有哪些常用的网络层框架方案？
你可以参考Homescape，Bingo Blitz，Monopoly Go，开心消消乐这些热门游戏来选择合适的方案。
2）基于你选择的方案，网络层框架应该实现哪些功能？
3）根据你的经验，网络框架还有哪些痛点需要考虑？
4）请用代码实现你的方案设计（可精简细节代码，但需要体现你的设计要点）。

感谢您的时间，祝好运！
 * 
 */
#endregion
    

#region 思路
/*
 *玩过这两款 - Monopoly Go，开心消消乐 加上 博彩类的bingo 为背景。
 * 该类游戏很重要的几点
 * 1.联网登录
 * 2.断网可玩
 * 3.防作弊
 *
 *介于以上几点，该网络模块的数据传输有以下三种方式，游戏内可能同时存在
 * 1。登录时拉取整块玩家数据作为缓存，定时，断网重连后及时传输  玩家数据给服务器查看是否异常 -----------  Core_PlayerData
 * 2。重要数据更新时，如涉及货币，关卡进度，与其他玩家交互等等，需要联网请求。 -------------     Core_Important
 * 3. 关键数据的校验：对重要数据的操作流程，来源等 （详细程度要求可溯源），适时传给服务器。   --------------   Core_Veri
 * 
 *如出现数据异常，可对玩家进行T下线，回档，封号等操作。
 * 
 */
#endregion
    
    
public partial class Core
{
    void Update()
    {
        Updat_Heart();
        Updat_PlayerData();
        
        
    }
}