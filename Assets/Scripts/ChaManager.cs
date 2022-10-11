using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class ChaManager : MonoBehaviour
{
   public Button[] btn;


   private void Start() {

      for (int i = 0; i < btn.Length; i++)
      {
         if (i == 0)
         {
            btn[0].transform.GetChild(0).GetComponent<TMP_Text>().text = "OWNED";
            if (!btn[i].transform.GetChild(0).GetComponent<TMP_Text>().text.Equals("ACTIVE"))
            {
               btn[0].transform.GetChild(0).GetComponent<TMP_Text>().text = "ACTIVE";
            }    
         }else{
               if (!PlayerPrefs.HasKey(PrefConst.PLAYER_PEFIX + i))
            {
               btn[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "NOT OWNED";
               btn[i].interactable = false;
            }else
            {
               if (PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID) == i)
               {
                  btn[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "ACTIVE";
               }
               else
               {
                  btn[i].transform.GetChild(0).GetComponent<TMP_Text>().text = "OWNED";
               }
            }
         } 
      }
   }

   public void ChangeCharacter(int id)
   {
      btn[PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID)].transform.GetChild(0).GetComponent<TMP_Text>().text = "OWNED";
      if(PlayerPrefs.HasKey(PrefConst.PLAYER_PEFIX + id) || id == 0)
      {
         btn[id].transform.GetChild(0).GetComponent<TMP_Text>().text = "ACTIVE";
         PlayerPrefs.SetInt(PrefConst.CHANGED_CHARACTER, id);
         PlayerPrefs.SetInt(PrefConst.CUR_PLAYER_ID, id);
      }
   }

   public void ReturnStartScene()
   {
      SceneManager.LoadScene("StartScene");
   }   
}
