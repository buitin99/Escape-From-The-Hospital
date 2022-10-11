using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public TMP_Text price;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void UpdateUI(ShopItems item, int shopItemsId)
    {
        if (item == null) return;

        bool isUnlocked = Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemsId);

        if (isUnlocked)
        {
            if(price)
            price.text = "OWNED";
        }
        else
        {
            if(price)
                price.text = item.price.ToString();
        }

    } 
}
