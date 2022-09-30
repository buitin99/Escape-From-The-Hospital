using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ShopManager : MonoBehaviour
{
    public ShopItem[] shopItems;
    public Button[] myPurchaseBtns;
    public TMP_Text coinsUser;
    public TMP_Text[] price;
    public int coins;
  
    private void Awake() {
      
    }

    private void Start() {
        coinsUser.text = "CG: " + coins.ToString();
    }

    private void Update() {
        // CheckPurchaseable();
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
        if (coins >= int.Parse(price[btnNo].GetComponent<TMP_Text>().text))
        {
            coins = coins - int.Parse(price[btnNo].GetComponent<TMP_Text>().text);
            coinsUser.text = "CG: " + coins.ToString();
            CheckOwned(btnNo);
        }
    }

    public void CheckOwned(int btnNo)
    {
        for (int i = 0; i < price.Length; i++)
        {
            myPurchaseBtns[btnNo].interactable = false;
            myPurchaseBtns[btnNo].transform.GetChild(0).GetComponent<TMP_Text>().text = "Owned";
        }
    }
    

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
