using UnityEngine;

public class StartSceneManager : MonoBehaviour
{

    public GameObject[] characters;

    public int currentCharactersIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentCharactersIndex = PlayerPrefs.GetInt("SelectedCharacters", 0);
        characters[currentCharactersIndex].SetActive(true);
    }
}
