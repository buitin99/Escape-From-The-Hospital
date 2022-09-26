using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopManager : MonoBehaviour
{
    public ShopItem[] shopItems;
    public ShopTemplate[] shhopPannels;
  
    private void Awake() {
        LoadPannel();
    }
    
    public void LoadPannel()
    {
        for (int i =0; i < shopItems.Length; i++)
        {
            shhopPannels[i].titleTxt.text = shopItems[i].title;
            shhopPannels[i].descriptionTxt.text = shopItems[i].description;
            shhopPannels[i].ava.sprite = shopItems[i].ava;
            shhopPannels[i].priceTxt.text = "CG: " + shopItems[i].price.ToString();
        }
    }
}
