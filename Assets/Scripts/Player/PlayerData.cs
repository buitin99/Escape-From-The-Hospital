using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int totalLevel;
    public int totalCoins;
    public List<int> totalItems;

    public PlayerData ()
    {
        totalLevel = 6;
        totalCoins = 0;
        totalItems = new List<int>();
    }

    
    public void SaveData()
    {
        SaveSystem<PlayerData>.Save(this);
    }

    public static PlayerData Load()
    {
        return SaveSystem<PlayerData>.LoadData();
    }
}
