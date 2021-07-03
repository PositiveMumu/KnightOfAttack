// ****************************************************
//     文件：EquipmentItem.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EquipmentItem : BaseItem
{
    public EquipmentTypes EquipmentType;
    public int Defence;
    public double MoveSpeed;
    public double AttackSpeed;
    public override void UseItem()
    {
        base.UseItem();
    }
}
