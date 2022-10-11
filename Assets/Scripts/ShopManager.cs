using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;


public class ShopManager : MonoBehaviour
{
    public ShopItem[] shopItems;

    public Button[] myPurchaseBtns;
    public TMP_Text coinsUser;
    public TMP_Text[] price;
    public int coins;
    public int totalCoins;
    public List<int> Owner;

    public GameObject[] ButtonOwner;


    public int currentCharactersIndex;

    // private static ShopManager instance = null;

    //  public static ShopManager Instance
    //     {
    //         get
    //         {
    //             if (instance == null)
    //             {
    //                 // Find singleton of this type in the scene
    //                 var instance = GameObject.FindObjectOfType<ShopManager>();

    //                 // If there is no singleton object in the scene, we have to add one
    //                 if (instance == null)
    //                 {
    //                     GameObject obj = new GameObject("Unity Singleton");
    //                     instance = obj.AddComponent<ShopManager>();

    //                     // The singleton object shouldn't be destroyed when we switch between scenes
    //                     DontDestroyOnLoad(obj);
    //                 }
    //             }

    //             return instance;
    //         }
    //     }

    // private void Awake() {
    //    if (instance == null)
    //         {
    //             instance = this;
    //             // The singleton object shouldn't be destroyed when we switch between scenes
    //             DontDestroyOnLoad(this.gameObject);
    //         }
    //         else
    //         {
    //             Destroy(gameObject);
    //         }
    // }

    private void Start() {
        coins = PlayerPrefs.GetInt("Coins",coins);
        coinsUser.text = "CG: " + coins.ToString();
        
        // currentCharactersIndex = PlayerPrefs.GetInt("BuyCharacters", -1);
        // myPurchaseBtns[currentCharactersIndex].interactable = false;
        // myPurchaseBtns[currentCharactersIndex].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";

        for (int i = 0; i < myPurchaseBtns.Length+1; i++)
        {  
            if (PlayerPrefs.HasKey(PrefConst.PLAYER_PEFIX+i))
            {
                myPurchaseBtns[i-1].interactable = false;
                myPurchaseBtns[i-1].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
            }
        } 
    }

    private void Update() {
        // CheckPurchaseable();
        // charactersId = PlayerPrefs.GetString("CharactersId",charactersId);
        // int.TryParse(charactersId, out arrayCharactersId);
        // Debug.Log(arrayCharactersId);

    }
    // public void CheckPurchaseable()
    // {
    //     for (int i=0; i < price.Length; i++)
    //     {
    //         if (coins >= int.Parse(price[i].GetComponent<TMP_Text>().text))
    //             myPurchaseBtns[i].interactable = true;
    //         else
    //             myPurchaseBtns[i].interactable = false;
    //     }
    // }

    public void PurchaseItem(int btnNo)
    {
        if (coins >= int.Parse(price[btnNo-1].GetComponent<TMP_Text>().text))
        {
            coins = coins - int.Parse(price[btnNo-1].GetComponent<TMP_Text>().text);
            PlayerPrefs.SetInt("Coins",coins);
            coinsUser.text = "CG: " + coins.ToString();
            PlayerPrefs.SetInt("BuyCharacters",btnNo);
            PlayerPrefs.SetInt(PrefConst.PLAYER_PEFIX+btnNo,1);
            CheckOwned(btnNo);
        }
    }

    public void CheckOwned(int btnNo)
    {   
        myPurchaseBtns[btnNo-1].interactable = false;
        myPurchaseBtns[btnNo-1].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
    }

    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
  
}

