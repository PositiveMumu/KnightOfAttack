// ****************************************************
//     文件：WeaponItem.cs
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
public class WeaponItem : BaseItem
{
    public WeaponTypes WeaponType;
    public int Attack;
    public int AttackSpeed;
    public int Defence;
    public override void UseItem()
    {
        base.UseItem();
    }
}
