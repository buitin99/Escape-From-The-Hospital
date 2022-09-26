using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopManager : MonoBehaviour
{
    public ShopItem[] shopItems;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPannels;
    public Button[] myPurchaseBtns;
    public TMP_Text coinsUser;
    public int coins;
  
    private void Awake() {
        LoadPannel();
    }

    private void Start() {
        coinsUser.text = "CG: " + coins.ToString();
        for (int i= 0; i < shopPanelsGO.Length; i++)
        {
            shopPanelsGO[i].SetActive(true);
        }
        CheckPurchaseable();
    }

    public void CheckPurchaseable()
    {
        for (int i=0; i < shopItems.Length; i++)
        {
            if (coins >= shopItems[i].price)
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNo)
    {
        if (coins >= shopItems[btnNo].price)
        {
            coins = coins - shopItems[btnNo].price;
            coinsUser.text = "CG: " + coins.ToString();
            CheckOwned(btnNo);
        }
    }

    public void CheckOwned(int btnNo)
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            myPurchaseBtns[btnNo].interactable = false;
            myPurchaseBtns[btnNo].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
        }
    }
    
    public void LoadPannel()
    {
        for (int i = 0; i < shopItems.Length; i++)
        { 
            shopPannels[i].titleTxt.text = shopItems[i].title;
            shopPannels[i].descriptionTxt.text = shopItems[i].description;
            shopPannels[i].ava.sprite = shopItems[i].ava;
            shopPannels[i].priceTxt.text = "CG: " + shopItems[i].price.ToString();
        }
    }
}
