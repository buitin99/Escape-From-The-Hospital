using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pref 
{
    public static int CurPlayerId
    {
        set => PlayerPrefs.SetInt(PrefConst.CUR_PLAYER_ID, value);
        get => PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID);
    }

    public static int Coins
    {
        set => PlayerPrefs.SetInt(PrefConst.COINS_KEY,value);
        get => PlayerPrefs.GetInt(PrefConst.COINS_KEY);
    }
   public static void SetBool(string key, bool isOn)
   {
        if (isOn)
        {
            PlayerPrefs.SetInt(key,1);
        }else
        {
            PlayerPrefs.SetInt(key,0);
        }
   }

   public static bool GetBool(string key)
   {
    return PlayerPrefs.GetInt(key) == 1 ? true : false;
   }
}
