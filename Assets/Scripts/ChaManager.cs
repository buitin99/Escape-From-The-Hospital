using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChaManager : MonoBehaviour
{
   public GameObject[] charactersModel;
   public void ChangeCharacter(int id)
   {
      PlayerPrefs.SetInt("SelectedCharacters",id);
   }

   public void ReturnStartScene()
   {
      SceneManager.LoadScene("StartScene");
   }

   public void Check()
   {
      foreach(int id in ShopManager.Instance.Owner)
         charactersModel[id].SetActive(true);
   }

    
}
