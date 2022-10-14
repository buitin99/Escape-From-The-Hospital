using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsManager : MonoBehaviour
{
    private int coins;
    public TMP_Text coinsUser;
    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt(PrefConst.COINS_KEY,coins);
        coinsUser.text = "CG: " + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShopManager.flag || RewardedAds.flag)
        {
            ShopManager.flag = false;
            // RewardedAds.flag = false;
            coins = PlayerPrefs.GetInt(PrefConst.COINS_KEY,coins);
            coinsUser.text = "CG: " + coins.ToString();
        }
    }
}
