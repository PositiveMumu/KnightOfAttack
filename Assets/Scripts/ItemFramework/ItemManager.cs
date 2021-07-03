// ****************************************************
//     文件：ItemManager.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<BaseItem> itemList;
    public void InitItemFramework()
    {
        JsonMapper.RegisterImporter<ItemTypes, string>((ItemTypes input) => { return input.ToString(); });
        JsonMapper.RegisterImporter<string, ItemTypes>((string input) => { return (ItemTypes)Enum.Parse(typeof(ItemTypes),input); });
        
        JsonMapper.RegisterImporter<ItemChangeValueTypes, string>((ItemChangeValueTypes input) => { return input.ToString(); });
        JsonMapper.RegisterImporter<string, ItemChangeValueTypes>((string input) => { return (ItemChangeValueTypes)Enum.Parse(typeof(ItemChangeValueTypes),input); });

        JsonMapper.RegisterImporter<EquipmentTypes, string>((EquipmentTypes input) => { return input.ToString(); });
        JsonMapper.RegisterImporter<string, EquipmentTypes>((string input) => { return (EquipmentTypes)Enum.Parse(typeof(EquipmentTypes),input); });

        JsonMapper.RegisterImporter<WeaponTypes, string>((WeaponTypes input) => { return input.ToString(); });
        JsonMapper.RegisterImporter<string, WeaponTypes>((string input) => { return (WeaponTypes)Enum.Parse(typeof(WeaponTypes),input); });

        itemList = new List<BaseItem>();
        LoadConfig();
    }

    public void LoadConfig()
    {
        using (StreamReader sr= new StreamReader(Consts.ItemConfigPath))
        {
            string config = sr.ReadToEnd();
            JsonData jsonData = JsonMapper.ToObject(config);

            foreach (JsonData VARIABLE in jsonData)
            {
                ItemTypes type = (ItemTypes) Enum.Parse(typeof(ItemTypes), VARIABLE["ItemType"].ToString());
                switch (type)
                {
                    case ItemTypes.ConsumableItem:
                        itemList.Add(JsonMapper.ToObject<ConsumableItem>(VARIABLE.ToJson()));
                        break;
                    case ItemTypes.EquipmentItem:
                        itemList.Add(JsonMapper.ToObject<EquipmentItem>(VARIABLE.ToJson()));
                        break;
                    case ItemTypes.WeaponItem:
                        itemList.Add(JsonMapper.ToObject<WeaponItem>(VARIABLE.ToJson()));
                        break;
                    case ItemTypes.TaskItem:
                        itemList.Add(JsonMapper.ToObject<TaskItem>(VARIABLE.ToJson()));
                        break;
                    default:
                        Debug.LogError("解析失败");
                        break;
                }
            }
        }
    }
}
