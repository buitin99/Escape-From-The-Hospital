using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characters;
    // Start is called before the first frame update
    void Start()
    {
        characters[PlayerPrefs.GetInt("SelectedCharacters", 0)].SetActive(true);
    }
}
