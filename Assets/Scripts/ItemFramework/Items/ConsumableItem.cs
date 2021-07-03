// ****************************************************
//     文件：ConsumableItem.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public class ConsumableItem : BaseItem
{

    private double CoolDownTime;
    private bool ConsumableOverTime;
    private double Duration;
    
    
    public List<ItemEffect> ItemEffectList;
    public override void UseItem()
    {
        
    }
}
