using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;


public class ShopManager : MonoBehaviour
{
    // public ShopItem[] shopItems;
    public Button[] myPurchaseBtns;
    public TMP_Text coinsUser;
    public TMP_Text[] price;
    private int coins;
    public static bool flag;

    private void Start() {
        coins = PlayerPrefs.GetInt(PrefConst.COINS_KEY,coins);
        coinsUser.text = "CG: " + coins.ToString();
        
        for (int i = 0; i < myPurchaseBtns.Length+1; i++)
        {  
            if (PlayerPrefs.HasKey(PrefConst.PLAYER_PEFIX+i))
            {
                myPurchaseBtns[i-1].interactable = false;
                myPurchaseBtns[i-1].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
            }
        } 
    }

    public void PurchaseItem(int btnNo)
    {
        if (coins >= int.Parse(price[btnNo-1].GetComponent<TMP_Text>().text))
        {
            coins = coins - int.Parse(price[btnNo-1].GetComponent<TMP_Text>().text);
            PlayerPrefs.SetInt(PrefConst.COINS_KEY,coins);
            coinsUser.text = "CG: " + coins.ToString();
            // PlayerPrefs.SetInt("BuyCharacters",btnNo);
            PlayerPrefs.SetInt(PrefConst.PLAYER_PEFIX+btnNo,1);
            CheckOwned(btnNo);
        }
    }

    public bool CheckOwned(int btnNo)
    {   
        myPurchaseBtns[btnNo-1].interactable = false;
        myPurchaseBtns[btnNo-1].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
        return flag = true;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
  
}

