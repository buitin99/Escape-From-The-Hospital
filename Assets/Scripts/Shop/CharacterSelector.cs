using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject[] choiceCameraFreeLook;
    // Start is called before the first frame update
    void Start()
    {
        characters[PlayerPrefs.GetInt("SelectedCharacters", 0)].SetActive(true);

        for (int i = 0; i < choiceCameraFreeLook.Length; i++)
        {
            if (i == PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID))
            {
                choiceCameraFreeLook[i].SetActive(true);
            }
        }
    }
}
