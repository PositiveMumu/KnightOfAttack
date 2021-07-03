// ****************************************************
//     文件：PlayerStats.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：#CreateTime#
//     功能：
// *****************************************************

using System;
using System.IO;
using LitJson;

public class PlayerStats
{
    //保存数据
    private PlayerBaseInfo playerInfo;
    
    //开始后更新数据
    public double attack;
    public double defence;
    public double attackSpeed;
    public double moveSpeed;

    public double CurrentAttack
    {
        get
        {
            return attack;
        }
        set
        {
            if (value < 1)
            {
                attack += playerInfo.BaseAttack * Math.Round(value, 2);
            }
            else
            {
                attack += value;
            }
        }
    }

    public double CurrentDefence
    {
        get
        {
            return defence;
        }
        set
        {
            if (value < 1)
            {
                defence += playerInfo.BaseDefence * Math.Round(value, 2);
            }
            else
            {
                defence += value;
            }
        }
    }

    public double CurrentAttackSpeed
    {
        get
        {
            return attackSpeed;
        }
        set
        {
            attackSpeed -= playerInfo.BaseAttackSpeed * Math.Round(value, 2);
        }
    }

    public double CurrentMoveSpeed
    {
        get
        {
            return moveSpeed;
        }
        set
        {
            moveSpeed -= playerInfo.BaseMoveSpeed * Math.Round(value, 2);
        }
    }

    public int Lv => playerInfo.Lv;

    public int Hp
    {
        get
        {
            return playerInfo.Hp;
        }
        set
        {
            if (playerInfo.Hp + value >= playerInfo.BaseHp)
            {
                playerInfo.Hp = playerInfo.BaseHp;
            }
            else if (playerInfo.Hp + value <= 0)
            {
                playerInfo.Hp = 0;
                //todo 触发死亡
            }
            else
            {
                playerInfo.Hp += value;
            }
        }
    }

    public float HpRate => (float) playerInfo.Hp / playerInfo.BaseHp;
    
    public int Exp
    {
        get
        {
            return playerInfo.Exp;
        }
        set
        {
            if (playerInfo.Exp + value >= playerInfo.BaseExp)
            {
                playerInfo.Exp = 0;
                //触发升级
            }
            else
            {
                playerInfo.Exp += value;
            }
        }
    }
    
    public float ExpRate => (float) playerInfo.Exp / playerInfo.BaseExp;

    public PlayerStats()
    {
        playerInfo = LoadData();
    }

    public void UpLevel()
    {
        string path = Consts.PlayerUpLevelFilePath.Replace("$", (Lv + 1).ToString());
        using (StreamReader sr = new StreamReader(path))
        {
            PlayerBaseInfo Uplevel = JsonMapper.ToObject<PlayerBaseInfo>(sr.ReadToEnd());

            playerInfo.BaseAttack = Uplevel.BaseAttack;
            playerInfo.BaseDefence = Uplevel.BaseDefence;
            playerInfo.BaseAttackSpeed = Uplevel.BaseAttack;
            playerInfo.BaseMoveSpeed = Uplevel.BaseMoveSpeed;

            playerInfo.Lv++;
            playerInfo.BaseHp = Uplevel.BaseHp;
            playerInfo.Hp = playerInfo.BaseHp;
            playerInfo.BaseExp = Uplevel.BaseExp;
            playerInfo.Exp = 0;
            
            //TODO 更新委托
        }
    }
    
    public PlayerBaseInfo LoadData()
    {
        using (StreamReader sr =new StreamReader(Consts.PlayerInfoFilePath))
        {
            return JsonMapper.ToObject<PlayerBaseInfo>(sr.ReadToEnd());
        }
    }

    public void SaveData()
    {
        using (StreamWriter sw =new StreamWriter(Consts.PlayerInfoFilePath,false))
        {
            sw.Write(JsonMapper.ToJson(playerInfo));
        }
    }

}
