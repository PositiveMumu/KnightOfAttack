// ****************************************************
//     文件：Consts.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consts
{
    public static readonly string ItemConfigPath = Application.streamingAssetsPath + "/ItemConfig.json";
#if UNITY_EDITOR
    public static readonly string PlayerInfoFilePath = Application.streamingAssetsPath + "/Player.json";
    public static readonly string PlayerUpLevelFilePath = Application.streamingAssetsPath + "/PlayerUpLevel_$.json";
#else
    public static readonly string PlayerInfoFilePath = Application.persistentDataPath + "/Player.json";
    public static readonly string PlayerUpLevelFilePath = Application.persistentDataPath + "/PlayerUpLevel_$.json";
#endif
}
