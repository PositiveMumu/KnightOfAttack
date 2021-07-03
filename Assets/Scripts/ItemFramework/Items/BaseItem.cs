// ****************************************************
//     文件：ItemInfo.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public class BaseItem
{
    [NonSerialized]
    public Sprite itemIcon;

    public int ItemID;
    public string ItemIconPath;
    public string ItemName;
    public ItemTypes ItemType;
    public string ItemDescription;
    public int ItemStackSize;
    public int ItemBuyPrice;
    public int ItemSellPrice;
    
    // public string ItemIconPath
    // {
    //     get => itemIconPath;
    //     set => itemIconPath = value;
    // }
    //
    // public string ItemName
    // {
    //     get => itemName;
    //     set => itemName = value;
    // }
    //
    // public ItemTypes ItemType
    // {
    //     get => itemType;
    //     set => itemType = value;
    // }
    //
    // public string ItemDescription
    // {
    //     get => itemDescription;
    //     set => itemDescription = value;
    // }
    //
    // public int ItemStackSize
    // {
    //     get => itemStackSize;
    //     set => itemStackSize = value;
    // }
    //
    // public int ItemBuyPrice
    // {
    //     get => itemBuyPrice;
    //     set => itemBuyPrice = value;
    // }
    //
    // public int ItemSellPrice
    // {
    //     get => itemSellPrice;
    //     set => itemSellPrice = value;
    // }
    
    public virtual void UseItem(){}
}