// ****************************************************
//     文件：GameRoot.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<ItemManager>().InitItemFramework();
        PlayerStats ps = new PlayerStats();
        ps.UpLevel();
    }
}
